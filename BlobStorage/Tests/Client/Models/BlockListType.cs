// MIT

namespace BlobStorageTest.Client.Models
{
    using Client;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for BlockListType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BlockListType
    {
        [EnumMember(Value = "committed")]
        Committed,
        [EnumMember(Value = "uncommitted")]
        Uncommitted,
        [EnumMember(Value = "all")]
        All
    }
    internal static class BlockListTypeEnumExtension
    {
        internal static string ToSerializedValue(this BlockListType? value )  =>
            value == null ? null : (( BlockListType )value).ToSerializedValue();

        internal static string ToSerializedValue(this BlockListType value )
        {
            switch( value )
            {
                case BlockListType.Committed:
                    return "committed";
                case BlockListType.Uncommitted:
                    return "uncommitted";
                case BlockListType.All:
                    return "all";
            }
            return null;
        }

        internal static BlockListType? ParseBlockListType( this string value )
        {
            switch( value )
            {
                case "committed":
                    return BlockListType.Committed;
                case "uncommitted":
                    return BlockListType.Uncommitted;
                case "all":
                    return BlockListType.All;
            }
            return null;
        }
    }
}

