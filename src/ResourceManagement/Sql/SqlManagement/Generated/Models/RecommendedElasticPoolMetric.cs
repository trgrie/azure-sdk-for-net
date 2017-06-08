// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Represents Azure SQL recommended elastic pool metric.
    /// </summary>
    public partial class RecommendedElasticPoolMetric
    {
        private DateTime _dateTime;
        
        /// <summary>
        /// Optional. Gets or sets the time of metric.
        /// </summary>
        public DateTime DateTime
        {
            get { return this._dateTime; }
            set { this._dateTime = value; }
        }
        
        private double _dtu;
        
        /// <summary>
        /// Optional. Gets or sets the DTU.
        /// </summary>
        public double Dtu
        {
            get { return this._dtu; }
            set { this._dtu = value; }
        }
        
        private double _sizeGB;
        
        /// <summary>
        /// Optional. Gets or sets size in gigabytes.
        /// </summary>
        public double SizeGB
        {
            get { return this._sizeGB; }
            set { this._sizeGB = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecommendedElasticPoolMetric
        /// class.
        /// </summary>
        public RecommendedElasticPoolMetric()
        {
        }
    }
}