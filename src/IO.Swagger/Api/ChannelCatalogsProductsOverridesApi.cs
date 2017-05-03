/* 
 * BeezUP API
 *
 * This is the RESTful API of BeezUP which allows you to manage everything related to BeezUP
 *
 * OpenAPI spec version: 2.0
 * Contact: support@beezup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IChannelCatalogsProductsOverridesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a specific channel catalog product value override
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="channelColumnId">The channel column identifier</param>
        /// <returns></returns>
        void DeleteChannelCatalogProductValueOverride (string channelCatalogId, string productId, string channelColumnId);

        /// <summary>
        /// Delete a specific channel catalog product value override
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="channelColumnId">The channel column identifier</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteChannelCatalogProductValueOverrideWithHttpInfo (string channelCatalogId, string productId, string channelColumnId);
        /// <summary>
        /// Override channel catalog product values
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="request"></param>
        /// <returns></returns>
        void OverrideChannelCatalogProductOverrides (string channelCatalogId, string productId, ProductOverrides request);

        /// <summary>
        /// Override channel catalog product values
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="request"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> OverrideChannelCatalogProductOverridesWithHttpInfo (string channelCatalogId, string productId, ProductOverrides request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete a specific channel catalog product value override
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="channelColumnId">The channel column identifier</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteChannelCatalogProductValueOverrideAsync (string channelCatalogId, string productId, string channelColumnId);

        /// <summary>
        /// Delete a specific channel catalog product value override
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="channelColumnId">The channel column identifier</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteChannelCatalogProductValueOverrideAsyncWithHttpInfo (string channelCatalogId, string productId, string channelColumnId);
        /// <summary>
        /// Override channel catalog product values
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="request"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task OverrideChannelCatalogProductOverridesAsync (string channelCatalogId, string productId, ProductOverrides request);

        /// <summary>
        /// Override channel catalog product values
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="request"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> OverrideChannelCatalogProductOverridesAsyncWithHttpInfo (string channelCatalogId, string productId, ProductOverrides request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ChannelCatalogsProductsOverridesApi : IChannelCatalogsProductsOverridesApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogsProductsOverridesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChannelCatalogsProductsOverridesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogsProductsOverridesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ChannelCatalogsProductsOverridesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Delete a specific channel catalog product value override 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="channelColumnId">The channel column identifier</param>
        /// <returns></returns>
        public void DeleteChannelCatalogProductValueOverride (string channelCatalogId, string productId, string channelColumnId)
        {
             DeleteChannelCatalogProductValueOverrideWithHttpInfo(channelCatalogId, productId, channelColumnId);
        }

        /// <summary>
        /// Delete a specific channel catalog product value override 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="channelColumnId">The channel column identifier</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteChannelCatalogProductValueOverrideWithHttpInfo (string channelCatalogId, string productId, string channelColumnId)
        {
            // verify the required parameter 'channelCatalogId' is set
            if (channelCatalogId == null)
                throw new ApiException(400, "Missing required parameter 'channelCatalogId' when calling ChannelCatalogsProductsOverridesApi->DeleteChannelCatalogProductValueOverride");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ChannelCatalogsProductsOverridesApi->DeleteChannelCatalogProductValueOverride");
            // verify the required parameter 'channelColumnId' is set
            if (channelColumnId == null)
                throw new ApiException(400, "Missing required parameter 'channelColumnId' when calling ChannelCatalogsProductsOverridesApi->DeleteChannelCatalogProductValueOverride");

            var localVarPath = "/v2/user/channelCatalogs/{channelCatalogId}/products/{productId}/overrides/{channelColumnId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (channelCatalogId != null) localVarPathParams.Add("channelCatalogId", Configuration.ApiClient.ParameterToString(channelCatalogId)); // path parameter
            if (productId != null) localVarPathParams.Add("productId", Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (channelColumnId != null) localVarPathParams.Add("channelColumnId", Configuration.ApiClient.ParameterToString(channelColumnId)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key")))
            {
                localVarHeaderParams["Ocp-Apim-Subscription-Key"] = Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteChannelCatalogProductValueOverride", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete a specific channel catalog product value override 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="channelColumnId">The channel column identifier</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteChannelCatalogProductValueOverrideAsync (string channelCatalogId, string productId, string channelColumnId)
        {
             await DeleteChannelCatalogProductValueOverrideAsyncWithHttpInfo(channelCatalogId, productId, channelColumnId);

        }

        /// <summary>
        /// Delete a specific channel catalog product value override 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="channelColumnId">The channel column identifier</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteChannelCatalogProductValueOverrideAsyncWithHttpInfo (string channelCatalogId, string productId, string channelColumnId)
        {
            // verify the required parameter 'channelCatalogId' is set
            if (channelCatalogId == null)
                throw new ApiException(400, "Missing required parameter 'channelCatalogId' when calling ChannelCatalogsProductsOverridesApi->DeleteChannelCatalogProductValueOverride");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ChannelCatalogsProductsOverridesApi->DeleteChannelCatalogProductValueOverride");
            // verify the required parameter 'channelColumnId' is set
            if (channelColumnId == null)
                throw new ApiException(400, "Missing required parameter 'channelColumnId' when calling ChannelCatalogsProductsOverridesApi->DeleteChannelCatalogProductValueOverride");

            var localVarPath = "/v2/user/channelCatalogs/{channelCatalogId}/products/{productId}/overrides/{channelColumnId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (channelCatalogId != null) localVarPathParams.Add("channelCatalogId", Configuration.ApiClient.ParameterToString(channelCatalogId)); // path parameter
            if (productId != null) localVarPathParams.Add("productId", Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (channelColumnId != null) localVarPathParams.Add("channelColumnId", Configuration.ApiClient.ParameterToString(channelColumnId)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key")))
            {
                localVarHeaderParams["Ocp-Apim-Subscription-Key"] = Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteChannelCatalogProductValueOverride", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Override channel catalog product values 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="request"></param>
        /// <returns></returns>
        public void OverrideChannelCatalogProductOverrides (string channelCatalogId, string productId, ProductOverrides request)
        {
             OverrideChannelCatalogProductOverridesWithHttpInfo(channelCatalogId, productId, request);
        }

        /// <summary>
        /// Override channel catalog product values 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="request"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> OverrideChannelCatalogProductOverridesWithHttpInfo (string channelCatalogId, string productId, ProductOverrides request)
        {
            // verify the required parameter 'channelCatalogId' is set
            if (channelCatalogId == null)
                throw new ApiException(400, "Missing required parameter 'channelCatalogId' when calling ChannelCatalogsProductsOverridesApi->OverrideChannelCatalogProductOverrides");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ChannelCatalogsProductsOverridesApi->OverrideChannelCatalogProductOverrides");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling ChannelCatalogsProductsOverridesApi->OverrideChannelCatalogProductOverrides");

            var localVarPath = "/v2/user/channelCatalogs/{channelCatalogId}/products/{productId}/overrides";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (channelCatalogId != null) localVarPathParams.Add("channelCatalogId", Configuration.ApiClient.ParameterToString(channelCatalogId)); // path parameter
            if (productId != null) localVarPathParams.Add("productId", Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key")))
            {
                localVarHeaderParams["Ocp-Apim-Subscription-Key"] = Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OverrideChannelCatalogProductOverrides", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Override channel catalog product values 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="request"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task OverrideChannelCatalogProductOverridesAsync (string channelCatalogId, string productId, ProductOverrides request)
        {
             await OverrideChannelCatalogProductOverridesAsyncWithHttpInfo(channelCatalogId, productId, request);

        }

        /// <summary>
        /// Override channel catalog product values 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelCatalogId">The channel catalog identifier</param>
        /// <param name="productId">The product identifier</param>
        /// <param name="request"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> OverrideChannelCatalogProductOverridesAsyncWithHttpInfo (string channelCatalogId, string productId, ProductOverrides request)
        {
            // verify the required parameter 'channelCatalogId' is set
            if (channelCatalogId == null)
                throw new ApiException(400, "Missing required parameter 'channelCatalogId' when calling ChannelCatalogsProductsOverridesApi->OverrideChannelCatalogProductOverrides");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ChannelCatalogsProductsOverridesApi->OverrideChannelCatalogProductOverrides");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling ChannelCatalogsProductsOverridesApi->OverrideChannelCatalogProductOverrides");

            var localVarPath = "/v2/user/channelCatalogs/{channelCatalogId}/products/{productId}/overrides";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (channelCatalogId != null) localVarPathParams.Add("channelCatalogId", Configuration.ApiClient.ParameterToString(channelCatalogId)); // path parameter
            if (productId != null) localVarPathParams.Add("productId", Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key")))
            {
                localVarHeaderParams["Ocp-Apim-Subscription-Key"] = Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OverrideChannelCatalogProductOverrides", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
