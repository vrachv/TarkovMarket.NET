using System.Runtime.Serialization;

namespace TarkovMarket.Models;

public enum TarkovCurrency
{
    [EnumMember(Value = "₽")]
    Ruble,

    [EnumMember(Value = "$")]
    Dollar,

    [EnumMember(Value = "€")]
    Euro
}