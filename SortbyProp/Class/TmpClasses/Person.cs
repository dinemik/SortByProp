using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortbyProp.Class.TmpClasses
{
    public class Person
    {
        [FiltringBy("ID")]
        public int ID { get; set; }

        [FiltringBy]
        public string Name { get; set; }

        [FiltringBy("Last Name")]
        public string LName { get; set; }
    }
}
