#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LTX.JsonConverters
{
    /// <inheritdoc />
    public class ImageToVideoRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LTX.ImageToVideoRequest>
    {
        /// <inheritdoc />
        public override global::LTX.ImageToVideoRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("duration")) __score0++;
            if (__jsonProps.Contains("fps")) __score0++;
            if (__jsonProps.Contains("generate_audio")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("prompt")) __score0++;
            if (__jsonProps.Contains("resolution")) __score0++;
            if (__jsonProps.Contains("seed")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("image_uri")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::LTX.TextToVideoRequest? text = default;
            global::LTX.ImageToVideoRequestVariant2? imageToVideoRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LTX.TextToVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LTX.TextToVideoRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LTX.TextToVideoRequest).Name}");
                        text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LTX.ImageToVideoRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LTX.ImageToVideoRequestVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LTX.ImageToVideoRequestVariant2).Name}");
                        imageToVideoRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (text == null && imageToVideoRequestVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LTX.TextToVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LTX.TextToVideoRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LTX.TextToVideoRequest).Name}");
                    text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LTX.ImageToVideoRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LTX.ImageToVideoRequestVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LTX.ImageToVideoRequestVariant2).Name}");
                    imageToVideoRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::LTX.ImageToVideoRequest(
                text,

                imageToVideoRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LTX.ImageToVideoRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LTX.TextToVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LTX.TextToVideoRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LTX.TextToVideoRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsImageToVideoRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LTX.ImageToVideoRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LTX.ImageToVideoRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LTX.ImageToVideoRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageToVideoRequestVariant2!, typeInfo);
            }
        }
    }
}