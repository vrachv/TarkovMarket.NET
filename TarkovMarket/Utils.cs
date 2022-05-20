using System.Linq;
using System.Runtime.Serialization;
using TarkovMarket.Models;

namespace TarkovMarket;

public static class Utils
{
    public static string ToLanguageString(this Lang lang)
    {
        return typeof(Lang).GetMember(lang.ToString())[0].GetCustomAttributes(false)
            .OfType<EnumMemberAttribute>().FirstOrDefault()?.Value;
    }
}