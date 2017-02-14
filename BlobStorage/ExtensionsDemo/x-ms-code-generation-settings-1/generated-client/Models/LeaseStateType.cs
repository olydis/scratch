// Our custom header

namespace blob-storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for LeaseStateType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LeaseStateType
    {
        [EnumMember(Value = "available")]
        Available,
        [EnumMember(Value = "leased")]
        Leased,
        [EnumMember(Value = "expired")]
        Expired,
        [EnumMember(Value = "breaking")]
        Breaking,
        [EnumMember(Value = "broken")]
        Broken
    }
    internal static class LeaseStateTypeEnumExtension
    {
        internal static string ToSerializedValue(this LeaseStateType? value )  =>
            value == null ? null : (( LeaseStateType )value).ToSerializedValue();

        internal static string ToSerializedValue(this LeaseStateType value )
        {
            switch( value )
            {
                case LeaseStateType.Available:
                    return "available";
                case LeaseStateType.Leased:
                    return "leased";
                case LeaseStateType.Expired:
                    return "expired";
                case LeaseStateType.Breaking:
                    return "breaking";
                case LeaseStateType.Broken:
                    return "broken";
            }
            return null;
        }

        internal static LeaseStateType? ParseLeaseStateType( this string value )
        {
            switch( value )
            {
                case "available":
                    return LeaseStateType.Available;
                case "leased":
                    return LeaseStateType.Leased;
                case "expired":
                    return LeaseStateType.Expired;
                case "breaking":
                    return LeaseStateType.Breaking;
                case "broken":
                    return LeaseStateType.Broken;
            }
            return null;
        }
    }
}

