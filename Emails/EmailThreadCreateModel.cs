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
        /// Use <see cref="ClientEmails"/> instead.
        /// </summary>
        [Obsolete]
        public string To { get; set; }

        public IList<string> ClientEmails { get; set; }

        [Required]
        [MinLength(1)]
        public string Subject { get; set; }

        [Required]
        [MinLength(1)]
        public string Body { get; set; }
    }
}
