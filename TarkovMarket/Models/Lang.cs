using System.Runtime.Serialization;

namespace TarkovMarket.Models
{
    public enum Lang
    {
        [EnumMember(Value = "en")]
        English,
        
        [EnumMember(Value = "ru")]
        Russian,
        
        [EnumMember(Value = "de")]
        German,
        
        [EnumMember(Value = "fr")]
        French,
        
        [EnumMember(Value = "es")]
        Spanish,
        
        [EnumMember(Value = "cn")]
        Chinese,
        
        [EnumMember(Value = "cz")]
        Czech,
        
        [EnumMember(Value = "hu")]
        Hungarian,
        
        [EnumMember(Value = "tr")]
        Turkish,
    }
}