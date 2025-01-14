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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Represents the output of a <c>ListDeploymentConfigs</c> operation.
    /// </summary>
    public partial class ListDeploymentConfigsResponse : AmazonWebServiceResponse
    {
        private List<string> _deploymentConfigsList = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DeploymentConfigsList. 
        /// <para>
        /// A list of deployment configurations, including built-in configurations such as <c>CodeDeployDefault.OneAtATime</c>.
        /// </para>
        /// </summary>
        public List<string> DeploymentConfigsList
        {
            get { return this._deploymentConfigsList; }
            set { this._deploymentConfigsList = value; }
        }

        // Check to see if DeploymentConfigsList property is set
        internal bool IsSetDeploymentConfigsList()
        {
            return this._deploymentConfigsList != null && this._deploymentConfigsList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If a large amount of information is returned, an identifier is also returned. It can
        /// be used in a subsequent list deployment configurations call to return the next set
        /// of deployment configurations in the list.
        /// </para>
        /// </summary>
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