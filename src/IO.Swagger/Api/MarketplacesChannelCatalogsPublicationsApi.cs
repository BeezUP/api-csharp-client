/* 
 * Public - Security
 *
 * This API will allow you to create your account and to get your tokens. \\ If you lost your password, you have an operation to get it back. 
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
    public interface IMarketplacesChannelCatalogsPublicationsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Fetch the publication history for an account, sorted by descending start date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketplaceTechnicalCode">Marketplace Technical Code to query (required)</param>
        /// <param name="accountId">Account Id to query (required)</param>
        /// <param name="channelCatalogId">Channel Catalog Id by which to filter (optional) (optional)</param>
        /// <param name="count">Amount of entries to fetch (optional, default set to 10) (optional, default to 10)</param>
        /// <param name="publicationTypes">Publication types by which to filter (optional) (optional)</param>
        /// <returns>AccountPublications</returns>
        AccountPublications GetPublications (string marketplaceTechnicalCode, int? accountId, string channelCatalogId = null, int? count = null, List<string> publicationTypes = null);

        /// <summary>
        /// Fetch the publication history for an account, sorted by descending start date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketplaceTechnicalCode">Marketplace Technical Code to query (required)</param>
        /// <param name="accountId">Account Id to query (required)</param>
        /// <param name="channelCatalogId">Channel Catalog Id by which to filter (optional) (optional)</param>
        /// <param name="count">Amount of entries to fetch (optional, default set to 10) (optional, default to 10)</param>
        /// <param name="publicationTypes">Publication types by which to filter (optional) (optional)</param>
        /// <returns>ApiResponse of AccountPublications</returns>
        ApiResponse<AccountPublications> GetPublicationsWithHttpInfo (string marketplaceTechnicalCode, int? accountId, string channelCatalogId = null, int? count = null, List<string> publicationTypes = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Fetch the publication history for an account, sorted by descending start date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketplaceTechnicalCode">Marketplace Technical Code to query (required)</param>
        /// <param name="accountId">Account Id to query (required)</param>
        /// <param name="channelCatalogId">Channel Catalog Id by which to filter (optional) (optional)</param>
        /// <param name="count">Amount of entries to fetch (optional, default set to 10) (optional, default to 10)</param>
        /// <param name="publicationTypes">Publication types by which to filter (optional) (optional)</param>
        /// <returns>Task of AccountPublications</returns>
        System.Threading.Tasks.Task<AccountPublications> GetPublicationsAsync (string marketplaceTechnicalCode, int? accountId, string channelCatalogId = null, int? count = null, List<string> publicationTypes = null);

        /// <summary>
        /// Fetch the publication history for an account, sorted by descending start date
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketplaceTechnicalCode">Marketplace Technical Code to query (required)</param>
        /// <param name="accountId">Account Id to query (required)</param>
        /// <param name="channelCatalogId">Channel Catalog Id by which to filter (optional) (optional)</param>
        /// <param name="count">Amount of entries to fetch (optional, default set to 10) (optional, default to 10)</param>
        /// <param name="publicationTypes">Publication types by which to filter (optional) (optional)</param>
        /// <returns>Task of ApiResponse (AccountPublications)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountPublications>> GetPublicationsAsyncWithHttpInfo (string marketplaceTechnicalCode, int? accountId, string channelCatalogId = null, int? count = null, List<string> publicationTypes = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MarketplacesChannelCatalogsPublicationsApi : IMarketplacesChannelCatalogsPublicationsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacesChannelCatalogsPublicationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MarketplacesChannelCatalogsPublicationsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="MarketplacesChannelCatalogsPublicationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MarketplacesChannelCatalogsPublicationsApi(Configuration configuration = null)
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
        /// Fetch the publication history for an account, sorted by descending start date 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketplaceTechnicalCode">Marketplace Technical Code to query (required)</param>
        /// <param name="accountId">Account Id to query (required)</param>
        /// <param name="channelCatalogId">Channel Catalog Id by which to filter (optional) (optional)</param>
        /// <param name="count">Amount of entries to fetch (optional, default set to 10) (optional, default to 10)</param>
        /// <param name="publicationTypes">Publication types by which to filter (optional) (optional)</param>
        /// <returns>AccountPublications</returns>
        public AccountPublications GetPublications (string marketplaceTechnicalCode, int? accountId, string channelCatalogId = null, int? count = null, List<string> publicationTypes = null)
        {
             ApiResponse<AccountPublications> localVarResponse = GetPublicationsWithHttpInfo(marketplaceTechnicalCode, accountId, channelCatalogId, count, publicationTypes);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch the publication history for an account, sorted by descending start date 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketplaceTechnicalCode">Marketplace Technical Code to query (required)</param>
        /// <param name="accountId">Account Id to query (required)</param>
        /// <param name="channelCatalogId">Channel Catalog Id by which to filter (optional) (optional)</param>
        /// <param name="count">Amount of entries to fetch (optional, default set to 10) (optional, default to 10)</param>
        /// <param name="publicationTypes">Publication types by which to filter (optional) (optional)</param>
        /// <returns>ApiResponse of AccountPublications</returns>
        public ApiResponse< AccountPublications > GetPublicationsWithHttpInfo (string marketplaceTechnicalCode, int? accountId, string channelCatalogId = null, int? count = null, List<string> publicationTypes = null)
        {
            // verify the required parameter 'marketplaceTechnicalCode' is set
            if (marketplaceTechnicalCode == null)
                throw new ApiException(400, "Missing required parameter 'marketplaceTechnicalCode' when calling MarketplacesChannelCatalogsPublicationsApi->GetPublications");
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling MarketplacesChannelCatalogsPublicationsApi->GetPublications");

            var localVarPath = "/user/marketplaces/channelcatalogs/publications/{marketplaceTechnicalCode}/{accountId}/history";
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
            if (marketplaceTechnicalCode != null) localVarPathParams.Add("marketplaceTechnicalCode", Configuration.ApiClient.ParameterToString(marketplaceTechnicalCode)); // path parameter
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (channelCatalogId != null) localVarQueryParams.Add("channelCatalogId", Configuration.ApiClient.ParameterToString(channelCatalogId)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (publicationTypes != null) localVarQueryParams.Add("publicationTypes", Configuration.ApiClient.ParameterToString(publicationTypes)); // query parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key")))
            {
                localVarHeaderParams["Ocp-Apim-Subscription-Key"] = Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPublications", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountPublications>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountPublications) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountPublications)));
            
        }

        /// <summary>
        /// Fetch the publication history for an account, sorted by descending start date 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketplaceTechnicalCode">Marketplace Technical Code to query (required)</param>
        /// <param name="accountId">Account Id to query (required)</param>
        /// <param name="channelCatalogId">Channel Catalog Id by which to filter (optional) (optional)</param>
        /// <param name="count">Amount of entries to fetch (optional, default set to 10) (optional, default to 10)</param>
        /// <param name="publicationTypes">Publication types by which to filter (optional) (optional)</param>
        /// <returns>Task of AccountPublications</returns>
        public async System.Threading.Tasks.Task<AccountPublications> GetPublicationsAsync (string marketplaceTechnicalCode, int? accountId, string channelCatalogId = null, int? count = null, List<string> publicationTypes = null)
        {
             ApiResponse<AccountPublications> localVarResponse = await GetPublicationsAsyncWithHttpInfo(marketplaceTechnicalCode, accountId, channelCatalogId, count, publicationTypes);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch the publication history for an account, sorted by descending start date 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="marketplaceTechnicalCode">Marketplace Technical Code to query (required)</param>
        /// <param name="accountId">Account Id to query (required)</param>
        /// <param name="channelCatalogId">Channel Catalog Id by which to filter (optional) (optional)</param>
        /// <param name="count">Amount of entries to fetch (optional, default set to 10) (optional, default to 10)</param>
        /// <param name="publicationTypes">Publication types by which to filter (optional) (optional)</param>
        /// <returns>Task of ApiResponse (AccountPublications)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountPublications>> GetPublicationsAsyncWithHttpInfo (string marketplaceTechnicalCode, int? accountId, string channelCatalogId = null, int? count = null, List<string> publicationTypes = null)
        {
            // verify the required parameter 'marketplaceTechnicalCode' is set
            if (marketplaceTechnicalCode == null)
                throw new ApiException(400, "Missing required parameter 'marketplaceTechnicalCode' when calling MarketplacesChannelCatalogsPublicationsApi->GetPublications");
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling MarketplacesChannelCatalogsPublicationsApi->GetPublications");

            var localVarPath = "/user/marketplaces/channelcatalogs/publications/{marketplaceTechnicalCode}/{accountId}/history";
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
            if (marketplaceTechnicalCode != null) localVarPathParams.Add("marketplaceTechnicalCode", Configuration.ApiClient.ParameterToString(marketplaceTechnicalCode)); // path parameter
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (channelCatalogId != null) localVarQueryParams.Add("channelCatalogId", Configuration.ApiClient.ParameterToString(channelCatalogId)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (publicationTypes != null) localVarQueryParams.Add("publicationTypes", Configuration.ApiClient.ParameterToString(publicationTypes)); // query parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key")))
            {
                localVarHeaderParams["Ocp-Apim-Subscription-Key"] = Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPublications", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountPublications>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountPublications) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountPublications)));
            
        }

    }
}
