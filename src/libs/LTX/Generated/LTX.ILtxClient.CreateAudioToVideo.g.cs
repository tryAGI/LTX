#nullable enable

namespace LTX
{
    public partial interface ILtxClient
    {
        /// <summary>
        /// Generate a video synchronized to an audio track.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LTX.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateAudioToVideoAsync(

            global::LTX.AudioToVideoRequest request,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video synchronized to an audio track.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LTX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateAudioToVideoAsStreamAsync(

            global::LTX.AudioToVideoRequest request,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video synchronized to an audio track.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LTX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LTX.AutoSDKHttpResponse<byte[]>> CreateAudioToVideoAsResponseAsync(

            global::LTX.AudioToVideoRequest request,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a video synchronized to an audio track.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateAudioToVideoAsync(
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}