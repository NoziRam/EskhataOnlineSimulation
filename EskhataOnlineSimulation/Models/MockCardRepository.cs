using EskhataOnlineSimulation.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EskhataOnlineSimulation.Models
{
    public class MockCardRepository : ICardRepository
    {
        public IEnumerable<Card> Cards
        {
            get
            {
                return new List<Card>
                {
                    new Card { Id = 1, Account = 202016972001, Name = "Ягона", Status = true, },


                };


            }
        }
                
                
        public Card GetCardAccount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Card GetCardId(int cardId)
        {
            throw new NotImplementedException();
        }
    }
}
