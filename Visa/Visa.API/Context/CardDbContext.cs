using Microsoft.EntityFrameworkCore;
using Visa.API.Model;

namespace Visa.API.Context
{
    public class CardDbContext : DbContext
    {
        public CardDbContext(DbContextOptions<CardDbContext> options) : base(options)
        {

        }

        public DbSet<Card> Cards { get; set; }
    }
}
