// Our custom header

namespace blob-storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for LeaseStatusType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LeaseStatusType
    {
        [EnumMember(Value = "locked")]
        Locked,
        [EnumMember(Value = "unlocked")]
        Unlocked
    }
    internal static class LeaseStatusTypeEnumExtension
    {
        internal static string ToSerializedValue(this LeaseStatusType? value )  =>
            value == null ? null : (( LeaseStatusType )value).ToSerializedValue();

        internal static string ToSerializedValue(this LeaseStatusType value )
        {
            switch( value )
            {
                case LeaseStatusType.Locked:
                    return "locked";
                case LeaseStatusType.Unlocked:
                    return "unlocked";
            }
            return null;
        }

        internal static LeaseStatusType? ParseLeaseStatusType( this string value )
        {
            switch( value )
            {
                case "locked":
                    return LeaseStatusType.Locked;
                case "unlocked":
                    return LeaseStatusType.Unlocked;
            }
            return null;
        }
    }
}

