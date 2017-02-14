// MIT

namespace BlobStorageTest.Client.Models
{
    using Client;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PageWrite.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PageWrite
    {
        [EnumMember(Value = "update")]
        Update,
        [EnumMember(Value = "clear")]
        Clear
    }
    internal static class PageWriteEnumExtension
    {
        internal static string ToSerializedValue(this PageWrite? value )  =>
            value == null ? null : (( PageWrite )value).ToSerializedValue();

        internal static string ToSerializedValue(this PageWrite value )
        {
            switch( value )
            {
                case PageWrite.Update:
                    return "update";
                case PageWrite.Clear:
                    return "clear";
            }
            return null;
        }

        internal static PageWrite? ParsePageWrite( this string value )
        {
            switch( value )
            {
                case "update":
                    return PageWrite.Update;
                case "clear":
                    return PageWrite.Clear;
            }
            return null;
        }
    }
}

