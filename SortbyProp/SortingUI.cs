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

            var AtributeHasPropName = ObjLst.First().GetType().GetProperties()
                .Select(o => o.GetCustomAttribute<FiltringBy>()?.GetPropName)
                .Where(o => o != null).ToList();

            var AtributeHasNotPropName = ObjLst.First().GetType().GetProperties()
                .Where(o => o.GetCustomAttribute<FiltringBy>() != null 
                        && o.GetCustomAttribute<FiltringBy>().GetPropName == null)
                .Select(o => o.Name).ToList();

            AtributeHasPropName.AddRange(AtributeHasNotPropName);

            SortingProp.DataSource = AtributeHasPropName;
        }

        private void SortingProp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SortingProp.SelectedItem.ToString()))
            {
                var PropName = ObjLst.Select(o => o).First().GetType().GetProperties()
                    .FirstOrDefault(o => o.GetCustomAttribute<FiltringBy>()?.GetPropName == SortingProp.SelectedItem.ToString()
                    || o.Name == SortingProp.SelectedItem.ToString()).Name;

                if (!SortBy.Checked)
                    dgv.DataSource = ObjLst = ObjLst.OrderBy(o => o.GetType().GetProperty(PropName).GetValue(o)).ToList();
                else
                    dgv.DataSource = ObjLst = ObjLst.OrderByDescending(o => o.GetType().GetProperty(PropName).GetValue(o)).ToList();
            }
        }
    }
}
