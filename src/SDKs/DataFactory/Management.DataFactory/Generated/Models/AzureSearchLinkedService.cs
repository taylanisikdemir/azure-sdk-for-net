// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Linked service for Windows Azure Search Service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureSearch")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureSearchLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the AzureSearchLinkedService class.
        /// </summary>
        public AzureSearchLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSearchLinkedService class.
        /// </summary>
        /// <param name="url">URL for Azure Search service. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="key">Admin Key for Azure Search service</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public AzureSearchLinkedService(object url, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), SecureString key = default(SecureString), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description)
        {
            Url = url;
            Key = key;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URL for Azure Search service. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets admin Key for Azure Search service
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.key")]
        public SecureString Key { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
            if (Key != null)
            {
                Key.Validate();
            }
        }
    }
}
