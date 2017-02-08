// Our custom header

namespace blob-storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for LeaseDurationType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LeaseDurationType
    {
        [EnumMember(Value = "infinite")]
        Infinite,
        [EnumMember(Value = "fixed")]
        Fixed
    }
    internal static class LeaseDurationTypeEnumExtension
    {
        internal static string ToSerializedValue(this LeaseDurationType? value )  =>
            value == null ? null : (( LeaseDurationType )value).ToSerializedValue();

        internal static string ToSerializedValue(this LeaseDurationType value )
        {
            switch( value )
            {
                case LeaseDurationType.Infinite:
                    return "infinite";
                case LeaseDurationType.Fixed:
                    return "fixed";
            }
            return null;
        }

        internal static LeaseDurationType? ParseLeaseDurationType( this string value )
        {
            switch( value )
            {
                case "infinite":
                    return LeaseDurationType.Infinite;
                case "fixed":
                    return LeaseDurationType.Fixed;
            }
            return null;
        }
    }
}

