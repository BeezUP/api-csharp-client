/* 
 * BeezUP API
 *
 * # The REST API of BeezUP system ## Overview The REST APIs provide programmatic access to read and write BeezUP data.  Basically, with this API you will be able to do everything like you were with your browser on https://go.beezup.com !  The main features are: - Register and manage your account - Create and manage and share your stores with your friends/co-workers. - Import your product catalog and schedule the auto importation - Search the channels your want to use - Configure your channels for your catalogs to export your product information:     - cost and general settings     - category and columns mappings     - your will be able to create and manage your custom column     - put in place exlusion filters based on simple conditions on your product data     - override product values     - get product vision for a channel catalog scope - Analyze and optimize your performance of your catalogs on all yours channels with different type of reportings by day, channel, category and by product. - Automatize your optimisation by using rules! - And of course... Manage your orders harvested from all your marketplaces:     - Synchronize your orders in an uniformized way     - Get the available actions and update the order status - ...and more!  ## Authentication credentials The public API with the base path **_/v2/public** have been put in place to give you an entry point to our system for the user registration, login and lost password. The public API does not require any credentials. We give you the some public list of values and public channels for our public commercial web site [www.beezup.com](http://www.beezup.com).  The user API with the base path **_/v2/user** requires a token which is available on this page: https://go.beezup.com/Account/MyAccount  ## Things to keep in mind ### API Rate Limits - The BeezUP REST API is limited to 100 calls/minute.  ### Media type The default media type for requests and responses is application/json. Where noted, some operations support other content types. If no additional content type is mentioned for a specific operation, then the media type is application/json.  ### Required content type The required and default encoding for the request and responses is UTF8.  ### Required date time format All our date time are formatted in ISO 8601 format: 2014-06-24T16:25:00Z.  ### Base URL The Base URL of the BeezUP API Order Management REST API conforms to the following template.  https://api.beezup.com  All URLs returned by the BeezUP API are relative to this base URL, and all requests to the REST API must use this base URL template.  You can test our API on https://api-docs.beezup.com/swagger-ui\\ You can contact us on [gitter, #BeezUP/API](https://gitter.im/beezUP/API) 
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

            var localVarPath = "/user/channelCatalogs/{channelCatalogId}/products/{productId}/overrides/{channelColumnId}";
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

            var localVarPath = "/user/channelCatalogs/{channelCatalogId}/products/{productId}/overrides/{channelColumnId}";
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

            var localVarPath = "/user/channelCatalogs/{channelCatalogId}/products/{productId}/overrides";
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

            var localVarPath = "/user/channelCatalogs/{channelCatalogId}/products/{productId}/overrides";
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
