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
        private object ObjDb;
        private IEnumerable ObjLst;

        public SortingUI(string fild, object obj)
        {
            InitializeComponent();
            ObjDb = obj;

            var quer = ObjDb.GetType().GetProperties()
                .Select(x => new { Proporty = x, Attribute = x.GetCustomAttributes(false) })
                .ToList();

            foreach (var item in quer)
            {
                ObjLst = (IEnumerable)item.Proporty.GetValue(obj);
            }
            dgv.DataSource = ObjLst;

            List<string> forCb = new List<string>();
            forCb.Add("");

            foreach (var item in ObjLst)
            {
                var Obj = item.GetType().GetProperties()
                .Select(x => new { Proporty = x, Attribute = x.GetCustomAttributes(false) })
                .ToList();
                foreach (var itm in Obj)
                {
                    var art = itm.Attribute.Count() != 0 ? itm.Attribute.First() : null;
                    if (art != null)
                    {
                        var cas = (FiltringBy)art;
                        forCb.Add(cas.GetPropName);
                    }
                }
                break;
            }
            SortingProp.DataSource = forCb;
        }

        private void SortingProp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(SortingProp.SelectedItem.ToString()))
            {
                List<object> LstOfSortedItems = new List<object>();
                foreach (var item in ObjLst)
                {
                    var Obj = item.GetType().GetProperties()
                    .Select(x => new { Proporty = x, Attribute = x.GetCustomAttributes(false) }).ToList();

                    LstOfSortedItems.Add(item);
                }

                if (SortBy.Checked)
                    LstOfSortedItems.OrderBy(o => o.GetType().GetProperty(SortingProp.SelectedItem.ToString()));
                else
                    LstOfSortedItems.OrderByDescending(o => o.GetType().GetProperty(SortingProp.SelectedItem.ToString()));

                dgv.DataSource = LstOfSortedItems;
            }
        }
    }
}
