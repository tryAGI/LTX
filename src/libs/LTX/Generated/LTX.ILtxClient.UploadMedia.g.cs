#nullable enable

namespace LTX
{
    public partial interface ILtxClient
    {
        /// <summary>
        /// Upload media and receive an LTX storage URI for generation requests.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LTX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LTX.UploadResponse> UploadMediaAsync(

            global::LTX.UploadMediaRequest request,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload media and receive an LTX storage URI for generation requests.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LTX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LTX.AutoSDKHttpResponse<global::LTX.UploadResponse>> UploadMediaAsResponseAsync(

            global::LTX.UploadMediaRequest request,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload media and receive an LTX storage URI for generation requests.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LTX.UploadResponse> UploadMediaAsync(
            byte[] file,
            string filename,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload media and receive an LTX storage URI for generation requests.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LTX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LTX.UploadResponse> UploadMediaAsync(
            global::System.IO.Stream file,
            string filename,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload media and receive an LTX storage URI for generation requests.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LTX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LTX.AutoSDKHttpResponse<global::LTX.UploadResponse>> UploadMediaAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::LTX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}