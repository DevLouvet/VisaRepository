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
    }
}
