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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Trace Part which contains input details for action group or knowledge base
    /// </summary>
    public partial class InvocationInput
    {
        private ActionGroupInvocationInput _actionGroupInvocationInput;
        private InvocationType _invocationType;
        private KnowledgeBaseLookupInput _knowledgeBaseLookupInput;
        private string _traceId;

        /// <summary>
        /// Gets and sets the property ActionGroupInvocationInput.
        /// </summary>
        public ActionGroupInvocationInput ActionGroupInvocationInput
        {
            get { return this._actionGroupInvocationInput; }
            set { this._actionGroupInvocationInput = value; }
        }

        // Check to see if ActionGroupInvocationInput property is set
        internal bool IsSetActionGroupInvocationInput()
        {
            return this._actionGroupInvocationInput != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationType.
        /// </summary>
        public InvocationType InvocationType
        {
            get { return this._invocationType; }
            set { this._invocationType = value; }
        }

        // Check to see if InvocationType property is set
        internal bool IsSetInvocationType()
        {
            return this._invocationType != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseLookupInput.
        /// </summary>
        public KnowledgeBaseLookupInput KnowledgeBaseLookupInput
        {
            get { return this._knowledgeBaseLookupInput; }
            set { this._knowledgeBaseLookupInput = value; }
        }

        // Check to see if KnowledgeBaseLookupInput property is set
        internal bool IsSetKnowledgeBaseLookupInput()
        {
            return this._knowledgeBaseLookupInput != null;
        }

        /// <summary>
        /// Gets and sets the property TraceId.
        /// </summary>
        [AWSProperty(Min=2, Max=16)]
        public string TraceId
        {
            get { return this._traceId; }
            set { this._traceId = value; }
        }

        // Check to see if TraceId property is set
        internal bool IsSetTraceId()
        {
            return this._traceId != null;
        }

    }
}