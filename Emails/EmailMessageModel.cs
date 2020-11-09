using System;
using System.Collections.Generic;
using mluvii.ApiModels.Common;

namespace mluvii.ApiModels.Emails
{
    public class EmailMessageModel
    {
        public long Id { get; set; }

        public int CompanyId { get; set; }

        public int DepartmentId { get; set; }

        /// <summary>
        /// E-mail message relates to this e-mail thread ID.
        /// </summary>
        public long ThreadId { get; set; }

        /// <summary>
        /// E-mail message state.
        /// </summary>
        public EmailMessageState State { get; set; }

        /// <summary>
        /// When e-mail message creates.
        /// </summary>
        public DateTimeOffset Created { get; set; }

        /// <summary>
        /// When e-mail message SLA expires.
        /// </summary>
        public DateTimeOffset? SlaExpires { get; set; }

        /// <summary>
        /// When e-mail message processes.
        /// </summary>
        public DateTimeOffset? Processed { get; set; }

        /// <summary>
        /// E-mail message subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// E-mail message client e-mail.
        /// </summary>
        public string ClientEmail { get; set; }

        /// <summary>
        /// E-mail message sender name.
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// E-mail message sender e-mail.
        /// </summary>
        public string SenderAddress { get; set; }

        /// <summary>
        /// E-mail message recipient name.
        /// </summary>
        public string RecipientName { get; set; }

        /// <summary>
        /// E-mail message recipient e-mail.
        /// </summary>
        public string RecipientAddress { get; set; }

        /// <summary>
        /// E-mail message inbox name.
        /// </summary>
        public string InboxName { get; set; }

        /// <summary>
        /// E-mail message inbox address.
        /// </summary>
        public string InboxAddress { get; set; }

        /// <summary>
        /// Operators who participated in the e-mail message
        /// </summary>
        public ICollection<GeneralOperatorInfo> Operators { get; set; }

        /// <summary>
        /// E-mail message body.
        /// </summary>
        public string Body { get; set; }
    }
}
