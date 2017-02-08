// MIT

namespace BlobStorageTest.Client.Models
{
    using Client;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for BlobType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BlobType
    {
        [EnumMember(Value = "BlockBlob")]
        BlockBlob,
        [EnumMember(Value = "PageBlob")]
        PageBlob,
        [EnumMember(Value = "AppendBlob")]
        AppendBlob
    }
    internal static class BlobTypeEnumExtension
    {
        internal static string ToSerializedValue(this BlobType? value )  =>
            value == null ? null : (( BlobType )value).ToSerializedValue();

        internal static string ToSerializedValue(this BlobType value )
        {
            switch( value )
            {
                case BlobType.BlockBlob:
                    return "BlockBlob";
                case BlobType.PageBlob:
                    return "PageBlob";
                case BlobType.AppendBlob:
                    return "AppendBlob";
            }
            return null;
        }

        internal static BlobType? ParseBlobType( this string value )
        {
            switch( value )
            {
                case "BlockBlob":
                    return BlobType.BlockBlob;
                case "PageBlob":
                    return BlobType.PageBlob;
                case "AppendBlob":
                    return BlobType.AppendBlob;
            }
            return null;
        }
    }
}

