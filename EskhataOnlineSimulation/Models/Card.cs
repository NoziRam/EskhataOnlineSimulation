using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EskhataOnlineSimulation.Models
{
    public class Card
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public int Account { get; set; }

        public bool Status { get; set; }
        
        public virtual Client Client { get; set; } 

    }
}
