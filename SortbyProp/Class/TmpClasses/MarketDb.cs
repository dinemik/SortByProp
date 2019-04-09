using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortbyProp.Class.TmpClasses
{
    public class MarketDb
    {
        public List<Market> Markets { get; set; } = new List<Market>
        {
            new Market{ ID = 1, MarkName = "asdadad" },
            new Market{ ID = 2, MarkName = "asdadad" },
            new Market{ ID = 5, MarkName = "asdadad" },
            new Market{ ID = 3, MarkName = "asdadad" },
            new Market{ ID = 4, MarkName = "asdadad" },
            new Market{ ID = 6, MarkName = "asdadad" }
        };

        public IEnumerable<Market> ID(bool filt) => filt ? Markets.OrderBy(o => o.ID) : Markets.OrderByDescending(o => o.ID);
    }
}
