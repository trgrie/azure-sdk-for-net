// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// Values returned by the List operation.
    /// </summary>
    public partial class BatchAccountListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the BatchAccountListResultInner
        /// class.
        /// </summary>
        public BatchAccountListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the BatchAccountListResultInner
        /// class.
        /// </summary>
        /// <param name="value">The collection of returned account
        /// resources.</param>
        /// <param name="nextLink">The continuation token.</param>
        public BatchAccountListResultInner(System.Collections.Generic.IList<AccountResourceInner> value = default(System.Collections.Generic.IList<AccountResourceInner>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets or sets the collection of returned account resources.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<AccountResourceInner> Value { get; set; }

        /// <summary>
        /// Gets or sets the continuation token.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
