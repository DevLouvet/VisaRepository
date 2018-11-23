using System.Runtime.Serialization;

namespace Visa.API.Model
{
    public enum CardValidation
    {
        [EnumMember(Value = "Does not exist")]
        Nonexistence = 0,

        [EnumMember(Value = "Valid")]
        Valid = 1,

        [EnumMember(Value = "Invalid")]
        Invalid = 2
    }
}
