﻿using System;
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
        public DateTime sowingDate { get; set; }
        public DateTime outdoorsDate { get; set; }
        public string comment { get; set; }

        public Plant(int id, int refId, DateTime sowingDate, DateTime outdoorsDate, string comment)
        {
            this.id = id;
            this.refId = refId;
            this.sowingDate = sowingDate;
            this.outdoorsDate = outdoorsDate;
            this.comment = comment;
        }

        public Plant()
        {
        }
    }
}
