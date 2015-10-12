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
    /// Description of an hostingEnvironment (App Service Environment)
    /// </summary>
    public partial class HostingEnvironment : Resource
    {
        /// <summary>
        /// Name of the hostingEnvironment (App Service Environment)
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string HostingEnvironmentName { get; set; }

        /// <summary>
        /// Location of the hostingEnvironment (App Service Environment), e.g.
        /// "West US"
        /// </summary>
        [JsonProperty(PropertyName = "properties.location")]
        public string HostingEnvironmentLocation { get; set; }

        /// <summary>
        /// Current status of the hostingEnvironment (App Service
        /// Environment). Possible values for this property include:
        /// 'Preparing', 'Ready', 'Scaling', 'Deleting'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public HostingEnvironmentStatus? Status { get; set; }

        /// <summary>
        /// Name of the hostingEnvironment's (App Service Environment) virtual
        /// network
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// Resource group of the hostingEnvironment's (App Service
        /// Environment) virtual network
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetResourceGroupName")]
        public string VnetResourceGroupName { get; set; }

        /// <summary>
        /// Subnet of the hostingEnvironment's (App Service Environment)
        /// virtual network
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetSubnetName")]
        public string VnetSubnetName { get; set; }

        /// <summary>
        /// Description of the hostingEnvironment's (App Service Environment)
        /// virtual network
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetwork")]
        public VirtualNetworkProfile VirtualNetwork { get; set; }

        /// <summary>
        /// Specifies which endpoints to serve internally in the
        /// hostingEnvironment's (App Service Environment) VNET. Possible
        /// values for this property include: 'None', 'Web', 'Publishing'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.internalLoadBalancingMode")]
        public InternalLoadBalancingMode? InternalLoadBalancingMode { get; set; }

        /// <summary>
        /// Front-end VM size, e.g. "Medium", "Large"
        /// </summary>
        [JsonProperty(PropertyName = "properties.multiSize")]
        public string MultiSize { get; set; }

        /// <summary>
        /// Number of front-end instances
        /// </summary>
        [JsonProperty(PropertyName = "properties.multiRoleCount")]
        public int? MultiRoleCount { get; set; }

        /// <summary>
        /// Description of worker pools with worker size ids, VM sizes, and
        /// number of workers in each pool
        /// </summary>
        [JsonProperty(PropertyName = "properties.workerPools")]
        public IList<WorkerPool> WorkerPools { get; set; }

        /// <summary>
        /// Number of IP SSL addresses reserved for this hostingEnvironment
        /// (App Service Environment)
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipsslAddressCount")]
        public int? IpsslAddressCount { get; set; }

        /// <summary>
        /// Edition of the metadata database for the hostingEnvironment (App
        /// Service Environment) e.g. "Standard"
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseEdition")]
        public string DatabaseEdition { get; set; }

        /// <summary>
        /// Service objective of the metadata database for the
        /// hostingEnvironment (App Service Environment) e.g. "S0"
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseServiceObjective")]
        public string DatabaseServiceObjective { get; set; }

        /// <summary>
        /// Number of upgrade domains of this hostingEnvironment (App Service
        /// Environment)
        /// </summary>
        [JsonProperty(PropertyName = "properties.upgradeDomains")]
        public int? UpgradeDomains { get; set; }

        /// <summary>
        /// Subscription of the hostingEnvironment (App Service Environment)
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// DNS suffix of the hostingEnvironment (App Service Environment)
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSuffix")]
        public string DnsSuffix { get; set; }

        /// <summary>
        /// Last deployment action on this hostingEnvironment (App Service
        /// Environment)
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastAction")]
        public string LastAction { get; set; }

        /// <summary>
        /// Result of the last deployment action on this hostingEnvironment
        /// (App Service Environment)
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastActionResult")]
        public string LastActionResult { get; set; }

        /// <summary>
        /// List of comma separated strings describing which VM sizes are
        /// allowed for front-ends
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedMultiSizes")]
        public string AllowedMultiSizes { get; set; }

        /// <summary>
        /// List of comma separated strings describing which VM sizes are
        /// allowed for workers
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedWorkerSizes")]
        public string AllowedWorkerSizes { get; set; }

        /// <summary>
        /// Maximum number of VMs in this hostingEnvironment (App Service
        /// Environment)
        /// </summary>
        [JsonProperty(PropertyName = "properties.maximumNumberOfMachines")]
        public int? MaximumNumberOfMachines { get; set; }

        /// <summary>
        /// Description of IP SSL mapping for this hostingEnvironment (App
        /// Service Environment)
        /// </summary>
        [JsonProperty(PropertyName = "properties.vipMappings")]
        public IList<VirtualIPMapping> VipMappings { get; set; }

        /// <summary>
        /// Current total, used, and available worker capacities
        /// </summary>
        [JsonProperty(PropertyName = "properties.environmentCapacities")]
        public IList<StampCapacity> EnvironmentCapacities { get; set; }

        /// <summary>
        /// Access control list for controlling traffic to the
        /// hostingEnvironment (App Service Environment)
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAccessControlList")]
        public IList<NetworkAccessControlEntry> NetworkAccessControlList { get; set; }

        /// <summary>
        /// True/false indicating whether the hostingEnvironment (App Service
        /// Environment) is healthy
        /// </summary>
        [JsonProperty(PropertyName = "properties.environmentIsHealthy")]
        public bool? EnvironmentIsHealthy { get; set; }

        /// <summary>
        /// Detailed message about with results of the last check of the
        /// hostingEnvironment (App Service Environment)
        /// </summary>
        [JsonProperty(PropertyName = "properties.environmentStatus")]
        public string EnvironmentStatus { get; set; }

        /// <summary>
        /// Resource group of the hostingEnvironment (App Service Environment)
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroup")]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// Api Management Account associated with this Hosting Environment
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiManagementAccountId")]
        public string ApiManagementAccountId { get; set; }

        /// <summary>
        /// True/false indicating whether the hostingEnvironment is suspended.
        /// The environment can be suspended e.g. when the management
        /// endpoint is no longer available
        /// (most likely because NSG blocked the incoming traffic)
        /// </summary>
        [JsonProperty(PropertyName = "properties.suspended")]
        public bool? Suspended { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.WorkerPools != null)
            {
                foreach (var element in this.WorkerPools)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
