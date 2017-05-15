# IO.Swagger.Api.BeezUPApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateUserAccount**](BeezUPApi.md#activateuseraccount) | **POST** /user/customer/account/activate | Activate the user account
[**AutoConfigureAutoImportInterval**](BeezUPApi.md#autoconfigureautoimportinterval) | **POST** /user/catalogs/{storeId}/autoImport/scheduling/interval | Configure Auto Import Interval
[**AutoDeleteAutoImport**](BeezUPApi.md#autodeleteautoimport) | **DELETE** /user/catalogs/{storeId}/autoImport | Delete Auto Import
[**AutoGetAutoImportConfiguration**](BeezUPApi.md#autogetautoimportconfiguration) | **GET** /user/catalogs/{storeId}/autoImport | Get the auto import configuration
[**AutoPauseAutoImport**](BeezUPApi.md#autopauseautoimport) | **POST** /user/catalogs/{storeId}/autoImport/pause | Pause Auto Import
[**AutoResumeAutoImport**](BeezUPApi.md#autoresumeautoimport) | **POST** /user/catalogs/{storeId}/autoImport/resume | Resume Auto Import
[**AutoScheduleAutoImport**](BeezUPApi.md#autoscheduleautoimport) | **POST** /user/catalogs/{storeId}/autoImport/scheduling/schedules | Configure Auto Import Schedules
[**AutoStartAutoImport**](BeezUPApi.md#autostartautoimport) | **POST** /user/catalogs/{storeId}/autoImport/start | Start Auto Import Manually
[**CatalogChangeCatalogColumnUserName**](BeezUPApi.md#catalogchangecatalogcolumnusername) | **POST** /user/catalogs/{storeId}/catalogColumns/{columnId}/rename | Change Catalog Column User Name
[**CatalogChangeCustomColumnExpression**](BeezUPApi.md#catalogchangecustomcolumnexpression) | **PUT** /user/catalogs/{storeId}/customColumns/{columnId}/expression | Change custom column expression
[**CatalogChangeCustomColumnUserName**](BeezUPApi.md#catalogchangecustomcolumnusername) | **POST** /user/catalogs/{storeId}/customColumns/{columnId}/rename | Change Custom Column User Name
[**CatalogComputeExpression**](BeezUPApi.md#catalogcomputeexpression) | **POST** /user/catalogs/{storeId}/customColumns/computeExpression | Compute the expression for this catalog.
[**CatalogDeleteCustomColumn**](BeezUPApi.md#catalogdeletecustomcolumn) | **DELETE** /user/catalogs/{storeId}/customColumns/{columnId} | Delete custom column
[**CatalogGetBeezUPColumns**](BeezUPApi.md#cataloggetbeezupcolumns) | **GET** /user/catalogs/beezupColumns | Get the BeezUP columns
[**CatalogGetCatalogColumns**](BeezUPApi.md#cataloggetcatalogcolumns) | **GET** /user/catalogs/{storeId}/catalogColumns | Get catalog column list
[**CatalogGetCategories**](BeezUPApi.md#cataloggetcategories) | **GET** /user/catalogs/{storeId}/categories | Get category list
[**CatalogGetCustomColumnExpression**](BeezUPApi.md#cataloggetcustomcolumnexpression) | **GET** /user/catalogs/{storeId}/customColumns/{columnId}/expression | Get the encrypted custom column expression
[**CatalogGetCustomColumns**](BeezUPApi.md#cataloggetcustomcolumns) | **GET** /user/catalogs/{storeId}/customColumns | Get custom column list
[**CatalogGetProduct**](BeezUPApi.md#cataloggetproduct) | **GET** /user/catalogs/{storeId}/products/{productId} | Get product
[**CatalogGetProducts**](BeezUPApi.md#cataloggetproducts) | **POST** /user/catalogs/{storeId}/products | Get product list
[**CatalogGetRandomProducts**](BeezUPApi.md#cataloggetrandomproducts) | **GET** /user/catalogs/{storeId}/products/random | Get random product list
[**CatalogSaveCustomColumn**](BeezUPApi.md#catalogsavecustomcolumn) | **PUT** /user/catalogs/{storeId}/customColumns/{columnId} | Create or replace a custom column
[**ChangeOrder**](BeezUPApi.md#changeorder) | **POST** /user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/{changeOrderType} | Change your marketplace Order Information (accept, ship, etc.)
[**ChangeOrderList**](BeezUPApi.md#changeorderlist) | **POST** /user/marketplaces/orders/batches/changeOrders/{changeOrderType} | Send a batch of operations to change your marketplace Order information (accept, ship, etc.)
[**ChangePassword**](BeezUPApi.md#changepassword) | **POST** /user/customer/account/changePassword | Change user password
[**ClearMerchantOrderInfo**](BeezUPApi.md#clearmerchantorderinfo) | **POST** /user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/clearMerchantOrderInfo | Clear an Order&#39;s merchant information
[**ClearMerchantOrderInfoList**](BeezUPApi.md#clearmerchantorderinfolist) | **POST** /user/marketplaces/orders/batches/clearMerchantOrderInfos | Send a batch of operations to clear an Order&#39;s merchant information
[**ConfigureAutomaticTransitions**](BeezUPApi.md#configureautomatictransitions) | **POST** /user/marketplaces/orders/automaticTransitions | Configure new or existing automatic Order status transition
[**ConfigureChannelCatalogCostSettings**](BeezUPApi.md#configurechannelcatalogcostsettings) | **POST** /user/channelCatalogs/{channelCatalogId}/settings/cost | Disable a channel catalog
[**ConfigureChannelCatalogExclusionFilters**](BeezUPApi.md#configurechannelcatalogexclusionfilters) | **PUT** /user/channelCatalogs/{channelCatalogId}/exclusionFilters | Configure channel catalog exclusion filters
[**ConfigureChannelCatalogGeneralSettings**](BeezUPApi.md#configurechannelcataloggeneralsettings) | **POST** /user/channelCatalogs/{channelCatalogId}/settings/general | Disable a channel catalog
[**CreateChannelCatalog**](BeezUPApi.md#createchannelcatalog) | **POST** /user/channelCatalogs/ | Create a new channel catalog
[**CreateContract**](BeezUPApi.md#createcontract) | **POST** /user/customer/contracts | Create a new contract
[**CreateRule**](BeezUPApi.md#createrule) | **POST** /user/analytics/{storeId}/rules | Rule creation
[**CreateStore**](BeezUPApi.md#createstore) | **POST** /user/customer/stores | Create a new store
[**DeleteChannelCatalog**](BeezUPApi.md#deletechannelcatalog) | **DELETE** /user/channelCatalogs/{channelCatalogId} | Delete the channel catalog
[**DeleteChannelCatalogExportationCache**](BeezUPApi.md#deletechannelcatalogexportationcache) | **DELETE** /user/channelCatalogs/{channelCatalogId}/exportations/cache | Delete the exportation cache
[**DeleteChannelCatalogProductValueOverride**](BeezUPApi.md#deletechannelcatalogproductvalueoverride) | **DELETE** /user/channelCatalogs/{channelCatalogId}/products/{productId}/overrides/{channelColumnId} | Delete a specific channel catalog product value override
[**DeleteNextContract**](BeezUPApi.md#deletenextcontract) | **DELETE** /user/customer/contracts/next | Delete your next contract
[**DeleteReportFilter**](BeezUPApi.md#deletereportfilter) | **DELETE** /user/analytics/{storeId}/reports/filters/{reportFilterId} | Delete the report filter
[**DeleteRule**](BeezUPApi.md#deleterule) | **DELETE** /user/analytics/{storeId}/rules/{ruleId} | Delete Rule
[**DeleteShare**](BeezUPApi.md#deleteshare) | **DELETE** /user/customer/stores/{storeId}/shares/{userId} | Delete a share to another user
[**DeleteStore**](BeezUPApi.md#deletestore) | **DELETE** /user/customer/stores/{storeId} | Delete a store
[**DisableChannelCatalog**](BeezUPApi.md#disablechannelcatalog) | **POST** /user/channelCatalogs/{channelCatalogId}/disable | Disable a channel catalog
[**DisableChannelCatalogProduct**](BeezUPApi.md#disablechannelcatalogproduct) | **POST** /user/channelCatalogs/{channelCatalogId}/products/{productId}/disable | Disable channel catalog product
[**DisableRule**](BeezUPApi.md#disablerule) | **POST** /user/analytics/{storeId}/rules/{ruleId}/disable | Disable rule
[**EnableChannelCatalog**](BeezUPApi.md#enablechannelcatalog) | **POST** /user/channelCatalogs/{channelCatalogId}/enable | Enable a channel catalog
[**EnableRule**](BeezUPApi.md#enablerule) | **POST** /user/analytics/{storeId}/rules/{ruleId}/enable | Enable rule
[**ExportOrders**](BeezUPApi.md#exportorders) | **POST** /user/marketplaces/orders/exportations | Request a new Order report exportation to be generated
[**ExportStoreReportByCategory**](BeezUPApi.md#exportstorereportbycategory) | **POST** /user/analytics/{storeId}/reports/bycategory/export | Export the report by category
[**ExportStoreReportByChannel**](BeezUPApi.md#exportstorereportbychannel) | **POST** /user/analytics/{storeId}/reports/bychannel/export | Export the report by channel
[**ExportStoreReportByProduct**](BeezUPApi.md#exportstorereportbyproduct) | **POST** /user/analytics/{storeId}/reports/byproduct/export | Export the report by product
[**GetAutomaticTransitions**](BeezUPApi.md#getautomatictransitions) | **GET** /user/marketplaces/orders/automaticTransitions | Get list of configured automatic Order status transitions
[**GetAvailableChannels**](BeezUPApi.md#getavailablechannels) | **GET** /user/channels/ | List all available channel for this store
[**GetBillingPeriods**](BeezUPApi.md#getbillingperiods) | **GET** /user/customer/billingPeriods | Get billing periods conditions
[**GetChannelCatalog**](BeezUPApi.md#getchannelcatalog) | **GET** /user/channelCatalogs/{channelCatalogId} | Get the channel catalog information
[**GetChannelCatalogCategories**](BeezUPApi.md#getchannelcatalogcategories) | **GET** /user/channelCatalogs/{channelCatalogId}/categoryMappings | Get channel catalog categories
[**GetChannelCatalogExclusionFilterOperators**](BeezUPApi.md#getchannelcatalogexclusionfilteroperators) | **GET** /user/channelCatalogs/exclusionFilterOperators | Get channel catalog exclusion filter operators
[**GetChannelCatalogExportationCacheInfo**](BeezUPApi.md#getchannelcatalogexportationcacheinfo) | **GET** /user/channelCatalogs/{channelCatalogId}/exportations/cache | Get the exportation cache information
[**GetChannelCatalogExportationHistory**](BeezUPApi.md#getchannelcatalogexportationhistory) | **GET** /user/channelCatalogs/{channelCatalogId}/exportations/history | Get the exportation history
[**GetChannelCatalogMarketplaceProperties**](BeezUPApi.md#getchannelcatalogmarketplaceproperties) | **GET** /user/marketplaces/channelcatalogs/{channelCatalogId}/properties | Get the marketplace properties for a channel catalog
[**GetChannelCatalogMarketplaceSettings**](BeezUPApi.md#getchannelcatalogmarketplacesettings) | **GET** /user/marketplaces/channelcatalogs/{channelCatalogId}/settings | Get the marketplace settings for a channel catalog
[**GetChannelCatalogProductByChannelCatalog**](BeezUPApi.md#getchannelcatalogproductbychannelcatalog) | **POST** /user/channelCatalogs/products/{productId} | Get channel catalog products related to these channel catalogs
[**GetChannelCatalogProductInfo**](BeezUPApi.md#getchannelcatalogproductinfo) | **GET** /user/channelCatalogs/{channelCatalogId}/products/{productId} | Get channel catalog product information
[**GetChannelCatalogProductInfoList**](BeezUPApi.md#getchannelcatalogproductinfolist) | **POST** /user/channelCatalogs/{channelCatalogId}/products | Get channel catalog product information list
[**GetChannelCatalogs**](BeezUPApi.md#getchannelcatalogs) | **GET** /user/channelCatalogs/ | List all your current channel catalogs
[**GetChannelCategories**](BeezUPApi.md#getchannelcategories) | **GET** /user/channels/{channelId}/categories | Get channel categories
[**GetChannelColumns**](BeezUPApi.md#getchannelcolumns) | **POST** /user/channels/{channelId}/columns | Get channel columns
[**GetChannelInfo**](BeezUPApi.md#getchannelinfo) | **GET** /user/channels/{channelId} | Get channel information
[**GetChannels**](BeezUPApi.md#getchannels) | **GET** /public/channels/{countryIsoCode} | The channel list for one country
[**GetChannelsIndex**](BeezUPApi.md#getchannelsindex) | **GET** /public/channels/ | Get public channel index
[**GetContracts**](BeezUPApi.md#getcontracts) | **GET** /user/customer/contracts | Get contract list
[**GetCreditCardInfo**](BeezUPApi.md#getcreditcardinfo) | **GET** /user/customer/account/creditCardInfo | Get credit card information
[**GetFriendInfo**](BeezUPApi.md#getfriendinfo) | **GET** /user/customer/friends/{userId} | Get friend information
[**GetInvoices**](BeezUPApi.md#getinvoices) | **GET** /user/customer/invoices | Get all your invoices
[**GetMarketplaceAccountStores**](BeezUPApi.md#getmarketplaceaccountstores) | **GET** /user/marketplaces/channelcatalogs/ | Get  you marketplace channel catalog list
[**GetMarketplaceAccountsSynchronization**](BeezUPApi.md#getmarketplaceaccountssynchronization) | **GET** /user/marketplaces/orders/status | Get current synchronization status between your marketplaces and BeezUP accounts
[**GetOffer**](BeezUPApi.md#getoffer) | **POST** /user/customer/offers | Get offer pricing
[**GetOrder**](BeezUPApi.md#getorder) | **GET** /user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId} | Get full Order and Order Item(s) properties
[**GetOrderExportations**](BeezUPApi.md#getorderexportations) | **GET** /user/marketplaces/orders/exportations | Get a paginated list of Order report exportations
[**GetOrderHistory**](BeezUPApi.md#getorderhistory) | **GET** /user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/history | Get an Order&#39;s harvest and change history
[**GetOrderIndex**](BeezUPApi.md#getorderindex) | **GET** /user/marketplaces/orders/ | Get all actions you can do on the order API
[**GetOrderListFull**](BeezUPApi.md#getorderlistfull) | **POST** /user/marketplaces/orders/list/full | Get a paginated list of all Orders with all Order and Order Item(s) properties
[**GetOrderListLight**](BeezUPApi.md#getorderlistlight) | **POST** /user/marketplaces/orders/list/light | Get a paginated list of all Orders without details
[**GetProfilePictureInfo**](BeezUPApi.md#getprofilepictureinfo) | **GET** /user/customer/account/profilePictureInfo | Get profile picture information
[**GetPublicListOfValues**](BeezUPApi.md#getpubliclistofvalues) | **GET** /public/lov/{listName} | Get the list of values related to this list name
[**GetPublicLovIndex**](BeezUPApi.md#getpubliclovindex) | **GET** /public/lov/ | Get all list names
[**GetPublications**](BeezUPApi.md#getpublications) | **GET** /user/marketplaces/channelcatalogs/publications/{marketplaceTechnicalCode}/{accountId}/history | Fetch the publication history for an account, sorted by descending start date
[**GetReportFilter**](BeezUPApi.md#getreportfilter) | **GET** /user/analytics/{storeId}/reports/filters/{reportFilterId} | Get the report filter description
[**GetReportFilters**](BeezUPApi.md#getreportfilters) | **GET** /user/analytics/{storeId}/reports/filters | Get report filter list for the given store
[**GetRights**](BeezUPApi.md#getrights) | **POST** /user/customer/stores/{storeId}/rights | Get store&#39;s rights
[**GetRule**](BeezUPApi.md#getrule) | **GET** /user/analytics/{storeId}/rules/{ruleId} | Gets the rule
[**GetRules**](BeezUPApi.md#getrules) | **GET** /user/analytics/{storeId}/rules | Gets the list of rules for a given store
[**GetRulesExecutions**](BeezUPApi.md#getrulesexecutions) | **GET** /user/analytics/{storeId}/rules/executions | Get the rules execution history
[**GetShares**](BeezUPApi.md#getshares) | **GET** /user/customer/stores/{storeId}/shares | Get shares related to this store
[**GetStandardOffers**](BeezUPApi.md#getstandardoffers) | **GET** /user/customer/offers | Get all standard offers
[**GetStore**](BeezUPApi.md#getstore) | **GET** /user/customer/stores/{storeId} | Get store&#39;s information
[**GetStoreAlerts**](BeezUPApi.md#getstorealerts) | **GET** /user/customer/stores/{storeId}/alerts | Get store&#39;s alerts
[**GetStoreReportByCategory**](BeezUPApi.md#getstorereportbycategory) | **POST** /user/analytics/{storeId}/reports/bycategory | Get the report by category
[**GetStoreReportByChannel**](BeezUPApi.md#getstorereportbychannel) | **POST** /user/analytics/{storeId}/reports/bychannel | Get the report by channel
[**GetStoreReportByDay**](BeezUPApi.md#getstorereportbyday) | **POST** /user/analytics/{storeId}/reports/byday | Get the report by day
[**GetStoreReportByDayExport**](BeezUPApi.md#getstorereportbydayexport) | **POST** /user/analytics/{storeId}/reports/byday/export | Get the report by day
[**GetStoreReportByProduct**](BeezUPApi.md#getstorereportbyproduct) | **POST** /user/analytics/{storeId}/reports/byproduct | Get the report by product
[**GetStoreTrackedClicks**](BeezUPApi.md#getstoretrackedclicks) | **GET** /user/analytics/{storeId}/tracking/clicks | Get the latest clicks tracked
[**GetStoreTrackedExternalOrders**](BeezUPApi.md#getstoretrackedexternalorders) | **GET** /user/analytics/{storeId}/tracking/externalorders | Get the latest external orders tracked
[**GetStoreTrackedOrders**](BeezUPApi.md#getstoretrackedorders) | **GET** /user/analytics/{storeId}/tracking/orders | Get the latest orders tracked
[**GetStoreTrackingStatus**](BeezUPApi.md#getstoretrackingstatus) | **GET** /user/analytics/{storeId}/tracking/status | Get store tracking synchronization status
[**GetStores**](BeezUPApi.md#getstores) | **GET** /user/customer/stores | Get store list
[**GetTrackingStatus**](BeezUPApi.md#gettrackingstatus) | **GET** /user/analytics/tracking/status | Display the synchronization status of the clicks and orders
[**GetUserAccountInfo**](BeezUPApi.md#getuseraccountinfo) | **GET** /user/customer/account | Get user account information
[**GetUserListOfValues**](BeezUPApi.md#getuserlistofvalues) | **GET** /user/lov/{listName} | Get the list of values related to this list name
[**GetUserLovIndex**](BeezUPApi.md#getuserlovindex) | **GET** /user/lov/ | Get all list names
[**HarvestAll**](BeezUPApi.md#harvestall) | **POST** /user/marketplaces/orders/harvest | Send harvest request to all your marketplaces
[**HarvestOrder**](BeezUPApi.md#harvestorder) | **POST** /user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/harvest | Send harvest request for a single Order
[**ImportationActivateAutoImport**](BeezUPApi.md#importationactivateautoimport) | **POST** /user/catalogs/{storeId}/autoImport | Activate the auto importation of the last successful manual catalog importation.
[**ImportationCancel**](BeezUPApi.md#importationcancel) | **DELETE** /user/catalogs/{storeId}/importations/{executionId} | Cancel importation
[**ImportationCommit**](BeezUPApi.md#importationcommit) | **POST** /user/catalogs/{storeId}/importations/{executionId}/commit | Commit Importation
[**ImportationCommitColumns**](BeezUPApi.md#importationcommitcolumns) | **POST** /user/catalogs/{storeId}/importations/{executionId}/commitColumns | Commit columns
[**ImportationConfigureCatalogColumn**](BeezUPApi.md#importationconfigurecatalogcolumn) | **POST** /user/catalogs/{storeId}/importations/{executionId}/catalogColumns/{columnId} | Configure catalog column
[**ImportationConfigureRemainingCatalogColumns**](BeezUPApi.md#importationconfigureremainingcatalogcolumns) | **POST** /user/catalogs/{storeId}/importations/{executionId}/configureRemainingCatalogColumns | Configure remaining catalog columns
[**ImportationDeleteCustomColumn**](BeezUPApi.md#importationdeletecustomcolumn) | **DELETE** /user/catalogs/{storeId}/importations/{executionId}/customColumns/{columnId} | Delete Custom Column
[**ImportationGetCustomColumnExpression**](BeezUPApi.md#importationgetcustomcolumnexpression) | **GET** /user/catalogs/{storeId}/importations/{executionId}/customColumns/{columnId}/expression | Get the encrypted custom column expression in this importation
[**ImportationGetCustomColumns**](BeezUPApi.md#importationgetcustomcolumns) | **GET** /user/catalogs/{storeId}/importations/{executionId}/customColumns | Get custom columns currently place in this importation
[**ImportationGetDetectedCatalogColumns**](BeezUPApi.md#importationgetdetectedcatalogcolumns) | **GET** /user/catalogs/{storeId}/importations/{executionId}/catalogColumns | Get detected catalog columns during this importation.
[**ImportationGetImportationMonitoring**](BeezUPApi.md#importationgetimportationmonitoring) | **GET** /user/catalogs/{storeId}/importations/{executionId} | Get the importation status
[**ImportationGetManualUpdateLastInputConfig**](BeezUPApi.md#importationgetmanualupdatelastinputconfig) | **GET** /user/catalogs/{storeId}/inputConfiguration | Get the last input configuration
[**ImportationGetProductSample**](BeezUPApi.md#importationgetproductsample) | **GET** /user/catalogs/{storeId}/importations/{executionId}/productSamples/{productSampleIndex} | Get the product sample related to this importation with all columns (catalog and custom)
[**ImportationGetProductSampleCustomColumnValue**](BeezUPApi.md#importationgetproductsamplecustomcolumnvalue) | **GET** /user/catalogs/{storeId}/importations/{executionId}/productSamples/{productSampleIndex}/customColumns/{columnId} | Get product sample custom column value related to this importation.
[**ImportationGetReportings**](BeezUPApi.md#importationgetreportings) | **GET** /user/catalogs/{storeId}/importations | Get the latest catalog importation reporting
[**ImportationIgnoreColumn**](BeezUPApi.md#importationignorecolumn) | **POST** /user/catalogs/{storeId}/importations/{executionId}/catalogColumns/{columnId}/ignore | Ignore Column
[**ImportationMapCatalogColumn**](BeezUPApi.md#importationmapcatalogcolumn) | **POST** /user/catalogs/{storeId}/importations/{executionId}/catalogColumns/{columnId}/map | Map catalog column to a BeezUP column
[**ImportationMapCustomColumn**](BeezUPApi.md#importationmapcustomcolumn) | **POST** /user/catalogs/{storeId}/importations/{executionId}/customColumns/{columnId}/map | Map custom column to a BeezUP column
[**ImportationReattendColumn**](BeezUPApi.md#importationreattendcolumn) | **POST** /user/catalogs/{storeId}/importations/{executionId}/catalogColumns/{columnId}/reattend | Reattend Column
[**ImportationSaveCustomColumn**](BeezUPApi.md#importationsavecustomcolumn) | **PUT** /user/catalogs/{storeId}/importations/{executionId}/customColumns/{columnId} | Create or replace a custom column
[**ImportationStartManualUpdate**](BeezUPApi.md#importationstartmanualupdate) | **POST** /user/catalogs/{storeId}/importations | Start Manual Import
[**ImportationTechnicalProgression**](BeezUPApi.md#importationtechnicalprogression) | **GET** /user/catalogs/{storeId}/importations/{executionId}/technicalProgression | Get technical progression
[**ImportationUnmapCatalogColumn**](BeezUPApi.md#importationunmapcatalogcolumn) | **POST** /user/catalogs/{storeId}/importations/{executionId}/catalogColumns/{columnId}/unmap | Unmap catalog column
[**ImportationUnmapCustomColumn**](BeezUPApi.md#importationunmapcustomcolumn) | **POST** /user/catalogs/{storeId}/importations/{executionId}/customColumns/{columnId}/unmap | Unmap custom column
[**Login**](BeezUPApi.md#login) | **POST** /public/security/login | Login
[**Logout**](BeezUPApi.md#logout) | **POST** /user/customer/security/logout | Log out the current user from go2
[**LostPassword**](BeezUPApi.md#lostpassword) | **POST** /public/security/lostpassword | Lost password
[**MapChannelCatalogCategory**](BeezUPApi.md#mapchannelcatalogcategory) | **POST** /user/channelCatalogs/{channelCatalogId}/categoryMappings/map | Map channel catalog category
[**MapChannelCatalogColumns**](BeezUPApi.md#mapchannelcatalogcolumns) | **PUT** /user/channelCatalogs/{channelCatalogId}/columnMappings | Configure channel catalog column mappings
[**MoveDownRule**](BeezUPApi.md#movedownrule) | **POST** /user/analytics/{storeId}/rules/{ruleId}/movedown | Move the rule down
[**MoveUpRule**](BeezUPApi.md#moveuprule) | **POST** /user/analytics/{storeId}/rules/{ruleId}/moveup | Move the rule up
[**Optimise**](BeezUPApi.md#optimise) | **POST** /user/analytics/{storeId}/optimisations/{actionName} | Optimise products
[**OptimiseByCategory**](BeezUPApi.md#optimisebycategory) | **POST** /user/analytics/{storeId}/optimisations/bycategory/{catalogCategoryId}/{actionName} | Optimise products&#39;s category
[**OptimiseByChannel**](BeezUPApi.md#optimisebychannel) | **POST** /user/analytics/{storeId}/optimisations/bychannel/{channelId}/{actionName} | Optimise products&#39;s category
[**OptimiseByProduct**](BeezUPApi.md#optimisebyproduct) | **POST** /user/analytics/{storeId}/optimisations/byproduct/{productId}/{actionName} | Optimise products
[**OverrideChannelCatalogProductOverrides**](BeezUPApi.md#overridechannelcatalogproductoverrides) | **PUT** /user/channelCatalogs/{channelCatalogId}/products/{productId}/overrides | Override channel catalog product values
[**ReactivateCurrentContract**](BeezUPApi.md#reactivatecurrentcontract) | **POST** /user/customer/contracts/current/reenableAutoRenewal | Reactivate your terminated contract.
[**ReenableChannelCatalogProduct**](BeezUPApi.md#reenablechannelcatalogproduct) | **POST** /user/channelCatalogs/{channelCatalogId}/products/{productId}/reenable | Reenable channel catalog product
[**Register**](BeezUPApi.md#register) | **POST** /public/security/register | User Registration
[**ResendEmailActivation**](BeezUPApi.md#resendemailactivation) | **POST** /user/customer/account/resendEmailActivation | Resend email activation
[**RunRule**](BeezUPApi.md#runrule) | **POST** /user/analytics/{storeId}/rules/{ruleId}/run | Run rule
[**RunRules**](BeezUPApi.md#runrules) | **POST** /user/analytics/{storeId}/rules/run | Run all rules for this store
[**SaveCompanyInfo**](BeezUPApi.md#savecompanyinfo) | **PUT** /user/customer/account/companyInfo | Change company information
[**SaveCreditCardInfo**](BeezUPApi.md#savecreditcardinfo) | **PUT** /user/customer/account/creditCardInfo | Save user credit card info
[**SavePersonalInfo**](BeezUPApi.md#savepersonalinfo) | **PUT** /user/customer/account/personalInfo | Save user personal information
[**SaveProfilePictureInfo**](BeezUPApi.md#saveprofilepictureinfo) | **PUT** /user/customer/account/profilePictureInfo | Change user picture information
[**SaveReportFilter**](BeezUPApi.md#savereportfilter) | **PUT** /user/analytics/{storeId}/reports/filters/{reportFilterId} | Save the report filter
[**SaveStoreAlert**](BeezUPApi.md#savestorealert) | **PUT** /user/customer/stores/{storeId}/alerts/{alertId} | Save store alert
[**SetChannelCatalogMarketplaceSettings**](BeezUPApi.md#setchannelcatalogmarketplacesettings) | **POST** /user/marketplaces/channelcatalogs/{channelCatalogId}/settings | Save new marketplace settings for a channel catalog
[**SetMerchantOrderInfo**](BeezUPApi.md#setmerchantorderinfo) | **POST** /user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/setMerchantOrderInfo | Set an Order&#39;s merchant information
[**SetMerchantOrderInfoList**](BeezUPApi.md#setmerchantorderinfolist) | **POST** /user/marketplaces/orders/batches/setMerchantOrderInfos | Send a batch of operations to set an Order&#39;s merchant information
[**Share**](BeezUPApi.md#share) | **POST** /user/customer/stores/{storeId}/shares | Share a store to another user
[**TerminateCurrentContract**](BeezUPApi.md#terminatecurrentcontract) | **POST** /user/customer/contracts/current/disableAutoRenewal | Schedule termination of your current contract at the end of the commitment.
[**UnmapChannelCatalogCategory**](BeezUPApi.md#unmapchannelcatalogcategory) | **POST** /user/channelCatalogs/{channelCatalogId}/categoryMappings/unmap | Unmap channel catalog category
[**UpdateRule**](BeezUPApi.md#updaterule) | **PATCH** /user/analytics/{storeId}/rules/{ruleId} | Update Rule
[**UpdateStore**](BeezUPApi.md#updatestore) | **PATCH** /user/customer/stores/{storeId} | Update some store&#39;s information.


<a name="activateuseraccount"></a>
# **ActivateUserAccount**
> void ActivateUserAccount (string emailActivationId)

Activate the user account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActivateUserAccountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var emailActivationId = emailActivationId_example;  // string | The email activation id received by email.

            try
            {
                // Activate the user account
                apiInstance.ActivateUserAccount(emailActivationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ActivateUserAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailActivationId** | **string**| The email activation id received by email. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autoconfigureautoimportinterval"></a>
# **AutoConfigureAutoImportInterval**
> void AutoConfigureAutoImportInterval (string storeId, ConfigureAutoImportIntervalRequest request)

Configure Auto Import Interval

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoConfigureAutoImportIntervalExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ConfigureAutoImportIntervalRequest(); // ConfigureAutoImportIntervalRequest | 

            try
            {
                // Configure Auto Import Interval
                apiInstance.AutoConfigureAutoImportInterval(storeId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.AutoConfigureAutoImportInterval: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ConfigureAutoImportIntervalRequest**](ConfigureAutoImportIntervalRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autodeleteautoimport"></a>
# **AutoDeleteAutoImport**
> void AutoDeleteAutoImport (string storeId)

Delete Auto Import

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoDeleteAutoImportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Delete Auto Import
                apiInstance.AutoDeleteAutoImport(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.AutoDeleteAutoImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autogetautoimportconfiguration"></a>
# **AutoGetAutoImportConfiguration**
> AutoImportConfiguration AutoGetAutoImportConfiguration (string storeId)

Get the auto import configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoGetAutoImportConfigurationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get the auto import configuration
                AutoImportConfiguration result = apiInstance.AutoGetAutoImportConfiguration(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.AutoGetAutoImportConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**AutoImportConfiguration**](AutoImportConfiguration.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autopauseautoimport"></a>
# **AutoPauseAutoImport**
> void AutoPauseAutoImport (string storeId)

Pause Auto Import

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoPauseAutoImportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Pause Auto Import
                apiInstance.AutoPauseAutoImport(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.AutoPauseAutoImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autoresumeautoimport"></a>
# **AutoResumeAutoImport**
> void AutoResumeAutoImport (string storeId)

Resume Auto Import

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoResumeAutoImportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Resume Auto Import
                apiInstance.AutoResumeAutoImport(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.AutoResumeAutoImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autoscheduleautoimport"></a>
# **AutoScheduleAutoImport**
> void AutoScheduleAutoImport (string storeId, ScheduleAutoImportRequest request)

Configure Auto Import Schedules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoScheduleAutoImportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ScheduleAutoImportRequest(); // ScheduleAutoImportRequest | 

            try
            {
                // Configure Auto Import Schedules
                apiInstance.AutoScheduleAutoImport(storeId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.AutoScheduleAutoImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ScheduleAutoImportRequest**](ScheduleAutoImportRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autostartautoimport"></a>
# **AutoStartAutoImport**
> LinksImportationGetImportationMonitoringLink AutoStartAutoImport (string storeId)

Start Auto Import Manually

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoStartAutoImportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Start Auto Import Manually
                LinksImportationGetImportationMonitoringLink result = apiInstance.AutoStartAutoImport(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.AutoStartAutoImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**LinksImportationGetImportationMonitoringLink**](LinksImportationGetImportationMonitoringLink.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogchangecatalogcolumnusername"></a>
# **CatalogChangeCatalogColumnUserName**
> void CatalogChangeCatalogColumnUserName (string storeId, string columnId, ChangeUserColumnNameRequest request)

Change Catalog Column User Name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogChangeCatalogColumnUserNameExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var columnId = columnId_example;  // string | The catalog column identifier
            var request = new ChangeUserColumnNameRequest(); // ChangeUserColumnNameRequest | 

            try
            {
                // Change Catalog Column User Name
                apiInstance.CatalogChangeCatalogColumnUserName(storeId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogChangeCatalogColumnUserName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **columnId** | **string**| The catalog column identifier | 
 **request** | [**ChangeUserColumnNameRequest**](ChangeUserColumnNameRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogchangecustomcolumnexpression"></a>
# **CatalogChangeCustomColumnExpression**
> void CatalogChangeCustomColumnExpression (string storeId, string columnId, ChangeCustomColumnExpressionRequest request)

Change custom column expression

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogChangeCustomColumnExpressionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var columnId = columnId_example;  // string | The custom column identifier
            var request = new ChangeCustomColumnExpressionRequest(); // ChangeCustomColumnExpressionRequest | 

            try
            {
                // Change custom column expression
                apiInstance.CatalogChangeCustomColumnExpression(storeId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogChangeCustomColumnExpression: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **columnId** | **string**| The custom column identifier | 
 **request** | [**ChangeCustomColumnExpressionRequest**](ChangeCustomColumnExpressionRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogchangecustomcolumnusername"></a>
# **CatalogChangeCustomColumnUserName**
> void CatalogChangeCustomColumnUserName (string storeId, string columnId, ChangeUserColumnNameRequest request)

Change Custom Column User Name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogChangeCustomColumnUserNameExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var columnId = columnId_example;  // string | The custom column identifier
            var request = new ChangeUserColumnNameRequest(); // ChangeUserColumnNameRequest | 

            try
            {
                // Change Custom Column User Name
                apiInstance.CatalogChangeCustomColumnUserName(storeId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogChangeCustomColumnUserName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **columnId** | **string**| The custom column identifier | 
 **request** | [**ChangeUserColumnNameRequest**](ChangeUserColumnNameRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogcomputeexpression"></a>
# **CatalogComputeExpression**
> string CatalogComputeExpression (string storeId, ComputeExpressionRequest request)

Compute the expression for this catalog.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogComputeExpressionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ComputeExpressionRequest(); // ComputeExpressionRequest | 

            try
            {
                // Compute the expression for this catalog.
                string result = apiInstance.CatalogComputeExpression(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogComputeExpression: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ComputeExpressionRequest**](ComputeExpressionRequest.md)|  | 

### Return type

**string**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogdeletecustomcolumn"></a>
# **CatalogDeleteCustomColumn**
> void CatalogDeleteCustomColumn (string storeId, string columnId)

Delete custom column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogDeleteCustomColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Delete custom column
                apiInstance.CatalogDeleteCustomColumn(storeId, columnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogDeleteCustomColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **columnId** | **string**| The custom column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetbeezupcolumns"></a>
# **CatalogGetBeezUPColumns**
> List<BeezUPColumnConfiguration> CatalogGetBeezUPColumns ()

Get the BeezUP columns

Get the BeezUP columns, this columns are used for mapping during the manual catalog importation process.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetBeezUPColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get the BeezUP columns
                List&lt;BeezUPColumnConfiguration&gt; result = apiInstance.CatalogGetBeezUPColumns();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogGetBeezUPColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BeezUPColumnConfiguration>**](BeezUPColumnConfiguration.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetcatalogcolumns"></a>
# **CatalogGetCatalogColumns**
> CatalogColumns CatalogGetCatalogColumns (string storeId)

Get catalog column list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetCatalogColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get catalog column list
                CatalogColumns result = apiInstance.CatalogGetCatalogColumns(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogGetCatalogColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**CatalogColumns**](CatalogColumns.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetcategories"></a>
# **CatalogGetCategories**
> Categories CatalogGetCategories (string storeId, List<string> acceptEncoding)

Get category list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetCategoriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var acceptEncoding = new List<string>(); // List<string> | Indicates that the client accepts that the response will be compressed to reduce traffic size.

            try
            {
                // Get category list
                Categories result = apiInstance.CatalogGetCategories(storeId, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogGetCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **acceptEncoding** | [**List&lt;string&gt;**](string.md)| Indicates that the client accepts that the response will be compressed to reduce traffic size. | 

### Return type

[**Categories**](Categories.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetcustomcolumnexpression"></a>
# **CatalogGetCustomColumnExpression**
> string CatalogGetCustomColumnExpression (string storeId, string columnId)

Get the encrypted custom column expression

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetCustomColumnExpressionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Get the encrypted custom column expression
                string result = apiInstance.CatalogGetCustomColumnExpression(storeId, columnId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogGetCustomColumnExpression: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **columnId** | **string**| The custom column identifier | 

### Return type

**string**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetcustomcolumns"></a>
# **CatalogGetCustomColumns**
> CustomColumns CatalogGetCustomColumns (string storeId)

Get custom column list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetCustomColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get custom column list
                CustomColumns result = apiInstance.CatalogGetCustomColumns(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogGetCustomColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**CustomColumns**](CustomColumns.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetproduct"></a>
# **CatalogGetProduct**
> Product CatalogGetProduct (string storeId, string productId)

Get product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var productId = productId_example;  // string | The product identifier you want to get

            try
            {
                // Get product
                Product result = apiInstance.CatalogGetProduct(storeId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogGetProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **productId** | **string**| The product identifier you want to get | 

### Return type

[**Product**](Product.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetproducts"></a>
# **CatalogGetProducts**
> Products CatalogGetProducts (string storeId, GetProductsRequest request = null)

Get product list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetProductsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new GetProductsRequest(); // GetProductsRequest |  (optional) 

            try
            {
                // Get product list
                Products result = apiInstance.CatalogGetProducts(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogGetProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**GetProductsRequest**](GetProductsRequest.md)|  | [optional] 

### Return type

[**Products**](Products.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetrandomproducts"></a>
# **CatalogGetRandomProducts**
> Products CatalogGetRandomProducts (string storeId, int? count = null)

Get random product list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetRandomProductsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var count = 25;  // int? | The count of random product you want to get (optional)  (default to 100)

            try
            {
                // Get random product list
                Products result = apiInstance.CatalogGetRandomProducts(storeId, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogGetRandomProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **count** | **int?**| The count of random product you want to get | [optional] [default to 100]

### Return type

[**Products**](Products.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogsavecustomcolumn"></a>
# **CatalogSaveCustomColumn**
> void CatalogSaveCustomColumn (string storeId, string columnId, CreateCustomColumnRequest request)

Create or replace a custom column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogSaveCustomColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var columnId = columnId_example;  // string | The custom column identifier
            var request = new CreateCustomColumnRequest(); // CreateCustomColumnRequest | 

            try
            {
                // Create or replace a custom column
                apiInstance.CatalogSaveCustomColumn(storeId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CatalogSaveCustomColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **columnId** | **string**| The custom column identifier | 
 **request** | [**CreateCustomColumnRequest**](CreateCustomColumnRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changeorder"></a>
# **ChangeOrder**
> void ChangeOrder (string marketplaceTechnicalCode, int? accountId, Guid? beezUPOrderId, string changeOrderType, string userName, ChangeOrderRequest request, string ifMatch, bool? testMode = null)

Change your marketplace Order Information (accept, ship, etc.)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeOrderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // Guid? | The BeezUP Order identifier
            var changeOrderType = changeOrderType_example;  // string | The Order change type
            var userName = userName_example;  // string | Sometimes the user in the e-commerce application is not the same as user associated with the current subscription key. We recommend providing your application's user login.
            var request = new ChangeOrderRequest(); // ChangeOrderRequest | 
            var ifMatch = ifMatch_example;  // string | ETag value to identify the last known version of requested resource.\\ To ensure that you are making a change on the lastest version of the resource.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3 
            var testMode = false;  // bool? | If true, the operation will be not be sent to marketplace. But the validation will be taken in account. (optional)  (default to false)

            try
            {
                // Change your marketplace Order Information (accept, ship, etc.)
                apiInstance.ChangeOrder(marketplaceTechnicalCode, accountId, beezUPOrderId, changeOrderType, userName, request, ifMatch, testMode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ChangeOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| The marketplace technical code | 
 **accountId** | **int?**| The account identifier | 
 **beezUPOrderId** | **Guid?**| The BeezUP Order identifier | 
 **changeOrderType** | **string**| The Order change type | 
 **userName** | **string**| Sometimes the user in the e-commerce application is not the same as user associated with the current subscription key. We recommend providing your application&#39;s user login. | 
 **request** | [**ChangeOrderRequest**](ChangeOrderRequest.md)|  | 
 **ifMatch** | **string**| ETag value to identify the last known version of requested resource.\\ To ensure that you are making a change on the lastest version of the resource.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  | 
 **testMode** | **bool?**| If true, the operation will be not be sent to marketplace. But the validation will be taken in account. | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changeorderlist"></a>
# **ChangeOrderList**
> BatchOrderOperationResponse ChangeOrderList (string changeOrderType, string userName, ChangeOrderListRequest request, bool? testMode = null)

Send a batch of operations to change your marketplace Order information (accept, ship, etc.)

The purpose of this operation is to reduce the amount of request to the API.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeOrderListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var changeOrderType = changeOrderType_example;  // string | The Order change type
            var userName = userName_example;  // string | Sometimes the user in the e-commerce application is not the same as user associated with the current subscription key. We recommend providing your application's user login.
            var request = new ChangeOrderListRequest(); // ChangeOrderListRequest | 
            var testMode = false;  // bool? | If true, the operation will be not be sent to marketplace. But the validation will be taken in account. (optional)  (default to false)

            try
            {
                // Send a batch of operations to change your marketplace Order information (accept, ship, etc.)
                BatchOrderOperationResponse result = apiInstance.ChangeOrderList(changeOrderType, userName, request, testMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ChangeOrderList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changeOrderType** | **string**| The Order change type | 
 **userName** | **string**| Sometimes the user in the e-commerce application is not the same as user associated with the current subscription key. We recommend providing your application&#39;s user login. | 
 **request** | [**ChangeOrderListRequest**](ChangeOrderListRequest.md)|  | 
 **testMode** | **bool?**| If true, the operation will be not be sent to marketplace. But the validation will be taken in account. | [optional] [default to false]

### Return type

[**BatchOrderOperationResponse**](BatchOrderOperationResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changepassword"></a>
# **ChangePassword**
> void ChangePassword (ChangePasswordRequest request)

Change user password

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangePasswordExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new ChangePasswordRequest(); // ChangePasswordRequest | 

            try
            {
                // Change user password
                apiInstance.ChangePassword(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ChangePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ChangePasswordRequest**](ChangePasswordRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clearmerchantorderinfo"></a>
# **ClearMerchantOrderInfo**
> void ClearMerchantOrderInfo (string marketplaceTechnicalCode, int? accountId, Guid? beezUPOrderId)

Clear an Order's merchant information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClearMerchantOrderInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // Guid? | The BeezUP Order identifier

            try
            {
                // Clear an Order's merchant information
                apiInstance.ClearMerchantOrderInfo(marketplaceTechnicalCode, accountId, beezUPOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ClearMerchantOrderInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| The marketplace technical code | 
 **accountId** | **int?**| The account identifier | 
 **beezUPOrderId** | **Guid?**| The BeezUP Order identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clearmerchantorderinfolist"></a>
# **ClearMerchantOrderInfoList**
> BatchOrderOperationResponse ClearMerchantOrderInfoList (ClearMerchantOrderInfoListRequest request)

Send a batch of operations to clear an Order's merchant information

The purpose of this operation is to reduce the amount of request to the API.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClearMerchantOrderInfoListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new ClearMerchantOrderInfoListRequest(); // ClearMerchantOrderInfoListRequest | 

            try
            {
                // Send a batch of operations to clear an Order's merchant information
                BatchOrderOperationResponse result = apiInstance.ClearMerchantOrderInfoList(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ClearMerchantOrderInfoList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ClearMerchantOrderInfoListRequest**](ClearMerchantOrderInfoListRequest.md)|  | 

### Return type

[**BatchOrderOperationResponse**](BatchOrderOperationResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configureautomatictransitions"></a>
# **ConfigureAutomaticTransitions**
> void ConfigureAutomaticTransitions (ConfigureAutomaticTransitionRequest request)

Configure new or existing automatic Order status transition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfigureAutomaticTransitionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new ConfigureAutomaticTransitionRequest(); // ConfigureAutomaticTransitionRequest | 

            try
            {
                // Configure new or existing automatic Order status transition
                apiInstance.ConfigureAutomaticTransitions(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ConfigureAutomaticTransitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ConfigureAutomaticTransitionRequest**](ConfigureAutomaticTransitionRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurechannelcatalogcostsettings"></a>
# **ConfigureChannelCatalogCostSettings**
> void ConfigureChannelCatalogCostSettings (string channelCatalogId, CostSettings request)

Disable a channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfigureChannelCatalogCostSettingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new CostSettings(); // CostSettings | 

            try
            {
                // Disable a channel catalog
                apiInstance.ConfigureChannelCatalogCostSettings(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ConfigureChannelCatalogCostSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**CostSettings**](CostSettings.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurechannelcatalogexclusionfilters"></a>
# **ConfigureChannelCatalogExclusionFilters**
> void ConfigureChannelCatalogExclusionFilters (string channelCatalogId, ExclusionFilters request)

Configure channel catalog exclusion filters

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfigureChannelCatalogExclusionFiltersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new ExclusionFilters(); // ExclusionFilters | 

            try
            {
                // Configure channel catalog exclusion filters
                apiInstance.ConfigureChannelCatalogExclusionFilters(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ConfigureChannelCatalogExclusionFilters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**ExclusionFilters**](ExclusionFilters.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurechannelcataloggeneralsettings"></a>
# **ConfigureChannelCatalogGeneralSettings**
> void ConfigureChannelCatalogGeneralSettings (string channelCatalogId, GeneralSettings request)

Disable a channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfigureChannelCatalogGeneralSettingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new GeneralSettings(); // GeneralSettings | 

            try
            {
                // Disable a channel catalog
                apiInstance.ConfigureChannelCatalogGeneralSettings(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ConfigureChannelCatalogGeneralSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**GeneralSettings**](GeneralSettings.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchannelcatalog"></a>
# **CreateChannelCatalog**
> List<BeezUPCommonLink2> CreateChannelCatalog (CreateChannelCatalogRequest request)

Create a new channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateChannelCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new CreateChannelCatalogRequest(); // CreateChannelCatalogRequest | 

            try
            {
                // Create a new channel catalog
                List&lt;BeezUPCommonLink2&gt; result = apiInstance.CreateChannelCatalog(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CreateChannelCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateChannelCatalogRequest**](CreateChannelCatalogRequest.md)|  | 

### Return type

[**List<BeezUPCommonLink2>**](BeezUPCommonLink2.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcontract"></a>
# **CreateContract**
> BeezUPCommonInfoSummaries CreateContract (CreateContract request)

Create a new contract

Now you are ready to create your contract. Before that, please ensure that you check the offer with the same request parameterts. /offers 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateContractExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new CreateContract(); // CreateContract | 

            try
            {
                // Create a new contract
                BeezUPCommonInfoSummaries result = apiInstance.CreateContract(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CreateContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateContract**](CreateContract.md)|  | 

### Return type

[**BeezUPCommonInfoSummaries**](BeezUPCommonInfoSummaries.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrule"></a>
# **CreateRule**
> void CreateRule (string storeId, CreateRuleRequest request)

Rule creation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new CreateRuleRequest(); // CreateRuleRequest | 

            try
            {
                // Rule creation
                apiInstance.CreateRule(storeId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CreateRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**CreateRuleRequest**](CreateRuleRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstore"></a>
# **CreateStore**
> LinksGetStoresLink CreateStore (CreateStoreRequest request)

Create a new store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateStoreExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new CreateStoreRequest(); // CreateStoreRequest | 

            try
            {
                // Create a new store
                LinksGetStoresLink result = apiInstance.CreateStore(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.CreateStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateStoreRequest**](CreateStoreRequest.md)|  | 

### Return type

[**LinksGetStoresLink**](LinksGetStoresLink.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechannelcatalog"></a>
# **DeleteChannelCatalog**
> void DeleteChannelCatalog (string channelCatalogId)

Delete the channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteChannelCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Delete the channel catalog
                apiInstance.DeleteChannelCatalog(channelCatalogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.DeleteChannelCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechannelcatalogexportationcache"></a>
# **DeleteChannelCatalogExportationCache**
> void DeleteChannelCatalogExportationCache (string channelCatalogId)

Delete the exportation cache

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteChannelCatalogExportationCacheExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Delete the exportation cache
                apiInstance.DeleteChannelCatalogExportationCache(channelCatalogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.DeleteChannelCatalogExportationCache: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechannelcatalogproductvalueoverride"></a>
# **DeleteChannelCatalogProductValueOverride**
> void DeleteChannelCatalogProductValueOverride (string channelCatalogId, string productId, string channelColumnId)

Delete a specific channel catalog product value override

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteChannelCatalogProductValueOverrideExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var productId = 578419df-1bbf-41a6-96fa-862e42182b67;  // string | The product identifier
            var channelColumnId = 8a76f06a-fefc-4c0d-bcfe-b210f1482977;  // string | The channel column identifier

            try
            {
                // Delete a specific channel catalog product value override
                apiInstance.DeleteChannelCatalogProductValueOverride(channelCatalogId, productId, channelColumnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.DeleteChannelCatalogProductValueOverride: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **productId** | **string**| The product identifier | 
 **channelColumnId** | **string**| The channel column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenextcontract"></a>
# **DeleteNextContract**
> void DeleteNextContract ()

Delete your next contract

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteNextContractExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Delete your next contract
                apiInstance.DeleteNextContract();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.DeleteNextContract: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereportfilter"></a>
# **DeleteReportFilter**
> void DeleteReportFilter (string storeId, string reportFilterId)

Delete the report filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteReportFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var reportFilterId = reportFilterId_example;  // string | Your report filter identifier

            try
            {
                // Delete the report filter
                apiInstance.DeleteReportFilter(storeId, reportFilterId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.DeleteReportFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **reportFilterId** | **string**| Your report filter identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterule"></a>
# **DeleteRule**
> void DeleteRule (string storeId, string ruleId)

Delete Rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Delete Rule
                apiInstance.DeleteRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.DeleteRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshare"></a>
# **DeleteShare**
> void DeleteShare (string storeId, string userId)

Delete a share to another user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteShareExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var userId = userId_example;  // string | The friend user id

            try
            {
                // Delete a share to another user
                apiInstance.DeleteShare(storeId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.DeleteShare: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **userId** | **string**| The friend user id | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestore"></a>
# **DeleteStore**
> void DeleteStore (string storeId)

Delete a store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteStoreExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Delete a store
                apiInstance.DeleteStore(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.DeleteStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disablechannelcatalog"></a>
# **DisableChannelCatalog**
> void DisableChannelCatalog (string channelCatalogId)

Disable a channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DisableChannelCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Disable a channel catalog
                apiInstance.DisableChannelCatalog(channelCatalogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.DisableChannelCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disablechannelcatalogproduct"></a>
# **DisableChannelCatalogProduct**
> void DisableChannelCatalogProduct (string channelCatalogId, string productId)

Disable channel catalog product

By default a all your catalog products are exposed to the channel. You can disable a product by using this operation. /!\\ In case of massive optimisation we recommand you to use the analytics api 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DisableChannelCatalogProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var productId = 578419df-1bbf-41a6-96fa-862e42182b67;  // string | The product identifier

            try
            {
                // Disable channel catalog product
                apiInstance.DisableChannelCatalogProduct(channelCatalogId, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.DisableChannelCatalogProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **productId** | **string**| The product identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disablerule"></a>
# **DisableRule**
> void DisableRule (string storeId, string ruleId)

Disable rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DisableRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Disable rule
                apiInstance.DisableRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.DisableRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enablechannelcatalog"></a>
# **EnableChannelCatalog**
> void EnableChannelCatalog (string channelCatalogId)

Enable a channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EnableChannelCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Enable a channel catalog
                apiInstance.EnableChannelCatalog(channelCatalogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.EnableChannelCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enablerule"></a>
# **EnableRule**
> void EnableRule (string storeId, string ruleId)

Enable rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EnableRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Enable rule
                apiInstance.EnableRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.EnableRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportorders"></a>
# **ExportOrders**
> void ExportOrders (ExportOrderListRequest request)

Request a new Order report exportation to be generated

A new file will be generated containing a summary of all the Orders matching the requested filter settings.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportOrdersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new ExportOrderListRequest(); // ExportOrderListRequest | 

            try
            {
                // Request a new Order report exportation to be generated
                apiInstance.ExportOrders(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ExportOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ExportOrderListRequest**](ExportOrderListRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportstorereportbycategory"></a>
# **ExportStoreReportByCategory**
> BeezUPCommonLink3 ExportStoreReportByCategory (string storeId, string format, ReportByCategoryRequest request)

Export the report by category

Export the report by category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportStoreReportByCategoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var format = format_example;  // string | 
            var request = new ReportByCategoryRequest(); // ReportByCategoryRequest | 

            try
            {
                // Export the report by category
                BeezUPCommonLink3 result = apiInstance.ExportStoreReportByCategory(storeId, format, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ExportStoreReportByCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **format** | **string**|  | 
 **request** | [**ReportByCategoryRequest**](ReportByCategoryRequest.md)|  | 

### Return type

[**BeezUPCommonLink3**](BeezUPCommonLink3.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportstorereportbychannel"></a>
# **ExportStoreReportByChannel**
> BeezUPCommonLink3 ExportStoreReportByChannel (string storeId, string format, ReportByChannelRequest request)

Export the report by channel

Export the report by channel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportStoreReportByChannelExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var format = format_example;  // string | 
            var request = new ReportByChannelRequest(); // ReportByChannelRequest | 

            try
            {
                // Export the report by channel
                BeezUPCommonLink3 result = apiInstance.ExportStoreReportByChannel(storeId, format, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ExportStoreReportByChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **format** | **string**|  | 
 **request** | [**ReportByChannelRequest**](ReportByChannelRequest.md)|  | 

### Return type

[**BeezUPCommonLink3**](BeezUPCommonLink3.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportstorereportbyproduct"></a>
# **ExportStoreReportByProduct**
> BeezUPCommonLink3 ExportStoreReportByProduct (string storeId, string format, ReportByProductRequest request)

Export the report by product

Export the report by product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportStoreReportByProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var format = format_example;  // string | 
            var request = new ReportByProductRequest(); // ReportByProductRequest | 

            try
            {
                // Export the report by product
                BeezUPCommonLink3 result = apiInstance.ExportStoreReportByProduct(storeId, format, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ExportStoreReportByProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **format** | **string**|  | 
 **request** | [**ReportByProductRequest**](ReportByProductRequest.md)|  | 

### Return type

[**BeezUPCommonLink3**](BeezUPCommonLink3.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getautomatictransitions"></a>
# **GetAutomaticTransitions**
> AutomaticTransitionInfos GetAutomaticTransitions ()

Get list of configured automatic Order status transitions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAutomaticTransitionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get list of configured automatic Order status transitions
                AutomaticTransitionInfos result = apiInstance.GetAutomaticTransitions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetAutomaticTransitions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AutomaticTransitionInfos**](AutomaticTransitionInfos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getavailablechannels"></a>
# **GetAvailableChannels**
> List<ChannelHeader> GetAvailableChannels (string storeId)

List all available channel for this store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAvailableChannelsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = 04730364-9826-4ff3-92e4-51fccd02bf10;  // string | The store identifier

            try
            {
                // List all available channel for this store
                List&lt;ChannelHeader&gt; result = apiInstance.GetAvailableChannels(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetAvailableChannels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| The store identifier | 

### Return type

[**List<ChannelHeader>**](ChannelHeader.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingperiods"></a>
# **GetBillingPeriods**
> BillingPeriods GetBillingPeriods ()

Get billing periods conditions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBillingPeriodsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get billing periods conditions
                BillingPeriods result = apiInstance.GetBillingPeriods();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetBillingPeriods: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BillingPeriods**](BillingPeriods.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalog"></a>
# **GetChannelCatalog**
> ChannelCatalog GetChannelCatalog (string channelCatalogId)

Get the channel catalog information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Get the channel catalog information
                ChannelCatalog result = apiInstance.GetChannelCatalog(channelCatalogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 

### Return type

[**ChannelCatalog**](ChannelCatalog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogcategories"></a>
# **GetChannelCatalogCategories**
> ChannelCatalogCategoryMappings GetChannelCatalogCategories (string channelCatalogId)

Get channel catalog categories

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogCategoriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Get channel catalog categories
                ChannelCatalogCategoryMappings result = apiInstance.GetChannelCatalogCategories(channelCatalogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelCatalogCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 

### Return type

[**ChannelCatalogCategoryMappings**](ChannelCatalogCategoryMappings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogexclusionfilteroperators"></a>
# **GetChannelCatalogExclusionFilterOperators**
> List<ExclusionFilterOperator> GetChannelCatalogExclusionFilterOperators ()

Get channel catalog exclusion filter operators

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogExclusionFilterOperatorsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get channel catalog exclusion filter operators
                List&lt;ExclusionFilterOperator&gt; result = apiInstance.GetChannelCatalogExclusionFilterOperators();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelCatalogExclusionFilterOperators: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ExclusionFilterOperator>**](ExclusionFilterOperator.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogexportationcacheinfo"></a>
# **GetChannelCatalogExportationCacheInfo**
> ChannelCatalogExportCacheInfoResponse GetChannelCatalogExportationCacheInfo (string channelCatalogId)

Get the exportation cache information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogExportationCacheInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Get the exportation cache information
                ChannelCatalogExportCacheInfoResponse result = apiInstance.GetChannelCatalogExportationCacheInfo(channelCatalogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelCatalogExportationCacheInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 

### Return type

[**ChannelCatalogExportCacheInfoResponse**](ChannelCatalogExportCacheInfoResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogexportationhistory"></a>
# **GetChannelCatalogExportationHistory**
> ChannelCatalogExportationHistory GetChannelCatalogExportationHistory (string channelCatalogId, int? pageNumber, int? pageSize)

Get the exportation history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogExportationHistoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var pageNumber = 1;  // int? | The page number you want to get
            var pageSize = 25;  // int? | The entry count you want to get

            try
            {
                // Get the exportation history
                ChannelCatalogExportationHistory result = apiInstance.GetChannelCatalogExportationHistory(channelCatalogId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelCatalogExportationHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **pageNumber** | **int?**| The page number you want to get | 
 **pageSize** | **int?**| The entry count you want to get | 

### Return type

[**ChannelCatalogExportationHistory**](ChannelCatalogExportationHistory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogmarketplaceproperties"></a>
# **GetChannelCatalogMarketplaceProperties**
> ChannelCatalogMarketplaceProperties GetChannelCatalogMarketplaceProperties (string channelCatalogId)

Get the marketplace properties for a channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogMarketplacePropertiesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = channelCatalogId_example;  // string | 

            try
            {
                // Get the marketplace properties for a channel catalog
                ChannelCatalogMarketplaceProperties result = apiInstance.GetChannelCatalogMarketplaceProperties(channelCatalogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelCatalogMarketplaceProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**|  | 

### Return type

[**ChannelCatalogMarketplaceProperties**](ChannelCatalogMarketplaceProperties.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogmarketplacesettings"></a>
# **GetChannelCatalogMarketplaceSettings**
> ChannelCatalogMarketplaceSettings GetChannelCatalogMarketplaceSettings (string channelCatalogId)

Get the marketplace settings for a channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogMarketplaceSettingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = channelCatalogId_example;  // string | Channel Catalog Id to query (required)

            try
            {
                // Get the marketplace settings for a channel catalog
                ChannelCatalogMarketplaceSettings result = apiInstance.GetChannelCatalogMarketplaceSettings(channelCatalogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelCatalogMarketplaceSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| Channel Catalog Id to query (required) | 

### Return type

[**ChannelCatalogMarketplaceSettings**](ChannelCatalogMarketplaceSettings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogproductbychannelcatalog"></a>
# **GetChannelCatalogProductByChannelCatalog**
> ChannelCatalogProductByChannelCatalogResponse GetChannelCatalogProductByChannelCatalog (string productId, ChannelCatalogProductByChannelCatalogRequest request = null)

Get channel catalog products related to these channel catalogs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogProductByChannelCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var productId = 578419df-1bbf-41a6-96fa-862e42182b67;  // string | The product identifier
            var request = new ChannelCatalogProductByChannelCatalogRequest(); // ChannelCatalogProductByChannelCatalogRequest |  (optional) 

            try
            {
                // Get channel catalog products related to these channel catalogs
                ChannelCatalogProductByChannelCatalogResponse result = apiInstance.GetChannelCatalogProductByChannelCatalog(productId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelCatalogProductByChannelCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**| The product identifier | 
 **request** | [**ChannelCatalogProductByChannelCatalogRequest**](ChannelCatalogProductByChannelCatalogRequest.md)|  | [optional] 

### Return type

[**ChannelCatalogProductByChannelCatalogResponse**](ChannelCatalogProductByChannelCatalogResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogproductinfo"></a>
# **GetChannelCatalogProductInfo**
> ChannelCatalogProductInfo GetChannelCatalogProductInfo (string channelCatalogId, string productId)

Get channel catalog product information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogProductInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var productId = 578419df-1bbf-41a6-96fa-862e42182b67;  // string | The product identifier

            try
            {
                // Get channel catalog product information
                ChannelCatalogProductInfo result = apiInstance.GetChannelCatalogProductInfo(channelCatalogId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelCatalogProductInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **productId** | **string**| The product identifier | 

### Return type

[**ChannelCatalogProductInfo**](ChannelCatalogProductInfo.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogproductinfolist"></a>
# **GetChannelCatalogProductInfoList**
> ChannelCatalogProductInfoList GetChannelCatalogProductInfoList (string channelCatalogId, GetChannelCatalogProductInfoListRequest request = null)

Get channel catalog product information list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogProductInfoListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new GetChannelCatalogProductInfoListRequest(); // GetChannelCatalogProductInfoListRequest | The channel catalog product list filter (optional) 

            try
            {
                // Get channel catalog product information list
                ChannelCatalogProductInfoList result = apiInstance.GetChannelCatalogProductInfoList(channelCatalogId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelCatalogProductInfoList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**GetChannelCatalogProductInfoListRequest**](GetChannelCatalogProductInfoListRequest.md)| The channel catalog product list filter | [optional] 

### Return type

[**ChannelCatalogProductInfoList**](ChannelCatalogProductInfoList.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogs"></a>
# **GetChannelCatalogs**
> ChannelCatalogList GetChannelCatalogs (string storeId = null)

List all your current channel catalogs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = 04730364-9826-4ff3-92e4-51fccd02bf10;  // string | The store identifier (optional) 

            try
            {
                // List all your current channel catalogs
                ChannelCatalogList result = apiInstance.GetChannelCatalogs(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelCatalogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| The store identifier | [optional] 

### Return type

[**ChannelCatalogList**](ChannelCatalogList.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcategories"></a>
# **GetChannelCategories**
> ChannelRootCategory GetChannelCategories (string channelId, List<string> acceptEncoding)

Get channel categories

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCategoriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelId = 2dc136a7-0d3d-4cc9-a825-a28a42c53e28;  // string | The channel identifier
            var acceptEncoding = new List<string>(); // List<string> | Indicates that the client accepts that the response will be compressed to reduce traffic size.

            try
            {
                // Get channel categories
                ChannelRootCategory result = apiInstance.GetChannelCategories(channelId, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelId** | **string**| The channel identifier | 
 **acceptEncoding** | [**List&lt;string&gt;**](string.md)| Indicates that the client accepts that the response will be compressed to reduce traffic size. | 

### Return type

[**ChannelRootCategory**](ChannelRootCategory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcolumns"></a>
# **GetChannelColumns**
> List<ChannelColumn> GetChannelColumns (string channelId, List<string> acceptEncoding, List<BeezUPCommonChannelColumnId> request = null)

Get channel columns

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelId = 2dc136a7-0d3d-4cc9-a825-a28a42c53e28;  // string | The channel identifier
            var acceptEncoding = new List<string>(); // List<string> | Indicates that the client accepts that the response will be compressed to reduce traffic size.
            var request = new List<BeezUPCommonChannelColumnId>(); // List<BeezUPCommonChannelColumnId> | Allow you to filter the channel column identifier list your want to get (optional) 

            try
            {
                // Get channel columns
                List&lt;ChannelColumn&gt; result = apiInstance.GetChannelColumns(channelId, acceptEncoding, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelId** | **string**| The channel identifier | 
 **acceptEncoding** | [**List&lt;string&gt;**](string.md)| Indicates that the client accepts that the response will be compressed to reduce traffic size. | 
 **request** | [**List&lt;BeezUPCommonChannelColumnId&gt;**](BeezUPCommonChannelColumnId.md)| Allow you to filter the channel column identifier list your want to get | [optional] 

### Return type

[**List<ChannelColumn>**](ChannelColumn.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelinfo"></a>
# **GetChannelInfo**
> ChannelInfo GetChannelInfo (string channelId)

Get channel information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelId = 2dc136a7-0d3d-4cc9-a825-a28a42c53e28;  // string | The channel identifier

            try
            {
                // Get channel information
                ChannelInfo result = apiInstance.GetChannelInfo(channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelId** | **string**| The channel identifier | 

### Return type

[**ChannelInfo**](ChannelInfo.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannels"></a>
# **GetChannels**
> ChannelInfoList GetChannels (string countryIsoCode, List<string> acceptEncoding)

The channel list for one country

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelsExample
    {
        public void main()
        {
            
            var apiInstance = new BeezUPApi();
            var countryIsoCode = countryIsoCode_example;  // string | The country iso code alpha 3 based on this: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3#Decoding_table \\ To know which country are available you have to use the operation: GetChannelsByCountry 
            var acceptEncoding = new List<string>(); // List<string> | Allows the client to indicate wether it accepts a compressed encoding to reduce traffic size.

            try
            {
                // The channel list for one country
                ChannelInfoList result = apiInstance.GetChannels(countryIsoCode, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryIsoCode** | **string**| The country iso code alpha 3 based on this: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3#Decoding_table \\ To know which country are available you have to use the operation: GetChannelsByCountry  | 
 **acceptEncoding** | [**List&lt;string&gt;**](string.md)| Allows the client to indicate wether it accepts a compressed encoding to reduce traffic size. | 

### Return type

[**ChannelInfoList**](ChannelInfoList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelsindex"></a>
# **GetChannelsIndex**
> PublicChannelIndex GetChannelsIndex ()

Get public channel index

Use this operation to get the correct link to the channels and to the list of values

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelsIndexExample
    {
        public void main()
        {
            
            var apiInstance = new BeezUPApi();

            try
            {
                // Get public channel index
                PublicChannelIndex result = apiInstance.GetChannelsIndex();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetChannelsIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PublicChannelIndex**](PublicChannelIndex.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontracts"></a>
# **GetContracts**
> Contracts GetContracts ()

Get contract list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetContractsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get contract list
                Contracts result = apiInstance.GetContracts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetContracts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Contracts**](Contracts.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreditcardinfo"></a>
# **GetCreditCardInfo**
> CreditCardInfoResponse GetCreditCardInfo ()

Get credit card information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCreditCardInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get credit card information
                CreditCardInfoResponse result = apiInstance.GetCreditCardInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetCreditCardInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CreditCardInfoResponse**](CreditCardInfoResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfriendinfo"></a>
# **GetFriendInfo**
> UserFriendInfo GetFriendInfo (string userId)

Get friend information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFriendInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var userId = userId_example;  // string | Your friend user id

            try
            {
                // Get friend information
                UserFriendInfo result = apiInstance.GetFriendInfo(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetFriendInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| Your friend user id | 

### Return type

[**UserFriendInfo**](UserFriendInfo.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoices"></a>
# **GetInvoices**
> Invoices GetInvoices ()

Get all your invoices

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get all your invoices
                Invoices result = apiInstance.GetInvoices();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Invoices**](Invoices.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketplaceaccountstores"></a>
# **GetMarketplaceAccountStores**
> MarketplaceChannelCatalogList GetMarketplaceAccountStores ()

Get  you marketplace channel catalog list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMarketplaceAccountStoresExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get  you marketplace channel catalog list
                MarketplaceChannelCatalogList result = apiInstance.GetMarketplaceAccountStores();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetMarketplaceAccountStores: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MarketplaceChannelCatalogList**](MarketplaceChannelCatalogList.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketplaceaccountssynchronization"></a>
# **GetMarketplaceAccountsSynchronization**
> AccountSynchronizations GetMarketplaceAccountsSynchronization ()

Get current synchronization status between your marketplaces and BeezUP accounts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMarketplaceAccountsSynchronizationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get current synchronization status between your marketplaces and BeezUP accounts
                AccountSynchronizations result = apiInstance.GetMarketplaceAccountsSynchronization();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetMarketplaceAccountsSynchronization: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AccountSynchronizations**](AccountSynchronizations.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoffer"></a>
# **GetOffer**
> Offer GetOffer (OfferRequest request)

Get offer pricing

Get the offer pricing then you can create your contract with the same request parameters. /v2/user/customer/contracts 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOfferExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new OfferRequest(); // OfferRequest | 

            try
            {
                // Get offer pricing
                Offer result = apiInstance.GetOffer(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetOffer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**OfferRequest**](OfferRequest.md)|  | 

### Return type

[**Offer**](Offer.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorder"></a>
# **GetOrder**
> Order GetOrder (string marketplaceTechnicalCode, int? accountId, Guid? beezUPOrderId, string ifNoneMatch = null)

Get full Order and Order Item(s) properties

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // Guid? | The BeezUP Order identifier
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag value to identify the last known version of requested resource.\\ To avoid useless exchange, we recommend you to indicate the ETag you previously got from this operation.\\ If the ETag value does not match the response will be 200 to give you a new content, otherwise the response will be: 304 Not Modified, without any content.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  (optional) 

            try
            {
                // Get full Order and Order Item(s) properties
                Order result = apiInstance.GetOrder(marketplaceTechnicalCode, accountId, beezUPOrderId, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| The marketplace technical code | 
 **accountId** | **int?**| The account identifier | 
 **beezUPOrderId** | **Guid?**| The BeezUP Order identifier | 
 **ifNoneMatch** | **string**| ETag value to identify the last known version of requested resource.\\ To avoid useless exchange, we recommend you to indicate the ETag you previously got from this operation.\\ If the ETag value does not match the response will be 200 to give you a new content, otherwise the response will be: 304 Not Modified, without any content.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderexportations"></a>
# **GetOrderExportations**
> OrderExportations GetOrderExportations (int? pageNumber, int? pageSize, string storeId)

Get a paginated list of Order report exportations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderExportationsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var pageNumber = 1;  // int? | The page number you want to get
            var pageSize = 25;  // int? | The entry count you want to get
            var storeId = storeId_example;  // string | The store identifier to regroup the order exportations

            try
            {
                // Get a paginated list of Order report exportations
                OrderExportations result = apiInstance.GetOrderExportations(pageNumber, pageSize, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetOrderExportations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageNumber** | **int?**| The page number you want to get | 
 **pageSize** | **int?**| The entry count you want to get | 
 **storeId** | **string**| The store identifier to regroup the order exportations | 

### Return type

[**OrderExportations**](OrderExportations.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderhistory"></a>
# **GetOrderHistory**
> OrderHistory GetOrderHistory (string marketplaceTechnicalCode, int? accountId, Guid? beezUPOrderId)

Get an Order's harvest and change history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderHistoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // Guid? | The BeezUP Order identifier

            try
            {
                // Get an Order's harvest and change history
                OrderHistory result = apiInstance.GetOrderHistory(marketplaceTechnicalCode, accountId, beezUPOrderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetOrderHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| The marketplace technical code | 
 **accountId** | **int?**| The account identifier | 
 **beezUPOrderId** | **Guid?**| The BeezUP Order identifier | 

### Return type

[**OrderHistory**](OrderHistory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderindex"></a>
# **GetOrderIndex**
> OrderIndex GetOrderIndex ()

Get all actions you can do on the order API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderIndexExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get all actions you can do on the order API
                OrderIndex result = apiInstance.GetOrderIndex();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetOrderIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OrderIndex**](OrderIndex.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlistfull"></a>
# **GetOrderListFull**
> OrderListFull GetOrderListFull (List<string> acceptEncoding, OrderListRequest request)

Get a paginated list of all Orders with all Order and Order Item(s) properties

The purpose of this operation is to reduce the amount of request to the API.\\ \\ Previous implmentation of this feature only returned a partial (light) version of the Orders. The purpose of this API is to reduce the number of incoming requests by returning the complete (full) Order and Order Item(s) properties. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderListFullExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var acceptEncoding = new List<string>(); // List<string> | Allows the client to indicate wether it accepts a compressed encoding to reduce traffic size
            var request = new OrderListRequest(); // OrderListRequest | 

            try
            {
                // Get a paginated list of all Orders with all Order and Order Item(s) properties
                OrderListFull result = apiInstance.GetOrderListFull(acceptEncoding, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetOrderListFull: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptEncoding** | [**List&lt;string&gt;**](string.md)| Allows the client to indicate wether it accepts a compressed encoding to reduce traffic size | 
 **request** | [**OrderListRequest**](OrderListRequest.md)|  | 

### Return type

[**OrderListFull**](OrderListFull.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlistlight"></a>
# **GetOrderListLight**
> OrderListLight GetOrderListLight (OrderListRequest request)

Get a paginated list of all Orders without details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderListLightExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new OrderListRequest(); // OrderListRequest | 

            try
            {
                // Get a paginated list of all Orders without details
                OrderListLight result = apiInstance.GetOrderListLight(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetOrderListLight: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**OrderListRequest**](OrderListRequest.md)|  | 

### Return type

[**OrderListLight**](OrderListLight.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprofilepictureinfo"></a>
# **GetProfilePictureInfo**
> ProfilePictureInfoResponse GetProfilePictureInfo ()

Get profile picture information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProfilePictureInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get profile picture information
                ProfilePictureInfoResponse result = apiInstance.GetProfilePictureInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetProfilePictureInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ProfilePictureInfoResponse**](ProfilePictureInfoResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpubliclistofvalues"></a>
# **GetPublicListOfValues**
> PublicListOfValuesResponse GetPublicListOfValues (string listName, List<string> acceptLanguage = null, string ifNoneMatch = null)

Get the list of values related to this list name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPublicListOfValuesExample
    {
        public void main()
        {
            
            var apiInstance = new BeezUPApi();
            var listName = listName_example;  // string | The list of value name your want to get
            var acceptLanguage = new List<string>(); // List<string> | Indicates that the client accepts the following languages. (optional) 
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag value to identify the last known version of requested resource.\\ To avoid useless exchange, we recommend you to indicate the ETag you previously got from this operation.\\ If the ETag value does not match the response will be 200 to give you a new content, otherwise the response will be: 304 Not Modified, without any content.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  (optional) 

            try
            {
                // Get the list of values related to this list name
                PublicListOfValuesResponse result = apiInstance.GetPublicListOfValues(listName, acceptLanguage, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetPublicListOfValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listName** | **string**| The list of value name your want to get | 
 **acceptLanguage** | [**List&lt;string&gt;**](string.md)| Indicates that the client accepts the following languages. | [optional] 
 **ifNoneMatch** | **string**| ETag value to identify the last known version of requested resource.\\ To avoid useless exchange, we recommend you to indicate the ETag you previously got from this operation.\\ If the ETag value does not match the response will be 200 to give you a new content, otherwise the response will be: 304 Not Modified, without any content.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  | [optional] 

### Return type

[**PublicListOfValuesResponse**](PublicListOfValuesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpubliclovindex"></a>
# **GetPublicLovIndex**
> PublicLovIndex GetPublicLovIndex (string ifNoneMatch = null)

Get all list names

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPublicLovIndexExample
    {
        public void main()
        {
            
            var apiInstance = new BeezUPApi();
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag value to identify the last known version of requested resource.\\ To avoid useless exchange, we recommend you to indicate the ETag you previously got from this operation.\\ If the ETag value does not match the response will be 200 to give you a new content, otherwise the response will be: 304 Not Modified, without any content.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  (optional) 

            try
            {
                // Get all list names
                PublicLovIndex result = apiInstance.GetPublicLovIndex(ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetPublicLovIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ifNoneMatch** | **string**| ETag value to identify the last known version of requested resource.\\ To avoid useless exchange, we recommend you to indicate the ETag you previously got from this operation.\\ If the ETag value does not match the response will be 200 to give you a new content, otherwise the response will be: 304 Not Modified, without any content.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  | [optional] 

### Return type

[**PublicLovIndex**](PublicLovIndex.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpublications"></a>
# **GetPublications**
> AccountPublications GetPublications (string marketplaceTechnicalCode, int? accountId, string channelCatalogId = null, int? count = null, List<string> publicationTypes = null)

Fetch the publication history for an account, sorted by descending start date

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPublicationsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var marketplaceTechnicalCode = marketplaceTechnicalCode_example;  // string | Marketplace Technical Code to query (required)
            var accountId = 56;  // int? | Account Id to query (required)
            var channelCatalogId = channelCatalogId_example;  // string | Channel Catalog Id by which to filter (optional) (optional) 
            var count = 56;  // int? | Amount of entries to fetch (optional, default set to 10) (optional)  (default to 10)
            var publicationTypes = new List<string>(); // List<string> | Publication types by which to filter (optional) (optional) 

            try
            {
                // Fetch the publication history for an account, sorted by descending start date
                AccountPublications result = apiInstance.GetPublications(marketplaceTechnicalCode, accountId, channelCatalogId, count, publicationTypes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetPublications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| Marketplace Technical Code to query (required) | 
 **accountId** | **int?**| Account Id to query (required) | 
 **channelCatalogId** | **string**| Channel Catalog Id by which to filter (optional) | [optional] 
 **count** | **int?**| Amount of entries to fetch (optional, default set to 10) | [optional] [default to 10]
 **publicationTypes** | [**List&lt;string&gt;**](string.md)| Publication types by which to filter (optional) | [optional] 

### Return type

[**AccountPublications**](AccountPublications.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportfilter"></a>
# **GetReportFilter**
> ReportFilter GetReportFilter (string storeId, string reportFilterId)

Get the report filter description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReportFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var reportFilterId = reportFilterId_example;  // string | Your report filter identifier

            try
            {
                // Get the report filter description
                ReportFilter result = apiInstance.GetReportFilter(storeId, reportFilterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetReportFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **reportFilterId** | **string**| Your report filter identifier | 

### Return type

[**ReportFilter**](ReportFilter.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportfilters"></a>
# **GetReportFilters**
> ReportFilters GetReportFilters (string storeId)

Get report filter list for the given store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReportFiltersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get report filter list for the given store
                ReportFilters result = apiInstance.GetReportFilters(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetReportFilters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**ReportFilters**](ReportFilters.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrights"></a>
# **GetRights**
> List<FunctionalityRightInfo> GetRights (string storeId, List<string> functionalityCodeList)

Get store's rights

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRightsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var functionalityCodeList = ;  // List<string> | The functionality code list you want to check

            try
            {
                // Get store's rights
                List&lt;FunctionalityRightInfo&gt; result = apiInstance.GetRights(storeId, functionalityCodeList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetRights: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **functionalityCodeList** | **List&lt;string&gt;**| The functionality code list you want to check | 

### Return type

[**List<FunctionalityRightInfo>**](FunctionalityRightInfo.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrule"></a>
# **GetRule**
> Rule GetRule (string storeId, string ruleId)

Gets the rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Gets the rule
                Rule result = apiInstance.GetRule(storeId, ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

[**Rule**](Rule.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrules"></a>
# **GetRules**
> RuleList GetRules (string storeId)

Gets the list of rules for a given store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRulesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Gets the list of rules for a given store
                RuleList result = apiInstance.GetRules(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**RuleList**](RuleList.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrulesexecutions"></a>
# **GetRulesExecutions**
> RuleExecutionReportings GetRulesExecutions (string storeId, int? pageNumber, int? pageSize)

Get the rules execution history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRulesExecutionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var pageNumber = 56;  // int? | The page to retrieve (default to 1)
            var pageSize = 56;  // int? | The count of rule history to retrieve (default to 10)

            try
            {
                // Get the rules execution history
                RuleExecutionReportings result = apiInstance.GetRulesExecutions(storeId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetRulesExecutions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **pageNumber** | **int?**| The page to retrieve | [default to 1]
 **pageSize** | **int?**| The count of rule history to retrieve | [default to 10]

### Return type

[**RuleExecutionReportings**](RuleExecutionReportings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshares"></a>
# **GetShares**
> StoreShares GetShares (string storeId)

Get shares related to this store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSharesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get shares related to this store
                StoreShares result = apiInstance.GetShares(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetShares: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**StoreShares**](StoreShares.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstandardoffers"></a>
# **GetStandardOffers**
> StandardOffers GetStandardOffers ()

Get all standard offers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStandardOffersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get all standard offers
                StandardOffers result = apiInstance.GetStandardOffers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetStandardOffers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**StandardOffers**](StandardOffers.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstore"></a>
# **GetStore**
> StoreHeader GetStore (string storeId)

Get store's information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get store's information
                StoreHeader result = apiInstance.GetStore(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**StoreHeader**](StoreHeader.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorealerts"></a>
# **GetStoreAlerts**
> StoreAlerts GetStoreAlerts (string storeId)

Get store's alerts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreAlertsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get store's alerts
                StoreAlerts result = apiInstance.GetStoreAlerts(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetStoreAlerts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**StoreAlerts**](StoreAlerts.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorereportbycategory"></a>
# **GetStoreReportByCategory**
> ReportByCategoryResponse GetStoreReportByCategory (string storeId, ReportByCategoryRequest request)

Get the report by category

Get the report by category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreReportByCategoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ReportByCategoryRequest(); // ReportByCategoryRequest | 

            try
            {
                // Get the report by category
                ReportByCategoryResponse result = apiInstance.GetStoreReportByCategory(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetStoreReportByCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ReportByCategoryRequest**](ReportByCategoryRequest.md)|  | 

### Return type

[**ReportByCategoryResponse**](ReportByCategoryResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorereportbychannel"></a>
# **GetStoreReportByChannel**
> ReportByChannelResponse GetStoreReportByChannel (string storeId, ReportByChannelRequest request)

Get the report by channel

Get the report by channel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreReportByChannelExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ReportByChannelRequest(); // ReportByChannelRequest | 

            try
            {
                // Get the report by channel
                ReportByChannelResponse result = apiInstance.GetStoreReportByChannel(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetStoreReportByChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ReportByChannelRequest**](ReportByChannelRequest.md)|  | 

### Return type

[**ReportByChannelResponse**](ReportByChannelResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorereportbyday"></a>
# **GetStoreReportByDay**
> ReportByDayResponse GetStoreReportByDay (string storeId, ReportByDayRequest request)

Get the report by day

Get the report by day

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreReportByDayExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ReportByDayRequest(); // ReportByDayRequest | 

            try
            {
                // Get the report by day
                ReportByDayResponse result = apiInstance.GetStoreReportByDay(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetStoreReportByDay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ReportByDayRequest**](ReportByDayRequest.md)|  | 

### Return type

[**ReportByDayResponse**](ReportByDayResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorereportbydayexport"></a>
# **GetStoreReportByDayExport**
> BeezUPCommonLink3 GetStoreReportByDayExport (string storeId, string format, ReportByDayRequest request)

Get the report by day

Get the report by day

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreReportByDayExportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var format = format_example;  // string | 
            var request = new ReportByDayRequest(); // ReportByDayRequest | 

            try
            {
                // Get the report by day
                BeezUPCommonLink3 result = apiInstance.GetStoreReportByDayExport(storeId, format, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetStoreReportByDayExport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **format** | **string**|  | 
 **request** | [**ReportByDayRequest**](ReportByDayRequest.md)|  | 

### Return type

[**BeezUPCommonLink3**](BeezUPCommonLink3.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorereportbyproduct"></a>
# **GetStoreReportByProduct**
> ReportByProductResponse GetStoreReportByProduct (string storeId, ReportByProductRequest request)

Get the report by product

Get the report by product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreReportByProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ReportByProductRequest(); // ReportByProductRequest | 

            try
            {
                // Get the report by product
                ReportByProductResponse result = apiInstance.GetStoreReportByProduct(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetStoreReportByProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ReportByProductRequest**](ReportByProductRequest.md)|  | 

### Return type

[**ReportByProductResponse**](ReportByProductResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoretrackedclicks"></a>
# **GetStoreTrackedClicks**
> TrackedClicks GetStoreTrackedClicks (string storeId, int? count = null)

Get the latest clicks tracked

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreTrackedClicksExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var count = 56;  // int? | The click's count you want to get (optional)  (default to 100)

            try
            {
                // Get the latest clicks tracked
                TrackedClicks result = apiInstance.GetStoreTrackedClicks(storeId, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetStoreTrackedClicks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **count** | **int?**| The click&#39;s count you want to get | [optional] [default to 100]

### Return type

[**TrackedClicks**](TrackedClicks.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoretrackedexternalorders"></a>
# **GetStoreTrackedExternalOrders**
> TrackedExternalOrders GetStoreTrackedExternalOrders (string storeId, int? count = null)

Get the latest external orders tracked

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreTrackedExternalOrdersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var count = 56;  // int? | The external order's count you want to get (optional)  (default to 100)

            try
            {
                // Get the latest external orders tracked
                TrackedExternalOrders result = apiInstance.GetStoreTrackedExternalOrders(storeId, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetStoreTrackedExternalOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **count** | **int?**| The external order&#39;s count you want to get | [optional] [default to 100]

### Return type

[**TrackedExternalOrders**](TrackedExternalOrders.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoretrackedorders"></a>
# **GetStoreTrackedOrders**
> TrackedOrders GetStoreTrackedOrders (string storeId, int? count = null)

Get the latest orders tracked

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreTrackedOrdersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var count = 56;  // int? | The order's count you want to get (optional)  (default to 100)

            try
            {
                // Get the latest orders tracked
                TrackedOrders result = apiInstance.GetStoreTrackedOrders(storeId, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetStoreTrackedOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **count** | **int?**| The order&#39;s count you want to get | [optional] [default to 100]

### Return type

[**TrackedOrders**](TrackedOrders.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoretrackingstatus"></a>
# **GetStoreTrackingStatus**
> StoreTrackingStatus GetStoreTrackingStatus (string storeId)

Get store tracking synchronization status

Your clicks and orders are eventually consistent. \\ This operation indicates you at which date the projections are for this store. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreTrackingStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get store tracking synchronization status
                StoreTrackingStatus result = apiInstance.GetStoreTrackingStatus(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetStoreTrackingStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**StoreTrackingStatus**](StoreTrackingStatus.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstores"></a>
# **GetStores**
> Stores GetStores ()

Get store list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoresExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get store list
                Stores result = apiInstance.GetStores();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetStores: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Stores**](Stores.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettrackingstatus"></a>
# **GetTrackingStatus**
> TrackingStatus GetTrackingStatus ()

Display the synchronization status of the clicks and orders

Your clicks and orders are eventually consistent. \\ This operation indicates you at which date the projections are. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTrackingStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Display the synchronization status of the clicks and orders
                TrackingStatus result = apiInstance.GetTrackingStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetTrackingStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TrackingStatus**](TrackingStatus.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuseraccountinfo"></a>
# **GetUserAccountInfo**
> AccountInfo GetUserAccountInfo ()

Get user account information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserAccountInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get user account information
                AccountInfo result = apiInstance.GetUserAccountInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetUserAccountInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AccountInfo**](AccountInfo.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserlistofvalues"></a>
# **GetUserListOfValues**
> UserListOfValuesResponse GetUserListOfValues (string listName, List<string> acceptLanguage = null, string ifNoneMatch = null)

Get the list of values related to this list name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserListOfValuesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var listName = listName_example;  // string | The list of value name your want to get
            var acceptLanguage = new List<string>(); // List<string> | Indicates that the client accepts the following languages. (optional) 
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag value to identify the last known version of requested resource.\\ To avoid useless exchange, we recommend you to indicate the ETag you previously got from this operation.\\ If the ETag value does not match the response will be 200 to give you a new content, otherwise the response will be: 304 Not Modified, without any content.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  (optional) 

            try
            {
                // Get the list of values related to this list name
                UserListOfValuesResponse result = apiInstance.GetUserListOfValues(listName, acceptLanguage, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetUserListOfValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listName** | **string**| The list of value name your want to get | 
 **acceptLanguage** | [**List&lt;string&gt;**](string.md)| Indicates that the client accepts the following languages. | [optional] 
 **ifNoneMatch** | **string**| ETag value to identify the last known version of requested resource.\\ To avoid useless exchange, we recommend you to indicate the ETag you previously got from this operation.\\ If the ETag value does not match the response will be 200 to give you a new content, otherwise the response will be: 304 Not Modified, without any content.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  | [optional] 

### Return type

[**UserListOfValuesResponse**](UserListOfValuesResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserlovindex"></a>
# **GetUserLovIndex**
> UserLovIndex GetUserLovIndex ()

Get all list names

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserLovIndexExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Get all list names
                UserLovIndex result = apiInstance.GetUserLovIndex();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.GetUserLovIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserLovIndex**](UserLovIndex.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="harvestall"></a>
# **HarvestAll**
> void HarvestAll ()

Send harvest request to all your marketplaces

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HarvestAllExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Send harvest request to all your marketplaces
                apiInstance.HarvestAll();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.HarvestAll: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="harvestorder"></a>
# **HarvestOrder**
> void HarvestOrder (string marketplaceTechnicalCode, int? accountId, Guid? beezUPOrderId)

Send harvest request for a single Order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HarvestOrderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // Guid? | The BeezUP Order identifier

            try
            {
                // Send harvest request for a single Order
                apiInstance.HarvestOrder(marketplaceTechnicalCode, accountId, beezUPOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.HarvestOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| The marketplace technical code | 
 **accountId** | **int?**| The account identifier | 
 **beezUPOrderId** | **Guid?**| The BeezUP Order identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationactivateautoimport"></a>
# **ImportationActivateAutoImport**
> void ImportationActivateAutoImport (string storeId)

Activate the auto importation of the last successful manual catalog importation.

Once you have made your fist manual catalog importation with success, you can call this operation to import it automatically. No parameter required, we know which one it is.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationActivateAutoImportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Activate the auto importation of the last successful manual catalog importation.
                apiInstance.ImportationActivateAutoImport(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationActivateAutoImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationcancel"></a>
# **ImportationCancel**
> void ImportationCancel (string storeId, string executionId)

Cancel importation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationCancelExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Cancel importation
                apiInstance.ImportationCancel(storeId, executionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationCancel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationcommit"></a>
# **ImportationCommit**
> void ImportationCommit (string storeId, string executionId)

Commit Importation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationCommitExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Commit Importation
                apiInstance.ImportationCommit(storeId, executionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationCommit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationcommitcolumns"></a>
# **ImportationCommitColumns**
> void ImportationCommitColumns (string storeId, string executionId)

Commit columns

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationCommitColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Commit columns
                apiInstance.ImportationCommitColumns(storeId, executionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationCommitColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationconfigurecatalogcolumn"></a>
# **ImportationConfigureCatalogColumn**
> void ImportationConfigureCatalogColumn (string storeId, string executionId, string columnId, ConfigureCatalogColumnCatalogRequest request)

Configure catalog column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationConfigureCatalogColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier
            var request = new ConfigureCatalogColumnCatalogRequest(); // ConfigureCatalogColumnCatalogRequest | 

            try
            {
                // Configure catalog column
                apiInstance.ImportationConfigureCatalogColumn(storeId, executionId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationConfigureCatalogColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 
 **columnId** | **string**| The custom column identifier | 
 **request** | [**ConfigureCatalogColumnCatalogRequest**](ConfigureCatalogColumnCatalogRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationconfigureremainingcatalogcolumns"></a>
# **ImportationConfigureRemainingCatalogColumns**
> void ImportationConfigureRemainingCatalogColumns (string storeId, string executionId)

Configure remaining catalog columns

This operation should be used after you have mapped the required BeezUP Columns

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationConfigureRemainingCatalogColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Configure remaining catalog columns
                apiInstance.ImportationConfigureRemainingCatalogColumns(storeId, executionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationConfigureRemainingCatalogColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationdeletecustomcolumn"></a>
# **ImportationDeleteCustomColumn**
> void ImportationDeleteCustomColumn (string storeId, string executionId, string columnId)

Delete Custom Column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationDeleteCustomColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Delete Custom Column
                apiInstance.ImportationDeleteCustomColumn(storeId, executionId, columnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationDeleteCustomColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 
 **columnId** | **string**| The custom column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetcustomcolumnexpression"></a>
# **ImportationGetCustomColumnExpression**
> string ImportationGetCustomColumnExpression (string storeId, string executionId, string columnId)

Get the encrypted custom column expression in this importation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetCustomColumnExpressionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Get the encrypted custom column expression in this importation
                string result = apiInstance.ImportationGetCustomColumnExpression(storeId, executionId, columnId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationGetCustomColumnExpression: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 
 **columnId** | **string**| The custom column identifier | 

### Return type

**string**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetcustomcolumns"></a>
# **ImportationGetCustomColumns**
> CustomColumns ImportationGetCustomColumns (string storeId, string executionId)

Get custom columns currently place in this importation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetCustomColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Get custom columns currently place in this importation
                CustomColumns result = apiInstance.ImportationGetCustomColumns(storeId, executionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationGetCustomColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

[**CustomColumns**](CustomColumns.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetdetectedcatalogcolumns"></a>
# **ImportationGetDetectedCatalogColumns**
> DetectedCatalogColumns ImportationGetDetectedCatalogColumns (string storeId, string executionId)

Get detected catalog columns during this importation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetDetectedCatalogColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Get detected catalog columns during this importation.
                DetectedCatalogColumns result = apiInstance.ImportationGetDetectedCatalogColumns(storeId, executionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationGetDetectedCatalogColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

[**DetectedCatalogColumns**](DetectedCatalogColumns.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetimportationmonitoring"></a>
# **ImportationGetImportationMonitoring**
> ImportationMonitoring ImportationGetImportationMonitoring (string storeId, string executionId)

Get the importation status

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetImportationMonitoringExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Get the importation status
                ImportationMonitoring result = apiInstance.ImportationGetImportationMonitoring(storeId, executionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationGetImportationMonitoring: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

[**ImportationMonitoring**](ImportationMonitoring.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetmanualupdatelastinputconfig"></a>
# **ImportationGetManualUpdateLastInputConfig**
> LastManualImportInputConfiguration ImportationGetManualUpdateLastInputConfig (string storeId)

Get the last input configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetManualUpdateLastInputConfigExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get the last input configuration
                LastManualImportInputConfiguration result = apiInstance.ImportationGetManualUpdateLastInputConfig(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationGetManualUpdateLastInputConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**LastManualImportInputConfiguration**](LastManualImportInputConfiguration.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetproductsample"></a>
# **ImportationGetProductSample**
> ProductSample ImportationGetProductSample (string storeId, string executionId, int? productSampleIndex)

Get the product sample related to this importation with all columns (catalog and custom)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetProductSampleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var productSampleIndex = 56;  // int? | Index of the product sample. Starting from 0 to 99.

            try
            {
                // Get the product sample related to this importation with all columns (catalog and custom)
                ProductSample result = apiInstance.ImportationGetProductSample(storeId, executionId, productSampleIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationGetProductSample: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 
 **productSampleIndex** | **int?**| Index of the product sample. Starting from 0 to 99. | 

### Return type

[**ProductSample**](ProductSample.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetproductsamplecustomcolumnvalue"></a>
# **ImportationGetProductSampleCustomColumnValue**
> string ImportationGetProductSampleCustomColumnValue (string storeId, string executionId, int? productSampleIndex, string columnId)

Get product sample custom column value related to this importation.

/!\\ Use this operation only when you just changed the custom column expression and you want to get a precise the property value. Otherwise use the operation Importation_GetProductSample which will give you all property values

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetProductSampleCustomColumnValueExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var productSampleIndex = 56;  // int? | Index of the product sample. Starting from 0 to 99.
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Get product sample custom column value related to this importation.
                string result = apiInstance.ImportationGetProductSampleCustomColumnValue(storeId, executionId, productSampleIndex, columnId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationGetProductSampleCustomColumnValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 
 **productSampleIndex** | **int?**| Index of the product sample. Starting from 0 to 99. | 
 **columnId** | **string**| The custom column identifier | 

### Return type

**string**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetreportings"></a>
# **ImportationGetReportings**
> List<ImportationReporting> ImportationGetReportings (string storeId)

Get the latest catalog importation reporting

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetReportingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get the latest catalog importation reporting
                List&lt;ImportationReporting&gt; result = apiInstance.ImportationGetReportings(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationGetReportings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**List<ImportationReporting>**](ImportationReporting.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationignorecolumn"></a>
# **ImportationIgnoreColumn**
> void ImportationIgnoreColumn (string storeId, string executionId, string columnId)

Ignore Column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationIgnoreColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Ignore Column
                apiInstance.ImportationIgnoreColumn(storeId, executionId, columnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationIgnoreColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 
 **columnId** | **string**| The custom column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationmapcatalogcolumn"></a>
# **ImportationMapCatalogColumn**
> void ImportationMapCatalogColumn (string storeId, string executionId, string columnId, MapBeezUPColumnRequest request)

Map catalog column to a BeezUP column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationMapCatalogColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The catalog column identifier
            var request = new MapBeezUPColumnRequest(); // MapBeezUPColumnRequest | 

            try
            {
                // Map catalog column to a BeezUP column
                apiInstance.ImportationMapCatalogColumn(storeId, executionId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationMapCatalogColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 
 **columnId** | **string**| The catalog column identifier | 
 **request** | [**MapBeezUPColumnRequest**](MapBeezUPColumnRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationmapcustomcolumn"></a>
# **ImportationMapCustomColumn**
> void ImportationMapCustomColumn (string storeId, string executionId, string columnId, MapBeezUPColumnRequest request)

Map custom column to a BeezUP column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationMapCustomColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier
            var request = new MapBeezUPColumnRequest(); // MapBeezUPColumnRequest | 

            try
            {
                // Map custom column to a BeezUP column
                apiInstance.ImportationMapCustomColumn(storeId, executionId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationMapCustomColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 
 **columnId** | **string**| The custom column identifier | 
 **request** | [**MapBeezUPColumnRequest**](MapBeezUPColumnRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationreattendcolumn"></a>
# **ImportationReattendColumn**
> void ImportationReattendColumn (string storeId, string executionId, string columnId)

Reattend Column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationReattendColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Reattend Column
                apiInstance.ImportationReattendColumn(storeId, executionId, columnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationReattendColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 
 **columnId** | **string**| The custom column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationsavecustomcolumn"></a>
# **ImportationSaveCustomColumn**
> void ImportationSaveCustomColumn (string storeId, string executionId, string columnId, ChangeCustomColumnRequest request)

Create or replace a custom column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationSaveCustomColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier
            var request = new ChangeCustomColumnRequest(); // ChangeCustomColumnRequest | 

            try
            {
                // Create or replace a custom column
                apiInstance.ImportationSaveCustomColumn(storeId, executionId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationSaveCustomColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 
 **columnId** | **string**| The custom column identifier | 
 **request** | [**ChangeCustomColumnRequest**](ChangeCustomColumnRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationstartmanualupdate"></a>
# **ImportationStartManualUpdate**
> LinksImportationGetImportationMonitoringLink ImportationStartManualUpdate (string storeId, StartManualImportRequest request)

Start Manual Import

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationStartManualUpdateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new StartManualImportRequest(); // StartManualImportRequest | 

            try
            {
                // Start Manual Import
                LinksImportationGetImportationMonitoringLink result = apiInstance.ImportationStartManualUpdate(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationStartManualUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**StartManualImportRequest**](StartManualImportRequest.md)|  | 

### Return type

[**LinksImportationGetImportationMonitoringLink**](LinksImportationGetImportationMonitoringLink.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationtechnicalprogression"></a>
# **ImportationTechnicalProgression**
> ImportationTechnicalProgression ImportationTechnicalProgression (string storeId, string executionId)

Get technical progression

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationTechnicalProgressionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Get technical progression
                ImportationTechnicalProgression result = apiInstance.ImportationTechnicalProgression(storeId, executionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationTechnicalProgression: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

[**ImportationTechnicalProgression**](ImportationTechnicalProgression.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationunmapcatalogcolumn"></a>
# **ImportationUnmapCatalogColumn**
> void ImportationUnmapCatalogColumn (string storeId, string executionId, string columnId)

Unmap catalog column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationUnmapCatalogColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The catalog column identifier

            try
            {
                // Unmap catalog column
                apiInstance.ImportationUnmapCatalogColumn(storeId, executionId, columnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationUnmapCatalogColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 
 **columnId** | **string**| The catalog column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationunmapcustomcolumn"></a>
# **ImportationUnmapCustomColumn**
> void ImportationUnmapCustomColumn (string storeId, string executionId, string columnId)

Unmap custom column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationUnmapCustomColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Unmap custom column
                apiInstance.ImportationUnmapCustomColumn(storeId, executionId, columnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ImportationUnmapCustomColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 
 **columnId** | **string**| The custom column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="login"></a>
# **Login**
> ApiCredentials Login (LoginRequest request)

Login

User Login - The login will give your tokens

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            
            var apiInstance = new BeezUPApi();
            var request = new LoginRequest(); // LoginRequest | 

            try
            {
                // Login
                ApiCredentials result = apiInstance.Login(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**LoginRequest**](LoginRequest.md)|  | 

### Return type

[**ApiCredentials**](ApiCredentials.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logout"></a>
# **Logout**
> void Logout ()

Log out the current user from go2

Log out the current user from go2

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogoutExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Log out the current user from go2
                apiInstance.Logout();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.Logout: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lostpassword"></a>
# **LostPassword**
> void LostPassword (BeezUPCommonEmail email)

Lost password

Lost password - Your password will be regenerated and sent to your email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LostPasswordExample
    {
        public void main()
        {
            
            var apiInstance = new BeezUPApi();
            var email = new BeezUPCommonEmail(); // BeezUPCommonEmail | Your email

            try
            {
                // Lost password
                apiInstance.LostPassword(email);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.LostPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | [**BeezUPCommonEmail**](BeezUPCommonEmail.md)| Your email | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapchannelcatalogcategory"></a>
# **MapChannelCatalogCategory**
> void MapChannelCatalogCategory (string channelCatalogId, MapCategoryRequest request)

Map channel catalog category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapChannelCatalogCategoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new MapCategoryRequest(); // MapCategoryRequest | 

            try
            {
                // Map channel catalog category
                apiInstance.MapChannelCatalogCategory(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.MapChannelCatalogCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**MapCategoryRequest**](MapCategoryRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapchannelcatalogcolumns"></a>
# **MapChannelCatalogColumns**
> void MapChannelCatalogColumns (string channelCatalogId, ColumnMappingList request)

Configure channel catalog column mappings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapChannelCatalogColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new ColumnMappingList(); // ColumnMappingList | 

            try
            {
                // Configure channel catalog column mappings
                apiInstance.MapChannelCatalogColumns(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.MapChannelCatalogColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**ColumnMappingList**](ColumnMappingList.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movedownrule"></a>
# **MoveDownRule**
> void MoveDownRule (string storeId, string ruleId)

Move the rule down

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MoveDownRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Move the rule down
                apiInstance.MoveDownRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.MoveDownRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="moveuprule"></a>
# **MoveUpRule**
> void MoveUpRule (string storeId, string ruleId)

Move the rule up

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MoveUpRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Move the rule up
                apiInstance.MoveUpRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.MoveUpRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="optimise"></a>
# **Optimise**
> void Optimise (string storeId, string actionName, OptimiseRequest request)

Optimise products

/!\\ WARNING /!\\ \\ Apply the operation on every product related to this request. \\ This operation is used at the bottom of the analytics page result. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OptimiseExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var actionName = actionName_example;  // string | 
            var request = new OptimiseRequest(); // OptimiseRequest | 

            try
            {
                // Optimise products
                apiInstance.Optimise(storeId, actionName, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.Optimise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **actionName** | **string**|  | 
 **request** | [**OptimiseRequest**](OptimiseRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="optimisebycategory"></a>
# **OptimiseByCategory**
> void OptimiseByCategory (string storeId, string catalogCategoryId, string actionName, List<string> request = null)

Optimise products's category

/!\\ WARNING /!\\ \\ This operation will reenable or disable products's category for every channel indicated in the body.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OptimiseByCategoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var catalogCategoryId = catalogCategoryId_example;  // string | The category identifier concerned by this optimisation
            var actionName = actionName_example;  // string | 
            var request = ;  // List<string> | The channel identifier list concerned by this optimisation (optional) 

            try
            {
                // Optimise products's category
                apiInstance.OptimiseByCategory(storeId, catalogCategoryId, actionName, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.OptimiseByCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **catalogCategoryId** | **string**| The category identifier concerned by this optimisation | 
 **actionName** | **string**|  | 
 **request** | **List&lt;string&gt;**| The channel identifier list concerned by this optimisation | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="optimisebychannel"></a>
# **OptimiseByChannel**
> void OptimiseByChannel (string storeId, string channelId, string actionName)

Optimise products's category

/!\\ WARNING /!\\ \\ Apply the operation on every product on this channel. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OptimiseByChannelExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var channelId = channelId_example;  // string | The channel identifier concerned by this optimisation
            var actionName = actionName_example;  // string | 

            try
            {
                // Optimise products's category
                apiInstance.OptimiseByChannel(storeId, channelId, actionName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.OptimiseByChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **channelId** | **string**| The channel identifier concerned by this optimisation | 
 **actionName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="optimisebyproduct"></a>
# **OptimiseByProduct**
> void OptimiseByProduct (string storeId, string productId, string actionName, List<string> request = null)

Optimise products

/!\\ WARNING /!\\ \\ This operation will reenable or disable this product for every channel indicated in the body.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OptimiseByProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var productId = productId_example;  // string | The product identifier concerned by this optimisation
            var actionName = actionName_example;  // string | 
            var request = ;  // List<string> | The channel identifier list concerned by this optimisation (optional) 

            try
            {
                // Optimise products
                apiInstance.OptimiseByProduct(storeId, productId, actionName, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.OptimiseByProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **productId** | **string**| The product identifier concerned by this optimisation | 
 **actionName** | **string**|  | 
 **request** | **List&lt;string&gt;**| The channel identifier list concerned by this optimisation | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="overridechannelcatalogproductoverrides"></a>
# **OverrideChannelCatalogProductOverrides**
> void OverrideChannelCatalogProductOverrides (string channelCatalogId, string productId, ProductOverrides request)

Override channel catalog product values

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OverrideChannelCatalogProductOverridesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var productId = 578419df-1bbf-41a6-96fa-862e42182b67;  // string | The product identifier
            var request = new ProductOverrides(); // ProductOverrides | 

            try
            {
                // Override channel catalog product values
                apiInstance.OverrideChannelCatalogProductOverrides(channelCatalogId, productId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.OverrideChannelCatalogProductOverrides: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **productId** | **string**| The product identifier | 
 **request** | [**ProductOverrides**](ProductOverrides.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactivatecurrentcontract"></a>
# **ReactivateCurrentContract**
> void ReactivateCurrentContract ()

Reactivate your terminated contract.

By calling this operation you can re-enable the auto renewal.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReactivateCurrentContractExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Reactivate your terminated contract.
                apiInstance.ReactivateCurrentContract();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ReactivateCurrentContract: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reenablechannelcatalogproduct"></a>
# **ReenableChannelCatalogProduct**
> void ReenableChannelCatalogProduct (string channelCatalogId, string productId)

Reenable channel catalog product

By default a all your catalog products are exposed to the channel. You can reenable a product by using this operation. /!\\ In case of massive optimisation we recommand you to use the analytics api 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReenableChannelCatalogProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var productId = 578419df-1bbf-41a6-96fa-862e42182b67;  // string | The product identifier

            try
            {
                // Reenable channel catalog product
                apiInstance.ReenableChannelCatalogProduct(channelCatalogId, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ReenableChannelCatalogProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **productId** | **string**| The product identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="register"></a>
# **Register**
> void Register (RegisterRequest request)

User Registration

User Registration - Create a new user on BeezUP

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterExample
    {
        public void main()
        {
            
            var apiInstance = new BeezUPApi();
            var request = new RegisterRequest(); // RegisterRequest | 

            try
            {
                // User Registration
                apiInstance.Register(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.Register: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**RegisterRequest**](RegisterRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resendemailactivation"></a>
# **ResendEmailActivation**
> void ResendEmailActivation ()

Resend email activation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResendEmailActivationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();

            try
            {
                // Resend email activation
                apiInstance.ResendEmailActivation();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.ResendEmailActivation: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runrule"></a>
# **RunRule**
> void RunRule (string storeId, string ruleId)

Run rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RunRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Run rule
                apiInstance.RunRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.RunRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runrules"></a>
# **RunRules**
> void RunRules (string storeId)

Run all rules for this store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RunRulesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Run all rules for this store
                apiInstance.RunRules(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.RunRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savecompanyinfo"></a>
# **SaveCompanyInfo**
> void SaveCompanyInfo (CompanyInfo request)

Change company information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveCompanyInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new CompanyInfo(); // CompanyInfo | 

            try
            {
                // Change company information
                apiInstance.SaveCompanyInfo(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.SaveCompanyInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CompanyInfo**](CompanyInfo.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savecreditcardinfo"></a>
# **SaveCreditCardInfo**
> void SaveCreditCardInfo (CreditCardInfo request)

Save user credit card info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveCreditCardInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new CreditCardInfo(); // CreditCardInfo | Credit card info

            try
            {
                // Save user credit card info
                apiInstance.SaveCreditCardInfo(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.SaveCreditCardInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreditCardInfo**](CreditCardInfo.md)| Credit card info | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savepersonalinfo"></a>
# **SavePersonalInfo**
> void SavePersonalInfo (PersonalInfo request)

Save user personal information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SavePersonalInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new PersonalInfo(); // PersonalInfo | 

            try
            {
                // Save user personal information
                apiInstance.SavePersonalInfo(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.SavePersonalInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PersonalInfo**](PersonalInfo.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveprofilepictureinfo"></a>
# **SaveProfilePictureInfo**
> void SaveProfilePictureInfo (ProfilePictureInfo request)

Change user picture information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveProfilePictureInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new ProfilePictureInfo(); // ProfilePictureInfo | 

            try
            {
                // Change user picture information
                apiInstance.SaveProfilePictureInfo(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.SaveProfilePictureInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ProfilePictureInfo**](ProfilePictureInfo.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savereportfilter"></a>
# **SaveReportFilter**
> void SaveReportFilter (string storeId, string reportFilterId, SaveReportFilterRequest reportFilter)

Save the report filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveReportFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var reportFilterId = reportFilterId_example;  // string | Your report filter identifier
            var reportFilter = new SaveReportFilterRequest(); // SaveReportFilterRequest | 

            try
            {
                // Save the report filter
                apiInstance.SaveReportFilter(storeId, reportFilterId, reportFilter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.SaveReportFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **reportFilterId** | **string**| Your report filter identifier | 
 **reportFilter** | [**SaveReportFilterRequest**](SaveReportFilterRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savestorealert"></a>
# **SaveStoreAlert**
> void SaveStoreAlert (string storeId, int? alertId, List<SaveStoreAlertRequest> request)

Save store alert

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveStoreAlertExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var alertId = 56;  // int? | 
            var request = new List<SaveStoreAlertRequest>(); // List<SaveStoreAlertRequest> | 

            try
            {
                // Save store alert
                apiInstance.SaveStoreAlert(storeId, alertId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.SaveStoreAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **alertId** | **int?**|  | 
 **request** | [**List&lt;SaveStoreAlertRequest&gt;**](SaveStoreAlertRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setchannelcatalogmarketplacesettings"></a>
# **SetChannelCatalogMarketplaceSettings**
> void SetChannelCatalogMarketplaceSettings (string channelCatalogId, SetChannelCatalogMarketplaceSettingsRequest model)

Save new marketplace settings for a channel catalog

Allow you to configure your marketplace settings.  Partial update accepted. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetChannelCatalogMarketplaceSettingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = channelCatalogId_example;  // string | Channel Catalog Id to query
            var model = new SetChannelCatalogMarketplaceSettingsRequest(); // SetChannelCatalogMarketplaceSettingsRequest | Settings to save

            try
            {
                // Save new marketplace settings for a channel catalog
                apiInstance.SetChannelCatalogMarketplaceSettings(channelCatalogId, model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.SetChannelCatalogMarketplaceSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| Channel Catalog Id to query | 
 **model** | [**SetChannelCatalogMarketplaceSettingsRequest**](SetChannelCatalogMarketplaceSettingsRequest.md)| Settings to save | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmerchantorderinfo"></a>
# **SetMerchantOrderInfo**
> void SetMerchantOrderInfo (string marketplaceTechnicalCode, int? accountId, Guid? beezUPOrderId, SetMerchantOrderInfoRequest request)

Set an Order's merchant information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetMerchantOrderInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // Guid? | The BeezUP Order identifier
            var request = new SetMerchantOrderInfoRequest(); // SetMerchantOrderInfoRequest | 

            try
            {
                // Set an Order's merchant information
                apiInstance.SetMerchantOrderInfo(marketplaceTechnicalCode, accountId, beezUPOrderId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.SetMerchantOrderInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| The marketplace technical code | 
 **accountId** | **int?**| The account identifier | 
 **beezUPOrderId** | **Guid?**| The BeezUP Order identifier | 
 **request** | [**SetMerchantOrderInfoRequest**](SetMerchantOrderInfoRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmerchantorderinfolist"></a>
# **SetMerchantOrderInfoList**
> BatchOrderOperationResponse SetMerchantOrderInfoList (SetMerchantOrderInfoListRequest request)

Send a batch of operations to set an Order's merchant information

The purpose of this operation is to reduce the amount of request to the API.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetMerchantOrderInfoListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new SetMerchantOrderInfoListRequest(); // SetMerchantOrderInfoListRequest | 

            try
            {
                // Send a batch of operations to set an Order's merchant information
                BatchOrderOperationResponse result = apiInstance.SetMerchantOrderInfoList(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.SetMerchantOrderInfoList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SetMerchantOrderInfoListRequest**](SetMerchantOrderInfoListRequest.md)|  | 

### Return type

[**BatchOrderOperationResponse**](BatchOrderOperationResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="share"></a>
# **Share**
> void Share (string storeId, FriendEmail email)

Share a store to another user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShareExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var email = new FriendEmail(); // FriendEmail | Your friend's email

            try
            {
                // Share a store to another user
                apiInstance.Share(storeId, email);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.Share: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **email** | [**FriendEmail**](FriendEmail.md)| Your friend&#39;s email | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terminatecurrentcontract"></a>
# **TerminateCurrentContract**
> void TerminateCurrentContract (TerminateContract request)

Schedule termination of your current contract at the end of the commitment.

By default your contract are automatically renew. By calling this operation you can disable the auto renewal.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TerminateCurrentContractExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var request = new TerminateContract(); // TerminateContract | Indicate the termination reason

            try
            {
                // Schedule termination of your current contract at the end of the commitment.
                apiInstance.TerminateCurrentContract(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.TerminateCurrentContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TerminateContract**](TerminateContract.md)| Indicate the termination reason | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unmapchannelcatalogcategory"></a>
# **UnmapChannelCatalogCategory**
> void UnmapChannelCatalogCategory (string channelCatalogId, UnmapCategoryRequest request)

Unmap channel catalog category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UnmapChannelCatalogCategoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new UnmapCategoryRequest(); // UnmapCategoryRequest | 

            try
            {
                // Unmap channel catalog category
                apiInstance.UnmapChannelCatalogCategory(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.UnmapChannelCatalogCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**UnmapCategoryRequest**](UnmapCategoryRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterule"></a>
# **UpdateRule**
> void UpdateRule (string storeId, string ruleId, UpdateRuleRequest request)

Update Rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier
            var request = new UpdateRuleRequest(); // UpdateRuleRequest | 

            try
            {
                // Update Rule
                apiInstance.UpdateRule(storeId, ruleId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.UpdateRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 
 **request** | [**UpdateRuleRequest**](UpdateRuleRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestore"></a>
# **UpdateStore**
> void UpdateStore (string storeId, UpdateStoreRequest request)

Update some store's information.

Update some store's information. FYI, you cannot change the country. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateStoreExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new BeezUPApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new UpdateStoreRequest(); // UpdateStoreRequest | 

            try
            {
                // Update some store's information.
                apiInstance.UpdateStore(storeId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeezUPApi.UpdateStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**UpdateStoreRequest**](UpdateStoreRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

