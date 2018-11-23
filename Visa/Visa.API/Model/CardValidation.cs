using System.ComponentModel;

namespace Visa.API.Model
{
    public enum CardValidation
    {
        [Description("Does not exist")]
        Nonexistence = 0,
        Valid = 1,
        Invalid = 2
    }
}
