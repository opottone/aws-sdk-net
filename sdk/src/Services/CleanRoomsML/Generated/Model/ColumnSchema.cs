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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Metadata for a column.
    /// </summary>
    public partial class ColumnSchema
    {
        private string _columnName;
        private List<string> _columnTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of a column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ColumnName
        {
            get { return this._columnName; }
            set { this._columnName = value; }
        }

        // Check to see if ColumnName property is set
        internal bool IsSetColumnName()
        {
            return this._columnName != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnTypes. 
        /// <para>
        /// The data type of column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> ColumnTypes
        {
            get { return this._columnTypes; }
            set { this._columnTypes = value; }
        }

        // Check to see if ColumnTypes property is set
        internal bool IsSetColumnTypes()
        {
            return this._columnTypes != null && this._columnTypes.Count > 0; 
        }

    }
}