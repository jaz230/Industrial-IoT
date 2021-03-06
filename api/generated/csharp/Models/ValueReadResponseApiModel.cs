// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Twin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Value read response model
    /// </summary>
    public partial class ValueReadResponseApiModel
    {
        /// <summary>
        /// Initializes a new instance of the ValueReadResponseApiModel class.
        /// </summary>
        public ValueReadResponseApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValueReadResponseApiModel class.
        /// </summary>
        /// <param name="value">Value read</param>
        /// <param name="dataType">Built in data type of the value
        /// read.</param>
        /// <param name="sourcePicoseconds">Pico seconds part of when value was
        /// read at source.</param>
        /// <param name="sourceTimestamp">Timestamp of when value was read at
        /// source.</param>
        /// <param name="serverPicoseconds">Pico seconds part of when value was
        /// read at server.</param>
        /// <param name="serverTimestamp">Timestamp of when value was read at
        /// server.</param>
        public ValueReadResponseApiModel(object value = default(object), string dataType = default(string), int? sourcePicoseconds = default(int?), System.DateTime? sourceTimestamp = default(System.DateTime?), int? serverPicoseconds = default(int?), System.DateTime? serverTimestamp = default(System.DateTime?), ServiceResultApiModel errorInfo = default(ServiceResultApiModel))
        {
            Value = value;
            DataType = dataType;
            SourcePicoseconds = sourcePicoseconds;
            SourceTimestamp = sourceTimestamp;
            ServerPicoseconds = serverPicoseconds;
            ServerTimestamp = serverTimestamp;
            ErrorInfo = errorInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value read
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets built in data type of the value read.
        /// </summary>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets pico seconds part of when value was read at source.
        /// </summary>
        [JsonProperty(PropertyName = "sourcePicoseconds")]
        public int? SourcePicoseconds { get; set; }

        /// <summary>
        /// Gets or sets timestamp of when value was read at source.
        /// </summary>
        [JsonProperty(PropertyName = "sourceTimestamp")]
        public System.DateTime? SourceTimestamp { get; set; }

        /// <summary>
        /// Gets or sets pico seconds part of when value was read at server.
        /// </summary>
        [JsonProperty(PropertyName = "serverPicoseconds")]
        public int? ServerPicoseconds { get; set; }

        /// <summary>
        /// Gets or sets timestamp of when value was read at server.
        /// </summary>
        [JsonProperty(PropertyName = "serverTimestamp")]
        public System.DateTime? ServerTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorInfo")]
        public ServiceResultApiModel ErrorInfo { get; set; }

    }
}
