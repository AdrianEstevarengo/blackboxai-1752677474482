using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;

namespace Infra.CrossCutting.Helpers
{
    public static class EnumExtensions
    {
        private static readonly ConcurrentDictionary<Enum, string> DisplayNameCache = new();

        public static string ToStringRepresentation<T>(this T enumValue)
            where T : Enum
        {
            return enumValue.ToString();
        }

        public static T ToEnumValue<T>(this string stringValue)
            where T : Enum
        {
            if (Enum.TryParse(typeof(T), stringValue, true, out var result))
            {
                return (T)result;
            }
            else
            {
                throw new ArgumentException(
                    $"'{stringValue}' is not a valid value for enum {typeof(T).Name}."
                );
            }
        }

        public static string GetDisplayName<T>(this T? enumValue)
            where T : struct, Enum
        {
            return enumValue.HasValue
                ? GetDisplayName(enumValue.Value)
                : throw new ArgumentNullException(nameof(enumValue), "Enum value cannot be null.");
        }

        public static string GetDisplayName<T>(this T enumValue)
            where T : Enum
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            if (fieldInfo == null)
                return enumValue.ToString();

            var displayAttribute =
                fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault()
                as DisplayAttribute;

            return displayAttribute?.Name ?? enumValue.ToString();
        }
    }
}