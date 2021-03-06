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
    /// New key pair request
    /// </summary>
    public partial class StartNewKeyPairRequestApiModel
    {
        /// <summary>
        /// Initializes a new instance of the StartNewKeyPairRequestApiModel
        /// class.
        /// </summary>
        public StartNewKeyPairRequestApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StartNewKeyPairRequestApiModel
        /// class.
        /// </summary>
        /// <param name="entityId">Entity id</param>
        /// <param name="groupId">Certificate group</param>
        /// <param name="certificateType">Possible values include:
        /// 'ApplicationInstanceCertificate', 'HttpsCertificate',
        /// 'UserCredentialCertificate'</param>
        /// <param name="subjectName">Subject name</param>
        /// <param name="domainNames">Domain names</param>
        public StartNewKeyPairRequestApiModel(string entityId = default(string), string groupId = default(string), TrustGroupType? certificateType = default(TrustGroupType?), string subjectName = default(string), IList<string> domainNames = default(IList<string>))
        {
            EntityId = entityId;
            GroupId = groupId;
            CertificateType = certificateType;
            SubjectName = subjectName;
            DomainNames = domainNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets entity id
        /// </summary>
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }

        /// <summary>
        /// Gets or sets certificate group
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets possible values include:
        /// 'ApplicationInstanceCertificate', 'HttpsCertificate',
        /// 'UserCredentialCertificate'
        /// </summary>
        [JsonProperty(PropertyName = "certificateType")]
        public TrustGroupType? CertificateType { get; set; }

        /// <summary>
        /// Gets or sets subject name
        /// </summary>
        [JsonProperty(PropertyName = "subjectName")]
        public string SubjectName { get; set; }

        /// <summary>
        /// Gets or sets domain names
        /// </summary>
        [JsonProperty(PropertyName = "domainNames")]
        public IList<string> DomainNames { get; set; }

    }
}
