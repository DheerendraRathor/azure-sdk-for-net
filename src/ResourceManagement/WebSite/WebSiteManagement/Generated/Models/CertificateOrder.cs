// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Certificate purchase order
    /// </summary>
    public partial class CertificateOrder : Resource
    {
        /// <summary>
        /// State of the Key Vault secret
        /// </summary>
        [JsonProperty(PropertyName = "properties.certificates")]
        public IDictionary<string, CertificateOrderCertificate> Certificates { get; set; }

        /// <summary>
        /// Certificate distinguished name
        /// </summary>
        [JsonProperty(PropertyName = "properties.distinguishedName")]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// Domain Verification Token
        /// </summary>
        [JsonProperty(PropertyName = "properties.domainVerificationToken")]
        public string DomainVerificationToken { get; set; }

        /// <summary>
        /// Duration in years (must be between 1 and 3)
        /// </summary>
        [JsonProperty(PropertyName = "properties.validityInYears")]
        public int? ValidityInYears { get; set; }

        /// <summary>
        /// Certificate Key Size
        /// </summary>
        [JsonProperty(PropertyName = "properties.keySize")]
        public int? KeySize { get; set; }

        /// <summary>
        /// Certificate product type. Possible values for this property
        /// include: 'StandardDomainValidatedSsl',
        /// 'StandardDomainValidatedWildCardSsl'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productType")]
        public CertificateProductType? ProductType { get; set; }

        /// <summary>
        /// Current order status. Possible values for this property include:
        /// 'Pendingissuance', 'Issued', 'Revoked', 'Canceled', 'Denied',
        /// 'Pendingrevocation', 'PendingRekey', 'Unused', 'Expired',
        /// 'NotSubmitted'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public CertificateOrderStatus? Status { get; set; }

        /// <summary>
        /// Signed certificate
        /// </summary>
        [JsonProperty(PropertyName = "properties.signedCertificate")]
        public string SignedCertificate { get; set; }

        /// <summary>
        /// Last CSR that was created for this order
        /// </summary>
        [JsonProperty(PropertyName = "properties.csr")]
        public string Csr { get; set; }

        /// <summary>
        /// Intermediate certificate
        /// </summary>
        [JsonProperty(PropertyName = "properties.intermediate")]
        public string Intermediate { get; set; }

        /// <summary>
        /// Root certificate
        /// </summary>
        [JsonProperty(PropertyName = "properties.root")]
        public string Root { get; set; }

        /// <summary>
        /// Current serial number of the certificate
        /// </summary>
        [JsonProperty(PropertyName = "properties.serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Requested action on existing certificate order. Possible values
        /// for this property include: 'Rekey', 'Renew'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.action")]
        public CertificateAction? Action { get; set; }

        /// <summary>
        /// Key Vault Csm resource Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultCsmId")]
        public string KeyVaultCsmId { get; set; }

        /// <summary>
        /// Delay in hours to revoke existing certificate after the new
        /// certificate is issued
        /// </summary>
        [JsonProperty(PropertyName = "properties.delayExistingRevokeInHours")]
        public int? DelayExistingRevokeInHours { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.Certificates != null)
            {
                foreach (var valueElement in this.Certificates.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
        }
    }
}
