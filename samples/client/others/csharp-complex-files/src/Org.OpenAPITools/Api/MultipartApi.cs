/*
 * MultipartFile test
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMultipartApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// MultipartFile array test
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="files">Many files (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void MultipartArray(List<System.IO.Stream> files = default(List<System.IO.Stream>), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// MultipartFile array test
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="files">Many files (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> MultipartArrayWithHttpInfo(List<System.IO.Stream> files = default(List<System.IO.Stream>), int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Mixed MultipartFile test
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status"></param>
        /// <param name="file">a file</param>
        /// <param name="marker"> (optional)</param>
        /// <param name="statusArray"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void MultipartMixed(MultipartMixedStatus status, System.IO.Stream file, MultipartMixedRequestMarker marker = default(MultipartMixedRequestMarker), List<MultipartMixedStatus> statusArray = default(List<MultipartMixedStatus>), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Mixed MultipartFile test
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status"></param>
        /// <param name="file">a file</param>
        /// <param name="marker"> (optional)</param>
        /// <param name="statusArray"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> MultipartMixedWithHttpInfo(MultipartMixedStatus status, System.IO.Stream file, MultipartMixedRequestMarker marker = default(MultipartMixedRequestMarker), List<MultipartMixedStatus> statusArray = default(List<MultipartMixedStatus>), int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Single MultipartFile test
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">One file (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void MultipartSingle(System.IO.Stream file = default(System.IO.Stream), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Single MultipartFile test
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">One file (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> MultipartSingleWithHttpInfo(System.IO.Stream file = default(System.IO.Stream), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMultipartApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// MultipartFile array test
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="files">Many files (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task MultipartArrayAsync(List<System.IO.Stream> files = default(List<System.IO.Stream>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// MultipartFile array test
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="files">Many files (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> MultipartArrayWithHttpInfoAsync(List<System.IO.Stream> files = default(List<System.IO.Stream>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Mixed MultipartFile test
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status"></param>
        /// <param name="file">a file</param>
        /// <param name="marker"> (optional)</param>
        /// <param name="statusArray"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task MultipartMixedAsync(MultipartMixedStatus status, System.IO.Stream file, MultipartMixedRequestMarker marker = default(MultipartMixedRequestMarker), List<MultipartMixedStatus> statusArray = default(List<MultipartMixedStatus>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Mixed MultipartFile test
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status"></param>
        /// <param name="file">a file</param>
        /// <param name="marker"> (optional)</param>
        /// <param name="statusArray"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> MultipartMixedWithHttpInfoAsync(MultipartMixedStatus status, System.IO.Stream file, MultipartMixedRequestMarker marker = default(MultipartMixedRequestMarker), List<MultipartMixedStatus> statusArray = default(List<MultipartMixedStatus>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Single MultipartFile test
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">One file (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task MultipartSingleAsync(System.IO.Stream file = default(System.IO.Stream), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Single MultipartFile test
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">One file (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> MultipartSingleWithHttpInfoAsync(System.IO.Stream file = default(System.IO.Stream), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMultipartApi : IMultipartApiSync, IMultipartApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MultipartApi : IMultipartApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MultipartApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MultipartApi(string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MultipartApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MultipartApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  MultipartFile array test
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="files">Many files (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void MultipartArray(List<System.IO.Stream> files = default(List<System.IO.Stream>), int operationIndex = 0)
        {
            MultipartArrayWithHttpInfo(files);
        }

        /// <summary>
        ///  MultipartFile array test
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="files">Many files (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Org.OpenAPITools.Client.ApiResponse<Object> MultipartArrayWithHttpInfo(List<System.IO.Stream> files = default(List<System.IO.Stream>), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (files != null)
            {
                foreach (var file in files)
                {
                    localVarRequestOptions.FileParameters.Add("files", file);
                }
            }

            localVarRequestOptions.Operation = "MultipartApi.MultipartArray";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/multipart-array", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("MultipartArray", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  MultipartFile array test
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="files">Many files (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task MultipartArrayAsync(List<System.IO.Stream> files = default(List<System.IO.Stream>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            await MultipartArrayWithHttpInfoAsync(files, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  MultipartFile array test
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="files">Many files (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> MultipartArrayWithHttpInfoAsync(List<System.IO.Stream> files = default(List<System.IO.Stream>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (files != null)
            {
                foreach (var file in files)
                {
                    localVarRequestOptions.FileParameters.Add("files", file);
                }
            }

            localVarRequestOptions.Operation = "MultipartApi.MultipartArray";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/multipart-array", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("MultipartArray", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Mixed MultipartFile test
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status"></param>
        /// <param name="file">a file</param>
        /// <param name="marker"> (optional)</param>
        /// <param name="statusArray"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void MultipartMixed(MultipartMixedStatus status, System.IO.Stream file, MultipartMixedRequestMarker marker = default(MultipartMixedRequestMarker), List<MultipartMixedStatus> statusArray = default(List<MultipartMixedStatus>), int operationIndex = 0)
        {
            MultipartMixedWithHttpInfo(status, file, marker, statusArray);
        }

        /// <summary>
        ///  Mixed MultipartFile test
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status"></param>
        /// <param name="file">a file</param>
        /// <param name="marker"> (optional)</param>
        /// <param name="statusArray"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Org.OpenAPITools.Client.ApiResponse<Object> MultipartMixedWithHttpInfo(MultipartMixedStatus status, System.IO.Stream file, MultipartMixedRequestMarker marker = default(MultipartMixedRequestMarker), List<MultipartMixedStatus> statusArray = default(List<MultipartMixedStatus>), int operationIndex = 0)
        {
            // verify the required parameter 'file' is set
            if (file == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'file' when calling MultipartApi->MultipartMixed");
            }

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.FormParameters.Add("status", Org.OpenAPITools.Client.ClientUtils.ParameterToString(status)); // form parameter
            if (marker != null)
            {
                localVarRequestOptions.FormParameters.Add("marker", localVarMultipartFormData ? Org.OpenAPITools.Client.ClientUtils.ParameterToString(marker) : Org.OpenAPITools.Client.ClientUtils.Serialize(marker)); // form parameter
            }
            localVarRequestOptions.FileParameters.Add("file", file);
            if (statusArray != null)
            {
                localVarRequestOptions.FormParameters.Add("statusArray", localVarMultipartFormData ? Org.OpenAPITools.Client.ClientUtils.ParameterToString(statusArray) : Org.OpenAPITools.Client.ClientUtils.Serialize(statusArray)); // form parameter
            }

            localVarRequestOptions.Operation = "MultipartApi.MultipartMixed";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/multipart-mixed", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("MultipartMixed", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Mixed MultipartFile test
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status"></param>
        /// <param name="file">a file</param>
        /// <param name="marker"> (optional)</param>
        /// <param name="statusArray"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task MultipartMixedAsync(MultipartMixedStatus status, System.IO.Stream file, MultipartMixedRequestMarker marker = default(MultipartMixedRequestMarker), List<MultipartMixedStatus> statusArray = default(List<MultipartMixedStatus>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            await MultipartMixedWithHttpInfoAsync(status, file, marker, statusArray, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  Mixed MultipartFile test
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status"></param>
        /// <param name="file">a file</param>
        /// <param name="marker"> (optional)</param>
        /// <param name="statusArray"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> MultipartMixedWithHttpInfoAsync(MultipartMixedStatus status, System.IO.Stream file, MultipartMixedRequestMarker marker = default(MultipartMixedRequestMarker), List<MultipartMixedStatus> statusArray = default(List<MultipartMixedStatus>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'file' is set
            if (file == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'file' when calling MultipartApi->MultipartMixed");
            }


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.FormParameters.Add("status", Org.OpenAPITools.Client.ClientUtils.ParameterToString(status)); // form parameter
            if (marker != null)
            {
                localVarRequestOptions.FormParameters.Add("marker", Org.OpenAPITools.Client.ClientUtils.Serialize(marker)); // form parameter
            }
            localVarRequestOptions.FileParameters.Add("file", file);
            if (statusArray != null)
            {
                localVarRequestOptions.FormParameters.Add("statusArray", Org.OpenAPITools.Client.ClientUtils.Serialize(statusArray)); // form parameter
            }

            localVarRequestOptions.Operation = "MultipartApi.MultipartMixed";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/multipart-mixed", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("MultipartMixed", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Single MultipartFile test
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">One file (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void MultipartSingle(System.IO.Stream file = default(System.IO.Stream), int operationIndex = 0)
        {
            MultipartSingleWithHttpInfo(file);
        }

        /// <summary>
        ///  Single MultipartFile test
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">One file (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Org.OpenAPITools.Client.ApiResponse<Object> MultipartSingleWithHttpInfo(System.IO.Stream file = default(System.IO.Stream), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("file", file);
            }

            localVarRequestOptions.Operation = "MultipartApi.MultipartSingle";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/multipart-single", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("MultipartSingle", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Single MultipartFile test
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">One file (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task MultipartSingleAsync(System.IO.Stream file = default(System.IO.Stream), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            await MultipartSingleWithHttpInfoAsync(file, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  Single MultipartFile test
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">One file (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> MultipartSingleWithHttpInfoAsync(System.IO.Stream file = default(System.IO.Stream), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("file", file);
            }

            localVarRequestOptions.Operation = "MultipartApi.MultipartSingle";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/multipart-single", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("MultipartSingle", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
