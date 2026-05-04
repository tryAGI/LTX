
#nullable enable

namespace LTX
{
    /// <summary>
    /// 
    /// </summary>
    public enum LtxModel
    {
        /// <summary>
        /// 
        /// </summary>
        Ltx23Fast,
        /// <summary>
        /// 
        /// </summary>
        Ltx23Pro,
        /// <summary>
        /// 
        /// </summary>
        Ltx2Fast,
        /// <summary>
        /// 
        /// </summary>
        Ltx2Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LtxModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LtxModel value)
        {
            return value switch
            {
                LtxModel.Ltx23Fast => "ltx-2-3-fast",
                LtxModel.Ltx23Pro => "ltx-2-3-pro",
                LtxModel.Ltx2Fast => "ltx-2-fast",
                LtxModel.Ltx2Pro => "ltx-2-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LtxModel? ToEnum(string value)
        {
            return value switch
            {
                "ltx-2-3-fast" => LtxModel.Ltx23Fast,
                "ltx-2-3-pro" => LtxModel.Ltx23Pro,
                "ltx-2-fast" => LtxModel.Ltx2Fast,
                "ltx-2-pro" => LtxModel.Ltx2Pro,
                _ => null,
            };
        }
    }
}