using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Visa.API.Model
{
    public class Card : BaseEntity
    {
        [JsonIgnore]
        public override int Id { get; set; }

        [JsonIgnore]
        public string CardNumber { get; set; }

        [JsonIgnore]
        public int ExpirationDate { get; set; }

        [JsonProperty("Card Type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CardType? TCard { get; set; }

        [JsonProperty("Result")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CardValidation? VCard { get; set; }
    }
}
