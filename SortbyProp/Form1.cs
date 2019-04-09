using SortbyProp.Class.TmpClasses;
using System;
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
    public partial class Form1 : Form
    {
        static List<object> list = new List<object>
        {
            new PersonsDb(),
            new MarketDb(),
            new CoffesDb(),
        };

        public Form1()
        {
            InitializeComponent();
            List<string> forCb = new List<string>();
            forCb.Add("");
            foreach (var item in list)
            {
                PropertyInfo[] allProps = item.GetType().GetProperties().Where(x => x.CanRead).ToArray();
                foreach (var itm in allProps)
                {
                    forCb.Add(itm.Name);
                }
            }

            comboBox1.DataSource = forCb;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                foreach (var item in list)
                {
                    foreach (var itm in item.GetType().GetProperties().Where(x => x.CanRead).ToArray())
                    {
                        if (itm.Name == comboBox1.SelectedItem.ToString())
                            new SortingUI(comboBox1.SelectedItem.ToString(), item).Show();
                    }
                }
            }
        }
    }
}
