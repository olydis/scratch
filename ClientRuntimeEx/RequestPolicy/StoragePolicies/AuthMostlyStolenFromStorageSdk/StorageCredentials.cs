//-----------------------------------------------------------------------
// <copyright file="StorageCredentials.cs" company="Microsoft">
//    Copyright 2013 Microsoft Corporation
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//      http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using BlobStorageTest.Authentication;
using Microsoft.Rest;

namespace Microsoft.WindowsAzure.Storage.Auth
{
    using Microsoft.WindowsAzure.Storage.Core;
    using Microsoft.WindowsAzure.Storage.Core.Util;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    /// <summary>
    /// Represents a set of credentials used to authenticate access to a Microsoft Azure storage account.
    /// </summary>
    public sealed class StorageCredentials
    {
        private SasQueryBuilder queryBuilder;

        /// <summary>
        /// Gets the associated shared access signature token for the credentials.
        /// </summary>
        /// <value>The shared access signature token.</value>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SAS", Justification = "Back compatibility.")]
        public string SASToken { get; private set; }

        /// <summary>
        /// Gets the associated account name for the credentials.
        /// </summary>
        /// <value>The account name.</value>
        public string AccountName { get; private set; }

        /// <summary>
        /// Gets the associated key name for the credentials.
        /// </summary>
        /// <value>The key name.</value>
        public string KeyName => this.Key.KeyName; 

