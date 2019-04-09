using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortbyProp.Class.TmpClasses
{
    public class Market
    {
        [FiltringBy("ID")]
        public int ID { get; set; }

        public string MarkName { get; set; }
    }
}
