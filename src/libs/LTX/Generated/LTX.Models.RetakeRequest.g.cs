
#nullable enable

namespace LTX
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetakeRequest
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LTX.JsonConverters.RetakeRequestModeJsonConverter))]
        public global::LTX.RetakeRequestMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetakeRequest" /> class.
        /// </summary>
        /// <param name="videoUri"></param>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetakeRequest(
            string videoUri,
            string prompt,
            global::LTX.LtxModel model,
            float startTime,
            float endTime,
            global::LTX.RetakeRequestMode? mode)
        {
            this.VideoUri = videoUri ?? throw new global::System.ArgumentNullException(nameof(videoUri));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetakeRequest" /> class.
        /// </summary>
        public RetakeRequest()
        {
        }
    }
}