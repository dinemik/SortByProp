using SortbyProp.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortbyProp
{
    public partial class SortingUI : Form
    {
        private List<object> ObjLst;

        public SortingUI(string fild, object obj)
        {
            InitializeComponent();

            IEnumerable tmp = (IEnumerable)obj.GetType().GetProperty(fild).GetValue(obj);
            dgv.DataSource = ObjLst = tmp.Cast<object>().ToList();

            SortingProp.DataSource = ObjLst.First().GetType().GetProperties()
                .Where(o => o.GetCustomAttribute<FiltringBy>() != null)
                .Select(o => o.GetCustomAttribute<FiltringBy>().GetPropName)
                .ToList();
        }

        private void SortingProp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(SortingProp.SelectedItem.ToString()))
            {
                if (!SortBy.Checked)
                    dgv.DataSource = ObjLst = ObjLst.OrderBy(o => o.GetType().GetProperty(SortingProp.SelectedItem.ToString()).GetValue(o)).ToList();
                else
                    dgv.DataSource = ObjLst = ObjLst.OrderByDescending(o => o.GetType().GetProperty(SortingProp.SelectedItem.ToString()).GetValue(o)).ToList();
            }
        }
    }
}
