using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotAndSpicy.Models
{
    class Chili
    {
        public int id { get; set; }
        public string name { get; set; }
        public string sowingMonth { get; set; }
        public string severityLevel { get; set; }
        public string outdoorsAfter { get; set; }
        public string hybridSeed { get; set; }
        public string inUse { get; set; }

        public Chili()
        {

        }


        public Chili(int id, string name, string sowingMonth, string severityLevel, string outdoorsAfter, string hybridSeed, string inUse)
        {
            this.id = id;
            this.name = name;
            this.sowingMonth = sowingMonth;
            this.severityLevel = severityLevel;
            this.outdoorsAfter = outdoorsAfter;
            this.hybridSeed = hybridSeed;
            this.inUse = inUse;
        }


    }
}
