
#nullable enable

namespace LTX
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioToVideoRequestVariant2
    {
        /// <summary>
        /// HTTPS, data URI, or LTX storage URI for the audio track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUri { get; set; }

        /// <summary>
        /// Optional reference image URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_uri")]
        public string? ImageUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToVideoRequestVariant2" /> class.
        /// </summary>
        /// <param name="audioUri">
        /// HTTPS, data URI, or LTX storage URI for the audio track.
        /// </param>
        /// <param name="imageUri">
        /// Optional reference image URI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioToVideoRequestVariant2(
            string audioUri,
            string? imageUri)
        {
            this.AudioUri = audioUri ?? throw new global::System.ArgumentNullException(nameof(audioUri));
            this.ImageUri = imageUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToVideoRequestVariant2" /> class.
        /// </summary>
        public AudioToVideoRequestVariant2()
        {
        }
    }
}