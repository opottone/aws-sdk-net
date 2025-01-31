/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// This is the response object from the ListApplicationAssociations operation.
    /// </summary>
    public partial class ListApplicationAssociationsResponse : AmazonWebServiceResponse
    {
        private List<ApplicationAssociationSummary> _applicationAssociations = new List<ApplicationAssociationSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ApplicationAssociations. 
        /// <para>
        /// List of Application Associations for the Application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<ApplicationAssociationSummary> ApplicationAssociations
        {
            get { return this._applicationAssociations; }
            set { this._applicationAssociations = value; }
        }

        // Check to see if ApplicationAssociations property is set
        internal bool IsSetApplicationAssociations()
        {
            return this._applicationAssociations != null && this._applicationAssociations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}