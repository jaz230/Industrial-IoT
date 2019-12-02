// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Publisher.Models {

    /// <summary>
    /// A monitored and published item
    /// </summary>
    public class PublishedItemModel {

        /// <summary>
        /// Variable node monitored
        /// </summary>
        public string NodeId { get; set; }

        /// <summary>
        /// Publishing interval to use
        /// </summary>
        public int? PublishingInterval { get; set; }

        /// <summary>
        /// Sampling interval to use
        /// </summary>
        public int? SamplingInterval { get; set; }
    }
}