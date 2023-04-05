using EskhataOnlineSimulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EskhataOnlineSimulation.Interfases
{
  public  interface IClientRepository
    {
       public Client GetClient(int IdClient);

    }
}
