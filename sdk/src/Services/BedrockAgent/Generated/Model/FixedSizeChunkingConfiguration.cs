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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Configures fixed size chunking strategy
    /// </summary>
    public partial class FixedSizeChunkingConfiguration
    {
        private int? _maxTokens;
        private int? _overlapPercentage;

        /// <summary>
        /// Gets and sets the property MaxTokens. 
        /// <para>
        /// The maximum number of tokens per chunk.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int MaxTokens
        {
            get { return this._maxTokens.GetValueOrDefault(); }
            set { this._maxTokens = value; }
        }

        // Check to see if MaxTokens property is set
        internal bool IsSetMaxTokens()
        {
            return this._maxTokens.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OverlapPercentage. 
        /// <para>
        /// The overlap percentage between adjacent chunks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=99)]
        public int OverlapPercentage
        {
            get { return this._overlapPercentage.GetValueOrDefault(); }
            set { this._overlapPercentage = value; }
        }

        // Check to see if OverlapPercentage property is set
        internal bool IsSetOverlapPercentage()
        {
            return this._overlapPercentage.HasValue; 
        }

    }
}