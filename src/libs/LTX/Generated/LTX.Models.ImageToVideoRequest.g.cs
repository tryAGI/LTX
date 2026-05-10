#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LTX
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ImageToVideoRequest : global::System.IEquatable<ImageToVideoRequest>
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
        public global::LTX.TextToVideoRequest PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LTX.ImageToVideoRequestVariant2? ImageToVideoRequestVariant2 { get; init; }
#else
        public global::LTX.ImageToVideoRequestVariant2? ImageToVideoRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageToVideoRequestVariant2))]
#endif
        public bool IsImageToVideoRequestVariant2 => ImageToVideoRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageToVideoRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LTX.ImageToVideoRequestVariant2? value)
        {
            value = ImageToVideoRequestVariant2;
            return IsImageToVideoRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LTX.ImageToVideoRequestVariant2 PickImageToVideoRequestVariant2() => IsImageToVideoRequestVariant2
            ? ImageToVideoRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageToVideoRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageToVideoRequest(global::LTX.TextToVideoRequest value) => new ImageToVideoRequest((global::LTX.TextToVideoRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LTX.TextToVideoRequest?(ImageToVideoRequest @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ImageToVideoRequest(global::LTX.TextToVideoRequest? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageToVideoRequest FromText(global::LTX.TextToVideoRequest? value) => new ImageToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageToVideoRequest(global::LTX.ImageToVideoRequestVariant2 value) => new ImageToVideoRequest((global::LTX.ImageToVideoRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LTX.ImageToVideoRequestVariant2?(ImageToVideoRequest @this) => @this.ImageToVideoRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ImageToVideoRequest(global::LTX.ImageToVideoRequestVariant2? value)
        {
            ImageToVideoRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageToVideoRequest FromImageToVideoRequestVariant2(global::LTX.ImageToVideoRequestVariant2? value) => new ImageToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public ImageToVideoRequest(
            global::LTX.TextToVideoRequest? text,
            global::LTX.ImageToVideoRequestVariant2? imageToVideoRequestVariant2
            )
        {
            Text = text;
            ImageToVideoRequestVariant2 = imageToVideoRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageToVideoRequestVariant2 as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageToVideoRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && IsImageToVideoRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LTX.TextToVideoRequest, TResult>? text = null,
            global::System.Func<global::LTX.ImageToVideoRequestVariant2, TResult>? imageToVideoRequestVariant2 = null,
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
            else if (IsImageToVideoRequestVariant2 && imageToVideoRequestVariant2 != null)
            {
                return imageToVideoRequestVariant2(ImageToVideoRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LTX.TextToVideoRequest>? text = null,

            global::System.Action<global::LTX.ImageToVideoRequestVariant2>? imageToVideoRequestVariant2 = null,
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
            else if (IsImageToVideoRequestVariant2)
            {
                imageToVideoRequestVariant2?.Invoke(ImageToVideoRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::LTX.TextToVideoRequest>? text = null,
            global::System.Action<global::LTX.ImageToVideoRequestVariant2>? imageToVideoRequestVariant2 = null,
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
            else if (IsImageToVideoRequestVariant2)
            {
                imageToVideoRequestVariant2?.Invoke(ImageToVideoRequestVariant2!);
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
                ImageToVideoRequestVariant2,
                typeof(global::LTX.ImageToVideoRequestVariant2),
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
        public bool Equals(ImageToVideoRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LTX.TextToVideoRequest?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::LTX.ImageToVideoRequestVariant2?>.Default.Equals(ImageToVideoRequestVariant2, other.ImageToVideoRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageToVideoRequest obj1, ImageToVideoRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageToVideoRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageToVideoRequest obj1, ImageToVideoRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageToVideoRequest o && Equals(o);
        }
    }
}
