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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Defines the various metric parameters that can be customized, such as threshold and
    /// headroom.
    /// </summary>
    public partial class CustomizableMetricParameters
    {
        private CustomizableMetricHeadroom _headroom;
        private CustomizableMetricThreshold _threshold;

        /// <summary>
        /// Gets and sets the property Headroom. 
        /// <para>
        ///  The headroom threshold value in percentage used for the specified metric parameter.
        /// 
        /// </para>
        /// </summary>
        public CustomizableMetricHeadroom Headroom
        {
            get { return this._headroom; }
            set { this._headroom = value; }
        }

        // Check to see if Headroom property is set
        internal bool IsSetHeadroom()
        {
            return this._headroom != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        ///  The threshold value used for the specified metric parameter. 
        /// </para>
        /// </summary>
        public CustomizableMetricThreshold Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold != null;
        }

    }
}