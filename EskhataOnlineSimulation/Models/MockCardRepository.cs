using EskhataOnlineSimulation.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EskhataOnlineSimulation.Models
{
    public class MockCardRepository : ICardRepository
    {
        private List<Card> _cards = null;
        public MockCardRepository()
        {

                   _cards = new List<Card>()
                   {
                    new Card { Id = 1, Account = 202016972001, Name = "Ягона", Status = true, },
                    new Card { Id = 2, Account = 202016972002, Name = "Ягона", Status = true, }
                    
                   };
        }
              


        public Card GetCardAccount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<Card> Cards => throw new NotImplementedException();

        public Card GetCardId(int cardId)
        {
            return _cards.FirstOrDefault(Id => Id.Id.Equals(cardId));
        }
    }
}
