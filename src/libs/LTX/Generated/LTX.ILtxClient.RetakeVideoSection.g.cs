#nullable enable

namespace LTX
{
    public partial interface ILtxClient
    {
        /// <summary>
        /// Regenerate a selected section of an existing video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LTX.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> RetakeVideoSectionAsync(

            global::LTX.RetakeRequest request,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate a selected section of an existing video.
        /// </summary>
        /// <param name="videoUri"></param>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="mode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> RetakeVideoSectionAsync(
            string videoUri,
            string prompt,
            global::LTX.LtxModel model,
            float startTime,
            float endTime,
            global::LTX.RetakeRequestMode? mode = default,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}