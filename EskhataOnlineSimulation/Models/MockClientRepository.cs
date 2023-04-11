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
            _clients = new List<Client>() {

            new Client(){ Id =1, FirstName="Гайратчон", LastName="Каримов", PhoneNumber = 928207882, Gender =Gender.Man, DateOfBirth = DateTime.Today }


            };
        }

        public Client Create(Client client)
        {
            client.Id = _clients.Max(c => c.Id) + 1;
            _clients.Add(client);
            return client;
        }

        public Client GetClient(int id)
    {
           
             return _clients.FirstOrDefault(c => c.Id.Equals(id));
    }
}
}
