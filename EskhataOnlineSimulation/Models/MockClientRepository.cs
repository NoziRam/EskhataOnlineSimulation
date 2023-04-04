using EskhataOnlineSimulation.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EskhataOnlineSimulation.Models
{
    public class MockClientRepository : IClientRepository
    {
        private List<Client> _clients = null;

        public MockClientRepository()
        {
            _clients = new List<Client>()
            {
                new Client() { Id=1, FirstName = "Гайратчон", LastName ="Каримов", PhoneNumber = 928207882, Gender = "мард", Email= "karimi@com"},


            };

        }


        public Client GetClient(int IdClient)
        {
            return _clients.FirstOrDefault(client => client.Id.Equals(IdClient));
        }
    }
}
