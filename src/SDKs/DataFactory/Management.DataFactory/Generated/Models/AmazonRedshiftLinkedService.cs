// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Linked service for Amazon Redshift.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AmazonRedshift")]
    [Rest.Serialization.JsonTransformation]
    public partial class AmazonRedshiftLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the AmazonRedshiftLinkedService
        /// class.
        /// </summary>
        public AmazonRedshiftLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AmazonRedshiftLinkedService
        /// class.
        /// </summary>
        /// <param name="server">The name of the Amazon Redshift server. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="database">The database name of the Amazon Redshift
        /// source. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="username">The username of the Amazon Redshift source.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="password">The password of the Amazon Redshift
        /// source.</param>
        /// <param name="port">The TCP port number that the Amazon Redshift
        /// server uses to listen for client connections. The default value is
        /// 5439. Type: integer (or Expression with resultType
        /// integer).</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public AmazonRedshiftLinkedService(object server, object database, IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), object username = default(object), SecureString password = default(SecureString), object port = default(object), object encryptedCredential = default(object))
            : base(connectVia, description)
        {
            Server = server;
            Username = username;
            Password = password;
            Database = database;
            Port = port;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Amazon Redshift server. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.server")]
        public object Server { get; set; }

        /// <summary>
        /// Gets or sets the username of the Amazon Redshift source. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets the password of the Amazon Redshift source.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecureString Password { get; set; }

        /// <summary>
        /// Gets or sets the database name of the Amazon Redshift source. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.database")]
        public object Database { get; set; }

        /// <summary>
        /// Gets or sets the TCP port number that the Amazon Redshift server
        /// uses to listen for client connections. The default value is 5439.
        /// Type: integer (or Expression with resultType integer).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.port")]
        public object Port { get; set; }

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
            if (Server == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Server");
            }
            if (Database == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Database");
            }
            if (Password != null)
            {
                Password.Validate();
            }
        }
    }
}