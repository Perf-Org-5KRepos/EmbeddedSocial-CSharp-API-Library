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
    /// User compact view
    /// </summary>
    public partial class UserCompactView
    {
        /// <summary>
        /// Initializes a new instance of the UserCompactView class.
        /// </summary>
        public UserCompactView() { }

        /// <summary>
        /// Initializes a new instance of the UserCompactView class.
        /// </summary>
        public UserCompactView(string userHandle, string firstName, string lastName, Visibility visibility, FollowerStatus followerStatus, string photoHandle = default(string), string photoUrl = default(string))
        {
            UserHandle = userHandle;
            FirstName = firstName;
            LastName = lastName;
            PhotoHandle = photoHandle;
            PhotoUrl = photoUrl;
            Visibility = visibility;
            FollowerStatus = followerStatus;
        }

        /// <summary>
        /// Gets or sets user handle
        /// </summary>
        [JsonProperty(PropertyName = "userHandle")]
        public string UserHandle { get; set; }

        /// <summary>
        /// Gets or sets first name of the user
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets last name of the user
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets photo handle of the user
        /// </summary>
        [JsonProperty(PropertyName = "photoHandle")]
        public string PhotoHandle { get; set; }

        /// <summary>
        /// Gets or sets photo url of the user
        /// </summary>
        [JsonProperty(PropertyName = "photoUrl")]
        public string PhotoUrl { get; set; }

        /// <summary>
        /// Gets or sets visibility of the user. Possible values include:
        /// 'Public', 'Private'
        /// </summary>
        [JsonProperty(PropertyName = "visibility")]
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Gets or sets follower relationship status of the querying user.
        /// Possible values include: 'None', 'Follow', 'Pending', 'Blocked'
        /// </summary>
        [JsonProperty(PropertyName = "followerStatus")]
        public FollowerStatus FollowerStatus { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (UserHandle == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserHandle");
            }
            if (FirstName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FirstName");
            }
            if (LastName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LastName");
            }
        }
    }
}
