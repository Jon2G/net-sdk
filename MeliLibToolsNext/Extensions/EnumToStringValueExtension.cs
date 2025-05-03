using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MeliLibToolsNext.Extensions
{
    internal static class EnumToStringValueExtension
    {
        public static string GetStringValue(this Enum value)
        {
#if NET9_0_OR_GREATER
            var type = value.GetType();
            var fieldInfo = type.GetField(value.ToString());
            var attributes = fieldInfo.GetCustomAttributes(false);
            if (attributes.Length == 0)
                return value.ToString();
            var attribute = attributes[0] as JsonStringEnumMemberNameAttribute;
            return attribute?.Name ?? value.ToString();
#else
            return value.ToString();
#endif
        }
    }
}
