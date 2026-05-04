
#nullable enable

namespace LTX
{
    /// <summary>
    /// 
    /// </summary>
    public enum RetakeRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Both,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetakeRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetakeRequestMode value)
        {
            return value switch
            {
                RetakeRequestMode.Audio => "audio",
                RetakeRequestMode.Both => "both",
                RetakeRequestMode.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetakeRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "audio" => RetakeRequestMode.Audio,
                "both" => RetakeRequestMode.Both,
                "video" => RetakeRequestMode.Video,
                _ => null,
            };
        }
    }
}