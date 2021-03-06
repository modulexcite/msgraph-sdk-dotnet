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
    /// The type WorkbookFunctionsRandBetweenRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsRandBetweenRequestBody
    {
    
        /// <summary>
        /// Gets or sets Bottom.
        /// </summary>
        [DataMember(Name = "bottom", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Bottom { get; set; }
    
        /// <summary>
        /// Gets or sets Top.
        /// </summary>
        [DataMember(Name = "top", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Top { get; set; }
    
    }
}
