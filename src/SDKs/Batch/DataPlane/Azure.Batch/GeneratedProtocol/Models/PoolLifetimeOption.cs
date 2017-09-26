// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PoolLifetimeOption.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PoolLifetimeOption
    {
        [EnumMember(Value = "jobSchedule")]
        JobSchedule,
        [EnumMember(Value = "job")]
        Job
    }
    internal static class PoolLifetimeOptionEnumExtension
    {
        internal static string ToSerializedValue(this PoolLifetimeOption? value)  =>
            value == null ? null : ((PoolLifetimeOption)value).ToSerializedValue();

        internal static string ToSerializedValue(this PoolLifetimeOption value)
        {
            switch( value )
            {
                case PoolLifetimeOption.JobSchedule:
                    return "jobSchedule";
                case PoolLifetimeOption.Job:
                    return "job";
            }
            return null;
        }

        internal static PoolLifetimeOption? ParsePoolLifetimeOption(this string value)
        {
            switch( value )
            {
                case "jobSchedule":
                    return PoolLifetimeOption.JobSchedule;
                case "job":
                    return PoolLifetimeOption.Job;
            }
            return null;
        }
    }
}