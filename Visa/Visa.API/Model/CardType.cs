using System.Runtime.Serialization;

namespace Visa.API.Model
{
    public enum CardType
    {
        [EnumMember(Value = "Unknown")]
        Unknown = 0,

        [EnumMember(Value = "Visa")]
        Visa = 1,

        [EnumMember(Value = "Master")]
        Master = 2,

        [EnumMember(Value = "Amex")]
        Amex = 3,

        [EnumMember(Value = "JCB")]
        JCB = 4
    }
}
