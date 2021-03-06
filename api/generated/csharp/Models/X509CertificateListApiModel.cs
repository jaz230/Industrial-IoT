// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Vault.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Certificate list
    /// </summary>
    public partial class X509CertificateListApiModel
    {
        /// <summary>
        /// Initializes a new instance of the X509CertificateListApiModel
        /// class.
        /// </summary>
        public X509CertificateListApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X509CertificateListApiModel
        /// class.
        /// </summary>
        /// <param name="certificates">Certificates</param>
        /// <param name="nextPageLink">Next link</param>
        public X509CertificateListApiModel(IList<X509CertificateApiModel> certificates = default(IList<X509CertificateApiModel>), string nextPageLink = default(string))
        {
            Certificates = certificates;
            NextPageLink = nextPageLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets certificates
        /// </summary>
        [JsonProperty(PropertyName = "certificates")]
        public IList<X509CertificateApiModel> Certificates { get; set; }

        /// <summary>
        /// Gets or sets next link
        /// </summary>
        [JsonProperty(PropertyName = "nextPageLink")]
        public string NextPageLink { get; set; }

    }
}
