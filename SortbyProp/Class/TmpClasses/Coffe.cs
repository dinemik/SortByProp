using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortbyProp.Class.TmpClasses
{
    public class Coffe
    {
        [FiltringBy("Coffe ID")]
        public int CoffeID { get; set; }

        [FiltringBy]
        public string CoffeName { get; set; }

        [FiltringBy("Coffe Price")]
        public double CoffePrice { get; set; }
    }
}
