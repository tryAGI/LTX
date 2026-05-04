
#nullable enable

namespace LTX
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToVideoRequestVariant2
    {
        /// <summary>
        /// HTTPS, data URI, or LTX storage URI for the reference image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoRequestVariant2" /> class.
        /// </summary>
        /// <param name="imageUri">
        /// HTTPS, data URI, or LTX storage URI for the reference image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToVideoRequestVariant2(
            string imageUri)
        {
            this.ImageUri = imageUri ?? throw new global::System.ArgumentNullException(nameof(imageUri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoRequestVariant2" /> class.
        /// </summary>
        public ImageToVideoRequestVariant2()
        {
        }
    }
}