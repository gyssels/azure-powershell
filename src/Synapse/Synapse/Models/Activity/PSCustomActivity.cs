// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.WindowsAzure.Commands.Utilities.Common;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Custom activity type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Custom")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSCustomActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSCustomActivity class.
        /// </summary>
        public PSCustomActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets command for custom activity Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.command")]
        public object Command { get; set; }

        /// <summary>
        /// Gets or sets resource linked service reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.resourceLinkedService")]
        public LinkedServiceReference ResourceLinkedService { get; set; }

        /// <summary>
        /// Gets or sets folder path for resource files Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.folderPath")]
        public object FolderPath { get; set; }

        /// <summary>
        /// Gets or sets reference objects
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.referenceObjects")]
        public CustomActivityReferenceObject ReferenceObjects { get; set; }

        /// <summary>
        /// Gets or sets user defined property bag. There is no restriction on
        /// the keys or values that can be used. The user specified custom
        /// activity has the full responsibility to consume and interpret the
        /// content defined.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.extendedProperties")]
        public IDictionary<string, object> ExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets the retention time for the files submitted for custom
        /// activity. Type: double (or Expression with resultType double).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.retentionTimeInDays")]
        public object RetentionTimeInDays { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Command == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Command");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new CustomActivity(this.Name, this.Command);
            activity.ResourceLinkedService = this.ResourceLinkedService;
            activity.FolderPath = this.FolderPath;
            activity.ReferenceObjects = this.ReferenceObjects;
            this.ExtendedProperties?.ForEach(item => activity.ExtendedProperties.Add(item));
            activity.RetentionTimeInDays = this.RetentionTimeInDays;
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy;
            SetProperties(activity);
            return activity;
        }
    }
}

