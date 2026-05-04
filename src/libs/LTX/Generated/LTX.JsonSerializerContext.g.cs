
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace LTX
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::LTX.JsonConverters.RetakeRequestModeJsonConverter),

            typeof(global::LTX.JsonConverters.RetakeRequestModeNullableJsonConverter),

            typeof(global::LTX.JsonConverters.ExtendRequestDirectionJsonConverter),

            typeof(global::LTX.JsonConverters.ExtendRequestDirectionNullableJsonConverter),

            typeof(global::LTX.JsonConverters.LtxModelJsonConverter),

            typeof(global::LTX.JsonConverters.LtxModelNullableJsonConverter),

            typeof(global::LTX.JsonConverters.ImageToVideoRequestJsonConverter),

            typeof(global::LTX.JsonConverters.AudioToVideoRequestJsonConverter),

            typeof(global::LTX.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LTX.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LTX.TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LTX.LtxModel), TypeInfoPropertyName = "LtxModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LTX.ImageToVideoRequest), TypeInfoPropertyName = "ImageToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LTX.ImageToVideoRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LTX.AudioToVideoRequest), TypeInfoPropertyName = "AudioToVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LTX.AudioToVideoRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LTX.RetakeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LTX.RetakeRequestMode), TypeInfoPropertyName = "RetakeRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LTX.ExtendRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LTX.ExtendRequestDirection), TypeInfoPropertyName = "ExtendRequestDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LTX.UploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LTX.UploadMediaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}