        internal StorageAccountKey Key { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the credentials are for anonymous access.
        /// </summary>
        /// <value><c>true</c> if the credentials are for anonymous access; otherwise, <c>false</c>.</value>
        public bool IsAnonymous => (this.SASToken == null) && (this.AccountName == null);

        /// <summary>
        /// Gets a value indicating whether the credentials are a shared access signature token.
        /// </summary>
        /// <value><c>true</c> if the credentials are a shared access signature token; otherwise, <c>false</c>.</value>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SAS", Justification = "Back compatibility.")]
        public bool IsSAS => this.SASToken != null;

        /// <summary>
        /// Gets a value indicating whether the credentials are a shared key.
        /// </summary>
        /// <value><c>true</c> if the credentials are a shared key; otherwise, <c>false</c>.</value>
        public bool IsSharedKey => (this.SASToken == null) && (this.AccountName != null);

        /// <summary>
        /// Gets the value of the shared access signature token's <code>sig</code> parameter.
        /// </summary>
        public string SASSignature => this.IsSAS
            ? this.queryBuilder["sig"]
            : null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageCredentials"/> class.
        /// </summary>
        public StorageCredentials()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageCredentials"/> class with the specified account name and key value.
        /// </summary>
        /// <param name="accountName">A string that represents the name of the storage account.</param>
        /// <param name="keyValue">A string that represents the Base64-encoded account access key.</param>
        public StorageCredentials(string accountName, string keyValue)
            : this(accountName, keyValue, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageCredentials"/> class with the specified account name, key value, and key name.
        /// </summary>
        /// <param name="accountName">A string that represents the name of the storage account.</param>
        /// <param name="keyValue">A string that represents the Base64-encoded account access key.</param>
        /// <param name="keyName">A string that represents the name of the key.</param>
        public StorageCredentials(string accountName, string keyValue, string keyName)
        {
            this.AccountName = accountName;
            this.UpdateKey(keyValue, keyName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageCredentials"/> class with the specified shared access signature token.
        /// </summary>
        /// <param name="sasToken">A string representing the shared access signature token.</param>
        public StorageCredentials(string sasToken)
        {
            this.SASToken = sasToken;
            this.UpdateQueryBuilder();
        }

        /// <summary>
        /// Updates the key value for the credentials.
        /// </summary>
        /// <param name="keyValue">The key value, as a Base64-encoded string, to update.</param>
        public void UpdateKey(string keyValue)
        {
            this.UpdateKey(keyValue, null);
        }

        /// <summary>
        /// Updates the key value and key name for the credentials.
        /// </summary>
        /// <param name="keyValue">The key value, as a Base64-encoded string, to update.</param>
        /// <param name="keyName">The key name to update.</param>
        public void UpdateKey(string keyValue, string keyName)
        {
            if (!this.IsSharedKey)
            {
                string errorMessage = string.Format(CultureInfo.CurrentCulture, "Cannot update key unless Account Key credentials are used.");
                throw new InvalidOperationException(errorMessage);
            }
            
            this.Key = new StorageAccountKey(keyName, Convert.FromBase64String(keyValue));
        }
        
        /// <summary>
        /// Updates the key value and key name for the credentials.
        /// </summary>
        /// <param name="keyValue">The key value, as an array of bytes, to update.</param>
        /// <param name="keyName">The key name to update.</param>
        public void UpdateKey(byte[] keyValue, string keyName)
        {
            if (!this.IsSharedKey)
            {
                string errorMessage = string.Format(CultureInfo.CurrentCulture, "Cannot update key unless Account Key credentials are used.");
                throw new InvalidOperationException(errorMessage);
            }
            
            this.Key = new StorageAccountKey(keyName, keyValue);
        }

        /// <summary>
        /// Updates the shared access signature (SAS) token value for storage credentials created with a shared access signature.
        /// </summary>
        /// <param name="sasToken">A string that specifies the SAS token value to update.</param>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SAS", Justification = "Back compatibility.")]
        public void UpdateSASToken(string sasToken)
        {
            if (!this.IsSAS)
            {
                string errorMessage = string.Format(CultureInfo.CurrentCulture, "Cannot update Shared Access Signature unless Sas credentials are used.");
                throw new InvalidOperationException(errorMessage);
            }
            
            this.SASToken = sasToken;
            this.UpdateQueryBuilder();
        }
        
        /// <summary>
        /// Returns the account key for the credentials.
        /// </summary>
        /// <returns>An array of bytes that contains the key.</returns>
        public byte[] ExportKey()
        {
            return (byte[])this.Key.KeyValue.Clone();
        }

        /// <summary>
        /// Transforms a resource URI into a shared access signature URI, by appending a shared access token.
        /// </summary>
        /// <param name="resourceUri">A <see cref="System.Uri"/> object that represents the resource URI to be transformed.</param>
        /// <returns>A <see cref="System.Uri"/> object that represents the signature, including the resource URI and the shared access token.</returns>
        public Uri TransformUri(Uri resourceUri)
        {
            if (this.IsSAS)
            {
                return this.queryBuilder.AddToUri(resourceUri);
            }
            else
            {
                return resourceUri;
            }
        }

        /// <summary>
        /// Transforms a resource URI into a shared access signature URI, by appending a shared access token.
        /// </summary>
        /// <param name="resourceUri">A <see cref="StorageUri"/> object that represents the resource URI to be transformed.</param>
        /// <returns>A <see cref="StorageUri"/> object that represents the signature, including the resource URI and the shared access token.</returns>
        public StorageUri TransformUri(StorageUri resourceUri)
        {
            return new StorageUri(
                this.TransformUri(resourceUri.PrimaryUri),
                this.TransformUri(resourceUri.SecondaryUri));
        }

        /// <summary>
        /// Exports the value of the account access key to a Base64-encoded string.
        /// </summary>
        /// <returns>The account access key.</returns>
        public string ExportBase64EncodedKey()
        {
            StorageAccountKey thisAccountKey = this.Key;
            return GetBase64EncodedKey(thisAccountKey);
        }

        private static string GetBase64EncodedKey(StorageAccountKey accountKey)
        {
            return (accountKey.KeyValue == null) ? null : Convert.ToBase64String(accountKey.KeyValue);
        }

        internal string ToString(bool exportSecrets)
        {
            if (this.IsSharedKey)
            {
                return $"AccountName={AccountName};AccountKey={(exportSecrets ? this.ExportBase64EncodedKey() : "[key hidden]")}";
            }

            if (this.IsSAS)
            {
                return $"SharedAccessSignature={(exportSecrets ? this.SASToken : "[signature hidden]")}";
            }

            return string.Empty;
        }

        /// <summary>
        /// Determines whether an other <see cref="StorageCredentials"/> object is equal to this one by comparing their SAS tokens, account names, key names, and key values.
        /// </summary>
        /// <param name="other">The <see cref="StorageCredentials"/> object to compare to this one.</param>
        /// <returns><c>true</c> if the two <see cref="StorageCredentials"/> objects are equal; otherwise, <c>false</c>.</returns>
        public bool Equals(StorageCredentials other)
        {
            if (other == null)
            {
                return false;
            }

            StorageAccountKey thisAccountKey = this.Key;
            StorageAccountKey otherAccountKey = other.Key;

            return string.Equals(this.SASToken, other.SASToken) &&
                string.Equals(this.AccountName, other.AccountName) &&
                string.Equals(thisAccountKey.KeyName, otherAccountKey.KeyName) &&
                string.Equals(GetBase64EncodedKey(thisAccountKey), GetBase64EncodedKey(otherAccountKey));
        }

        private void UpdateQueryBuilder()
        {
            SasQueryBuilder newQueryBuilder = new SasQueryBuilder(this.SASToken);

            newQueryBuilder.Add("api-version", "2016-05-31");
            // TODO: draw from StorageCredentials? otherwise, how would it get here from the swagger...

            this.queryBuilder = newQueryBuilder;
        }


        public Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.Headers.Date == null)
            {
                request.Headers.Date = DateTimeOffset.UtcNow;
            }

            if (!string.IsNullOrEmpty(Key.KeyName))
            {
                request.Headers.Add("x-ms-key-name", Key.KeyName);
            }

            string message = Utility.CanonicalizeHttpRequest(request, AccountName);
            string signature = Utility.ComputeHmac256(Key.KeyValue, message);

            request.Headers.Authorization = new AuthenticationHeaderValue("SharedKey", $"{AccountName}:{signature}");

            return Task.FromResult(0);
        }
    }
}
