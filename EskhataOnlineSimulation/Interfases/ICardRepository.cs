using EskhataOnlineSimulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EskhataOnlineSimulation.Interfases
{
  public  interface ICardRepository
    {
        IEnumerable<Card> Cards { get; set; }

        Card GetCardAccount { get; set; }

    }
}
