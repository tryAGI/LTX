#nullable enable

namespace LTX.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExtendRequestDirectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LTX.ExtendRequestDirection?>
    {
        /// <inheritdoc />
        public override global::LTX.ExtendRequestDirection? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::LTX.ExtendRequestDirectionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LTX.ExtendRequestDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LTX.ExtendRequestDirection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LTX.ExtendRequestDirection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LTX.ExtendRequestDirectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
