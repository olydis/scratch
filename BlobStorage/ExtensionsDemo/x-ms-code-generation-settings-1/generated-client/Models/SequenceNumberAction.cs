// Our custom header

namespace blob-storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SequenceNumberAction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SequenceNumberAction
    {
        [EnumMember(Value = "max")]
        Max,
        [EnumMember(Value = "update")]
        Update,
        [EnumMember(Value = "increment")]
        Increment
    }
    internal static class SequenceNumberActionEnumExtension
    {
        internal static string ToSerializedValue(this SequenceNumberAction? value )  =>
            value == null ? null : (( SequenceNumberAction )value).ToSerializedValue();

        internal static string ToSerializedValue(this SequenceNumberAction value )
        {
            switch( value )
            {
                case SequenceNumberAction.Max:
                    return "max";
                case SequenceNumberAction.Update:
                    return "update";
                case SequenceNumberAction.Increment:
                    return "increment";
            }
            return null;
        }

        internal static SequenceNumberAction? ParseSequenceNumberAction( this string value )
        {
            switch( value )
            {
                case "max":
                    return SequenceNumberAction.Max;
                case "update":
                    return SequenceNumberAction.Update;
                case "increment":
                    return SequenceNumberAction.Increment;
            }
            return null;
        }
    }
}

