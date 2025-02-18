using System.ComponentModel;
using System.Reflection;

namespace InfaktGateway.Models.Costs
{
    public enum ContentType
    {
        [Description("application/pdf")]
        pdf,
        [Description("image/png")]
        png,
        [Description("image/jpeg")]
        jpg
    }

    public static class ContentTypeExtension
    {
        public static string? GetMimeType(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null)
            {
                return null;
            }

            var attribute = fieldInfo.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description;
        }
    }
}
