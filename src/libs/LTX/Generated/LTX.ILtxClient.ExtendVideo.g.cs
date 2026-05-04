#nullable enable

namespace LTX
{
    public partial interface ILtxClient
    {
        /// <summary>
        /// Extend an existing video from the beginning or end.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LTX.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ExtendVideoAsync(

            global::LTX.ExtendRequest request,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extend an existing video from the beginning or end.
        /// </summary>
        /// <param name="videoUri"></param>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
        /// <param name="duration"></param>
        /// <param name="direction"></param>
        /// <param name="resolution"></param>
        /// <param name="fps"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ExtendVideoAsync(
            string videoUri,
            global::LTX.LtxModel model,
            int duration,
            global::LTX.ExtendRequestDirection direction,
            string? prompt = default,
            string? resolution = default,
            int? fps = default,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}