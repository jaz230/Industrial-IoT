// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Publisher.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Result of publish request
    /// </summary>
    public partial class PublishStartResponseApiModel
    {
        /// <summary>
        /// Initializes a new instance of the PublishStartResponseApiModel
        /// class.
        /// </summary>
        public PublishStartResponseApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublishStartResponseApiModel
        /// class.
        /// </summary>
        public PublishStartResponseApiModel(ServiceResultApiModel errorInfo = default(ServiceResultApiModel))
        {
            ErrorInfo = errorInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorInfo")]
        public ServiceResultApiModel ErrorInfo { get; set; }

    }
}
