// MIT

namespace BlobStorageTest.Client.Models
{
    using Client;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DeleteSnapshotsOption.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeleteSnapshotsOption
    {
        [EnumMember(Value = "include")]
        Include,
        [EnumMember(Value = "only")]
        Only
    }
    internal static class DeleteSnapshotsOptionEnumExtension
    {
        internal static string ToSerializedValue(this DeleteSnapshotsOption? value )  =>
            value == null ? null : (( DeleteSnapshotsOption )value).ToSerializedValue();

        internal static string ToSerializedValue(this DeleteSnapshotsOption value )
        {
            switch( value )
            {
                case DeleteSnapshotsOption.Include:
                    return "include";
                case DeleteSnapshotsOption.Only:
                    return "only";
            }
            return null;
        }

        internal static DeleteSnapshotsOption? ParseDeleteSnapshotsOption( this string value )
        {
            switch( value )
            {
                case "include":
                    return DeleteSnapshotsOption.Include;
                case "only":
                    return DeleteSnapshotsOption.Only;
            }
            return null;
        }
    }
}

