// Our custom header

namespace blob-storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for GeoReplicationStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GeoReplicationStatus
    {
        [EnumMember(Value = "live")]
        Live,
        [EnumMember(Value = "bootstrap")]
        Bootstrap,
        [EnumMember(Value = "unavailable")]
        Unavailable
    }
    internal static class GeoReplicationStatusEnumExtension
    {
        internal static string ToSerializedValue(this GeoReplicationStatus? value )  =>
            value == null ? null : (( GeoReplicationStatus )value).ToSerializedValue();

        internal static string ToSerializedValue(this GeoReplicationStatus value )
        {
            switch( value )
            {
                case GeoReplicationStatus.Live:
                    return "live";
                case GeoReplicationStatus.Bootstrap:
                    return "bootstrap";
                case GeoReplicationStatus.Unavailable:
                    return "unavailable";
            }
            return null;
        }

        internal static GeoReplicationStatus? ParseGeoReplicationStatus( this string value )
        {
            switch( value )
            {
                case "live":
                    return GeoReplicationStatus.Live;
                case "bootstrap":
                    return GeoReplicationStatus.Bootstrap;
                case "unavailable":
                    return GeoReplicationStatus.Unavailable;
            }
            return null;
        }
    }
}

