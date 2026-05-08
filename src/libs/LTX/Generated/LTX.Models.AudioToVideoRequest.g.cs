#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LTX
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AudioToVideoRequest : global::System.IEquatable<AudioToVideoRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LTX.TextToVideoRequest? Text { get; init; }
#else
        public global::LTX.TextToVideoRequest? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LTX.TextToVideoRequest? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LTX.AudioToVideoRequestVariant2? AudioToVideoRequestVariant2 { get; init; }
#else
        public global::LTX.AudioToVideoRequestVariant2? AudioToVideoRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioToVideoRequestVariant2))]
#endif
        public bool IsAudioToVideoRequestVariant2 => AudioToVideoRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAudioToVideoRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LTX.AudioToVideoRequestVariant2? value)
        {
            value = AudioToVideoRequestVariant2;
            return IsAudioToVideoRequestVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AudioToVideoRequest(global::LTX.TextToVideoRequest value) => new AudioToVideoRequest((global::LTX.TextToVideoRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LTX.TextToVideoRequest?(AudioToVideoRequest @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public AudioToVideoRequest(global::LTX.TextToVideoRequest? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AudioToVideoRequest(global::LTX.AudioToVideoRequestVariant2 value) => new AudioToVideoRequest((global::LTX.AudioToVideoRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LTX.AudioToVideoRequestVariant2?(AudioToVideoRequest @this) => @this.AudioToVideoRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AudioToVideoRequest(global::LTX.AudioToVideoRequestVariant2? value)
        {
            AudioToVideoRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AudioToVideoRequest(
            global::LTX.TextToVideoRequest? text,
            global::LTX.AudioToVideoRequestVariant2? audioToVideoRequestVariant2
            )
        {
            Text = text;
            AudioToVideoRequestVariant2 = audioToVideoRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AudioToVideoRequestVariant2 as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            AudioToVideoRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && IsAudioToVideoRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LTX.TextToVideoRequest, TResult>? text = null,
            global::System.Func<global::LTX.AudioToVideoRequestVariant2, TResult>? audioToVideoRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsAudioToVideoRequestVariant2 && audioToVideoRequestVariant2 != null)
            {
                return audioToVideoRequestVariant2(AudioToVideoRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LTX.TextToVideoRequest>? text = null,

            global::System.Action<global::LTX.AudioToVideoRequestVariant2>? audioToVideoRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsAudioToVideoRequestVariant2)
            {
                audioToVideoRequestVariant2?.Invoke(AudioToVideoRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::LTX.TextToVideoRequest>? text = null,
            global::System.Action<global::LTX.AudioToVideoRequestVariant2>? audioToVideoRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsAudioToVideoRequestVariant2)
            {
                audioToVideoRequestVariant2?.Invoke(AudioToVideoRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::LTX.TextToVideoRequest),
                AudioToVideoRequestVariant2,
                typeof(global::LTX.AudioToVideoRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AudioToVideoRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LTX.TextToVideoRequest?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::LTX.AudioToVideoRequestVariant2?>.Default.Equals(AudioToVideoRequestVariant2, other.AudioToVideoRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AudioToVideoRequest obj1, AudioToVideoRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AudioToVideoRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AudioToVideoRequest obj1, AudioToVideoRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AudioToVideoRequest o && Equals(o);
        }
    }
}
