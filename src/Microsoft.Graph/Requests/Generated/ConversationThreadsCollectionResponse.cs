// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ConversationThreadsCollectionResponse.
    /// </summary>
    [DataContract]
    public class ConversationThreadsCollectionResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IConversationThreadsCollectionPage"/> value.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = false)]
        public IConversationThreadsCollectionPage Value { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
