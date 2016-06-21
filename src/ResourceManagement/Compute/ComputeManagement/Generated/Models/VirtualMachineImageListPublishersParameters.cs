// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Contains the parameters required to list publishers.
    /// </summary>
    public partial class VirtualMachineImageListPublishersParameters
    {
        private string _location;
        
        /// <summary>
        /// Required. Location of the PIR, used for orchestration and required
        /// by CSM to direct request to appropriate PIR region. Example:
        /// westus, eastus.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineImageListPublishersParameters class.
        /// </summary>
        public VirtualMachineImageListPublishersParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineImageListPublishersParameters class with required
        /// arguments.
        /// </summary>
        public VirtualMachineImageListPublishersParameters(string location)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.Location = location;
        }
    }
}