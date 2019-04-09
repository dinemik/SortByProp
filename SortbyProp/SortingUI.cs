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
        private IList ObjLst;

        public SortingUI(string fild, object obj)
        {
            InitializeComponent();
            ObjDb = obj;

            var quer = ObjDb.GetType().GetProperties()
                .Select(x => new { Proporty = x, Attribute = x.GetCustomAttributes(false) })
                .ToList();

            foreach (var item in quer)
            {
                ObjLst = (IList)item.Proporty.GetValue(obj);
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
                var t = ObjDb.GetType().GetMethod(SortingProp.SelectedItem.ToString());
                List<object> newList = new List<object>();

                object inwoked;

                if (SortBy.Checked)
                    inwoked = t.Invoke(ObjDb, new object[] { true });
                else
                    inwoked = t.Invoke(ObjDb, new object[] { false });

                foreach (var item in (IEnumerable<object>)inwoked)
                {
                    newList.Add(item);
                }

                dgv.DataSource = ObjLst = newList;
            }
        }
    }
}
