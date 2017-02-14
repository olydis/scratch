// MIT

namespace BlobStorageTest.Client.Models
{
    using Client;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CopyStatusType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CopyStatusType
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "aborted")]
        Aborted,
        [EnumMember(Value = "failed")]
        Failed
    }
    internal static class CopyStatusTypeEnumExtension
    {
        internal static string ToSerializedValue(this CopyStatusType? value )  =>
            value == null ? null : (( CopyStatusType )value).ToSerializedValue();

        internal static string ToSerializedValue(this CopyStatusType value )
        {
            switch( value )
            {
                case CopyStatusType.Pending:
                    return "pending";
                case CopyStatusType.Success:
                    return "success";
                case CopyStatusType.Aborted:
                    return "aborted";
                case CopyStatusType.Failed:
                    return "failed";
            }
            return null;
        }

        internal static CopyStatusType? ParseCopyStatusType( this string value )
        {
            switch( value )
            {
                case "pending":
                    return CopyStatusType.Pending;
                case "success":
                    return CopyStatusType.Success;
                case "aborted":
                    return CopyStatusType.Aborted;
                case "failed":
                    return CopyStatusType.Failed;
            }
            return null;
        }
    }
}

