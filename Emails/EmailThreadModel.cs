using System;
using System.Collections.Generic;
using mluvii.ApiModels.Common;

namespace mluvii.ApiModels.Emails
{
    public class EmailThreadModel
    {
        public long Id { get; set; }

        public int CompanyId { get; set; }

        public int DepartmentId { get; set; }

        /// <summary>
        /// Tags associated with this e-mail thread.
        /// </summary>
        public ICollection<AssignedTag> Tags { get; set; }

        /// <summary>
        /// E-mail thread state.
        /// </summary>
        public EmailThreadState State { get; set; }

        /// <summary>
        /// When e-mail thread creates.
        /// </summary>
        public DateTimeOffset Created { get; set; }

        /// <summary>
        /// Last e-mail message time from client.
        /// </summary>
        public DateTimeOffset? LastClientMessage { get; set; }

        /// <summary>
        /// E-mail thread general subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Use <see cref="ClientNames"/> instead.
        /// Contains single element of <see cref="ClientNames"/> or null if there are multiple clients.
        /// </summary>
        [Obsolete]
        public string ClientName { get; set; }

        public IList<string> ClientNames { get; set; }

        /// <summary>
        /// Use <see cref="ClientEmails"/> instead.
        /// Contains single element of <see cref="ClientEmails"/> or null if there are multiple client emails.
        /// </summary>
        [Obsolete]
        public string ClientEmail { get; set; }

        public IList<string> ClientEmails { get; set; }

        /// <summary>
        /// E-mail thread inbox name.
        /// </summary>
        public string InboxName { get; set; }

        /// <summary>
        /// E-mail thread inbox address.
        /// </summary>
        public string InboxAddress { get; set; }

        /// <summary>
        /// Who initiates e-mail thread.
        /// </summary>
        public EmailThreadInitiator Initiator { get; set; }

        /// <summary>
        /// Operators who participated in the e-mail thread
        /// </summary>
        public ICollection<EmailThreadOperators> Operators { get; set; }

        /// <summary>
        /// Number of e-mail messages that has e-mail thread.
        /// </summary>
        public int MessageCount { get; set; }

        /// <summary>
        /// Does e-mail thread has an auto-answer e-mail message.
        /// </summary>
        public bool AutoReplySent { get; set; }

        /// <summary>
        /// Trail of all e-mail thread activities.
        /// </summary>
        public ICollection<Activity> Activities { get; set; }
    }

    public class Activity
    {
        public long Id { get; set; }

        public string Body { get; set; }

        /// <summary>
        /// Type of activity
        /// </summary>
        public EmailThreadActivityType Type { get; set; }

        /// <summary>
        /// Operator who initiated the activity.
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Timestamp of activity
        /// </summary>
        public DateTimeOffset Created { get; set; }
    }
}
