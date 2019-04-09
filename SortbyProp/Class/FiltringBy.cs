using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortbyProp.Class
{
    public class FiltringBy : Attribute
    {
        public string GetPropName { get; set; }

        public FiltringBy(string pName)
        {
            GetPropName = pName;
        }
    }
}
