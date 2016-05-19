using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotAndSpicy.Models
{
    class Plant
    {
        public int id { get; set; }
        public int refId { get; set; }
        public string sowingDate { get; set; }
        public string outdoorsDate { get; set; }
        public string comment { get; set; }

        public Plant()
        {

        }



    }
}
