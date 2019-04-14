using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortbyProp.Class.TmpClasses
{
    public class CoffesDb
    {
        public List<Coffe> Coffes { get; set; } = new List<Coffe>
        {
            new Coffe{ CoffeID = 1, CoffeName = "aname", CoffePrice = 12.1 },
            new Coffe{ CoffeID = 3, CoffeName = "bname", CoffePrice = 12.1 },
            new Coffe{ CoffeID = 2, CoffeName = "cname", CoffePrice = 12.13 },
            new Coffe{ CoffeID = 3, CoffeName = "dname", CoffePrice = 32.1 },
            new Coffe{ CoffeID = 5, CoffeName = "iname", CoffePrice = 62.1 },
            new Coffe{ CoffeID = 1, CoffeName = "fname", CoffePrice = 19.1 }
        };
    }
}
