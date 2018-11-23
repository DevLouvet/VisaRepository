using Microsoft.EntityFrameworkCore;
using System.Linq;
using Visa.API.Model;

namespace Visa.API.Context
{
    public class CardDbContext : DbContext
    {
        public CardDbContext(DbContextOptions<CardDbContext> options) : base(options)
        {

        }

        public DbSet<Card> Cards { get; set; }
        public Card ValidateCard(Card card)
        {
            return Cards.FromSql("ValidateCard @p0, @p1", card.CardNumber, card.ExpirationDate).FirstOrDefault();
        }
    }
}
