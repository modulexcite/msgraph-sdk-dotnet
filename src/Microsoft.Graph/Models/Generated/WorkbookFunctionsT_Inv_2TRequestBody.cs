// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsT_Inv_2TRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsT_Inv_2TRequestBody
    {
    
        /// <summary>
        /// Gets or sets Probability.
        /// </summary>
        [DataMember(Name = "probability", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Probability { get; set; }
    
        /// <summary>
        /// Gets or sets DegFreedom.
        /// </summary>
        [DataMember(Name = "degFreedom", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken DegFreedom { get; set; }
    
    }
}
