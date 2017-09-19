// Copyright (c) Microsoft Corporation. All rights reserved. Licensed under
// the MIT License. See LICENSE in the project root for license information.
// <autogenerated> This file was generated using AutoRest. </autogenerated>

namespace SocialPlus.Client.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Request to put push registration (register or update)
    /// </summary>
    public partial class PutPushRegistrationRequest
    {
        /// <summary>
        /// Initializes a new instance of the PutPushRegistrationRequest class.
        /// </summary>
        public PutPushRegistrationRequest() { }

        /// <summary>
        /// Initializes a new instance of the PutPushRegistrationRequest class.
        /// </summary>
        public PutPushRegistrationRequest(string lastUpdatedTime, string language)
        {
            LastUpdatedTime = lastUpdatedTime;
            Language = language;
        }

        /// <summary>
        /// Gets or sets last updated time from the OS in ISO 8601 format.
        /// This is used to expire out registrations that have not
        /// been updated every 30 days.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// Gets or sets language of the user
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (LastUpdatedTime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LastUpdatedTime");
            }
            if (Language == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Language");
            }
        }
    }
}