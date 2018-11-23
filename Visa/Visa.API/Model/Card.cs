namespace Visa.API.Model
{
    public class Card
    {
        public int CardNumber { get; set; }
        public int ExpirationDate { get; set; }
        public CardType TCard { get; set; }
        public CardValidation VCard { get; set; }
    }
}
