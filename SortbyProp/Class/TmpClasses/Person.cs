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

        public string Name { get; set; }

        [FiltringBy("LName")]
        public string LName { get; set; }
    }
}
