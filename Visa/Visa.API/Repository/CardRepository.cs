using System;
using System.Collections.Generic;
using System.Linq;
using Visa.API.Context;
using Visa.API.Model;

namespace Visa.API.Repository
{
    public class CardRepository : BaseRepository<Card>
    {
        public CardRepository(CardDbContext cardDbContext) : base(cardDbContext)
        {
        }

        public Card ValidateCard(Card card)
        {
            return _cardDbContext.ValidateCard(card);
        }

        public Card Find(Card card)
        {
            return _cardDbContext.Cards.FirstOrDefault(c => c.CardNumber == card.CardNumber && c.ExpirationDate == card.ExpirationDate);
        }
    }
}
