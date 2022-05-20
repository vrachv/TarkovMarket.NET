using System.Runtime.Serialization;

namespace TarkovMarket.Models;

public enum TarkovTrader
{
    [EnumMember(Value = "Prapor")]
    Prapor,

    [EnumMember(Value = "Therapist")]
    Therapist,

    [EnumMember(Value = "Mechanic")]
    Mechanic,

    [EnumMember(Value = "Peacekeeper")]
    Peacekeeper,

    [EnumMember(Value = "Jaeger")]
    Jaeger,

    [EnumMember(Value = "Ragman")]
    Ragman,

    [EnumMember(Value = "Fence")]
    Fence,

    [EnumMember(Value = "Skier")]
    Skier
}