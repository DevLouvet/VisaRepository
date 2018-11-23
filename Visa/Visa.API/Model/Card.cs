using System.ComponentModel.DataAnnotations.Schema;

namespace Visa.API.Model
{
    public class Card : BaseEntity
    {
        public override int Id { get; set; }
        public string CardNumber { get; set; }
        public int ExpirationDate { get; set; }

        [NotMapped]
        public CardType TCard { get; set; }

        [NotMapped]
        public CardValidation VCard { get; set; }
    }
}
