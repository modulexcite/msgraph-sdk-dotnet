// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.



namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ResponseType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ResponseType
    {
    
        /// <summary>
        /// none
        /// </summary>
        None,
    
        /// <summary>
        /// organizer
        /// </summary>
        Organizer,
    
        /// <summary>
        /// tentatively Accepted
        /// </summary>
        TentativelyAccepted,
    
        /// <summary>
        /// accepted
        /// </summary>
        Accepted,
    
        /// <summary>
        /// declined
        /// </summary>
        Declined,
    
        /// <summary>
        /// not Responded
        /// </summary>
        NotResponded,
    
    }
}
