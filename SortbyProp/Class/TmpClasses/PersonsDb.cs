using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortbyProp.Class.TmpClasses
{
    public class PersonsDb
    {
        public List<Person> Presons { get; set; } = new List<Person>
        {
            new Person{ ID = 1, LName = "asdadad", Name = "addd" },
            new Person{ ID = 2, LName = "asdadad", Name = "addd" },
            new Person{ ID = 5, LName = "asdadad", Name = "addd" },
            new Person{ ID = 3, LName = "asdadad", Name = "addd" },
            new Person{ ID = 4, LName = "asdadad", Name = "addd" },
            new Person{ ID = 6, LName = "asdadad", Name = "addd" }
        };
    }
}
