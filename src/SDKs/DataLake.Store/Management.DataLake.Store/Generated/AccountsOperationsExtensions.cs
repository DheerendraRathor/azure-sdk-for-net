// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AccountsOperations.
    /// </summary>
    public static partial class AccountsOperationsExtensions
    {
            /// <summary>
            /// Lists the Data Lake Store accounts within the subscription. The response
            /// includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// The Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            public static IPage<DataLakeStoreAccountBasic> List(this IAccountsOperations operations, ODataQuery<DataLakeStoreAccountBasic> odataQuery = default(ODataQuery<DataLakeStoreAccountBasic>), string select = default(string), bool? count = default(bool?))
            {
                return operations.ListAsync(odataQuery, select, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake Store accounts within the subscription. The response
            /// includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// The Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataLakeStoreAccountBasic>> ListAsync(this IAccountsOperations operations, ODataQuery<DataLakeStoreAccountBasic> odataQuery = default(ODataQuery<DataLakeStoreAccountBasic>), string select = default(string), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, select, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the Data Lake Store accounts within a specific resource group. The
            /// response includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// A Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            public static IPage<DataLakeStoreAccountBasic> ListByResourceGroup(this IAccountsOperations operations, string resourceGroupName, ODataQuery<DataLakeStoreAccountBasic> odataQuery = default(ODataQuery<DataLakeStoreAccountBasic>), string select = default(string), bool? count = default(bool?))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, odataQuery, select, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake Store accounts within a specific resource group. The
            /// response includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// A Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataLakeStoreAccountBasic>> ListByResourceGroupAsync(this IAccountsOperations operations, string resourceGroupName, ODataQuery<DataLakeStoreAccountBasic> odataQuery = default(ODataQuery<DataLakeStoreAccountBasic>), string select = default(string), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, odataQuery, select, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create the Data Lake Store account.
            /// </param>
            public static DataLakeStoreAccount Create(this IAccountsOperations operations, string resourceGroupName, string accountName, CreateDataLakeStoreAccountParameters parameters)
            {
                return operations.CreateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create the Data Lake Store account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataLakeStoreAccount> CreateAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CreateDataLakeStoreAccountParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            public static DataLakeStoreAccount Get(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return operations.GetAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataLakeStoreAccount> GetAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the specified Data Lake Store account information.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update the Data Lake Store account.
            /// </param>
            public static DataLakeStoreAccount Update(this IAccountsOperations operations, string resourceGroupName, string accountName, UpdateDataLakeStoreAccountParameters parameters)
            {
                return operations.UpdateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the specified Data Lake Store account information.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update the Data Lake Store account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataLakeStoreAccount> UpdateAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, UpdateDataLakeStoreAccountParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            public static void Delete(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                operations.DeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Attempts to enable a user managed Key Vault for encryption of the specified
            /// Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            public static void EnableKeyVault(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                operations.EnableKeyVaultAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Attempts to enable a user managed Key Vault for encryption of the specified
            /// Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task EnableKeyVaultAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.EnableKeyVaultWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Checks whether the specified account name is available or taken.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The resource location without whitespace.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to check the Data Lake Store account name availability.
            /// </param>
            public static NameAvailabilityInformation CheckNameAvailability(this IAccountsOperations operations, string location, CheckNameAvailabilityParameters parameters)
            {
                return operations.CheckNameAvailabilityAsync(location, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks whether the specified account name is available or taken.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The resource location without whitespace.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to check the Data Lake Store account name availability.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NameAvailabilityInformation> CheckNameAvailabilityAsync(this IAccountsOperations operations, string location, CheckNameAvailabilityParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(location, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create the Data Lake Store account.
            /// </param>
            public static DataLakeStoreAccount BeginCreate(this IAccountsOperations operations, string resourceGroupName, string accountName, CreateDataLakeStoreAccountParameters parameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create the Data Lake Store account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataLakeStoreAccount> BeginCreateAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CreateDataLakeStoreAccountParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the specified Data Lake Store account information.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update the Data Lake Store account.
            /// </param>
            public static DataLakeStoreAccount BeginUpdate(this IAccountsOperations operations, string resourceGroupName, string accountName, UpdateDataLakeStoreAccountParameters parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the specified Data Lake Store account information.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update the Data Lake Store account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataLakeStoreAccount> BeginUpdateAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, UpdateDataLakeStoreAccountParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            public static void BeginDelete(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                operations.BeginDeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists the Data Lake Store accounts within the subscription. The response
            /// includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DataLakeStoreAccountBasic> ListNext(this IAccountsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake Store accounts within the subscription. The response
            /// includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataLakeStoreAccountBasic>> ListNextAsync(this IAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the Data Lake Store accounts within a specific resource group. The
            /// response includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DataLakeStoreAccountBasic> ListByResourceGroupNext(this IAccountsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake Store accounts within a specific resource group. The
            /// response includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataLakeStoreAccountBasic>> ListByResourceGroupNextAsync(this IAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
