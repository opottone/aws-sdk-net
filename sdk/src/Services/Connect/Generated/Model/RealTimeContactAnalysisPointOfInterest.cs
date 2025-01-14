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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The section of the contact transcript segment that category rule was detected.
    /// </summary>
    public partial class RealTimeContactAnalysisPointOfInterest
    {
        private List<RealTimeContactAnalysisTranscriptItemWithCharacterOffsets> _transcriptItems = new List<RealTimeContactAnalysisTranscriptItemWithCharacterOffsets>();

        /// <summary>
        /// Gets and sets the property TranscriptItems. 
        /// <para>
        /// List of the transcript items (segments) that are associated with a given point of
        /// interest. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<RealTimeContactAnalysisTranscriptItemWithCharacterOffsets> TranscriptItems
        {
            get { return this._transcriptItems; }
            set { this._transcriptItems = value; }
        }

        // Check to see if TranscriptItems property is set
        internal bool IsSetTranscriptItems()
        {
            return this._transcriptItems != null && this._transcriptItems.Count > 0; 
        }

    }
}