#nullable enable

namespace LTX
{
    public partial interface ILtxClient
    {
        /// <summary>
        /// Generate a video from a text prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LTX.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateTextToVideoAsync(

            global::LTX.TextToVideoRequest request,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video from a text prompt.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
        /// <param name="duration"></param>
        /// <param name="resolution"></param>
        /// <param name="fps"></param>
        /// <param name="generateAudio">
        /// Default Value: true
        /// </param>
        /// <param name="seed"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateTextToVideoAsync(
            string prompt,
            global::LTX.LtxModel model,
            int duration,
            string resolution,
            int? fps = default,
            bool? generateAudio = default,
            long? seed = default,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}