using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Emails
{
    public class EmailThreadCreateModel
    {
        [Required]
        public int InboxId { get; set; }

        /// <summary>
        /// If set, the thread will be assigned to the given operator for manual processing.
        /// </summary>
        [DefaultValue(null)]
        public int? OperatorUserId { get; set; }

        /// <summary>
        /// If set, a contact directory contact will be assigned to the thread.
        /// </summary>
        [DefaultValue(null)]
        public long? ContactId { get; set; }

        /// <summary>
        /// Use <see cref="ClientEmail"/> and optionally <see cref="ClientAdditionalEmails"/> instead.
        /// </summary>
        [Obsolete]
        public string To { get; set; }

        /// <summary>
        /// Use <see cref="ClientEmail"/> and optionally <see cref="ClientAdditionalEmails"/> instead.
        /// </summary>
        [Obsolete]
        public IList<string> ClientEmails { get; set; }

        /// <summary>
        /// This is the client's primary email address.
        /// Other addresses can be specified using the <see cref="ClientAdditionalEmails"/> property,
        /// but only <see cref="ClientEmail"/> is used when working with client contact's history.
        /// </summary>
        public string ClientEmail { get; set; }

        /// <summary>
        /// Additional recipient addresses.
        /// Multiple addresses can be specified using the <see cref="ClientAdditionalEmails"/> property,
        /// but only <see cref="ClientEmail"/> is used when working with client contact's history.
        /// </summary>
        public IList<string> ClientAdditionalEmails { get; set; }

        [Required]
        [MinLength(1)]
        public string Subject { get; set; }

        [Required]
        [MinLength(1)]
        public string Body { get; set; }
    }
}
