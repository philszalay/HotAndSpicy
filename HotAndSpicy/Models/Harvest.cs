using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotAndSpicy.Models
{
    class Harvest
    {
        public string date { get; set; }
        public int amount { get; set; }
        public int refId { get; set; }

        public Harvest()
        {

        }

        public Harvest(int amount ,string date,int refId)
        {
            this.date = date;
            this.amount = amount;
            this.refId = refId;
        }
    }
}
