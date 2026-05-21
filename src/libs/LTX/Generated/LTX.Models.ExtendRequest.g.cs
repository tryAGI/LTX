
#nullable enable

namespace LTX
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtendRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LTX.JsonConverters.LtxModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LTX.LtxModel Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LTX.JsonConverters.ExtendRequestDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LTX.ExtendRequestDirection Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public int? Fps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendRequest" /> class.
        /// </summary>
        /// <param name="videoUri"></param>
        /// <param name="model"></param>
        /// <param name="duration"></param>
        /// <param name="direction"></param>
        /// <param name="prompt"></param>
        /// <param name="resolution"></param>
        /// <param name="fps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtendRequest(
            string videoUri,
            global::LTX.LtxModel model,
            int duration,
            global::LTX.ExtendRequestDirection direction,
            string? prompt,
            string? resolution,
            int? fps)
        {
            this.VideoUri = videoUri ?? throw new global::System.ArgumentNullException(nameof(videoUri));
            this.Prompt = prompt;
            this.Model = model;
            this.Duration = duration;
            this.Direction = direction;
            this.Resolution = resolution;
            this.Fps = fps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendRequest" /> class.
        /// </summary>
        public ExtendRequest()
        {
        }

    }
}