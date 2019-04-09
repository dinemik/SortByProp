using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortbyProp.Class.TmpClasses
{
    public class Coffe
    {
        [FiltringBy("CoffeID")]
        public int CoffeID { get; set; }
        public string CoffeName { get; set; }
        [FiltringBy("CoffePrice")]
        public double CoffePrice { get; set; }
    }
}
