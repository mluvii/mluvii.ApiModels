namespace mluvii.ApiModels.Emails
{
    public class EmailRecipient
    {
        /// <summary>
        /// Type of email recipient header field (To, Cc, Bcc)
        /// </summary>
        public EmailMessageRecipientType RecipientType { get; set; }

        public string RecipientAddress { get; set; }

        public string RecipientName { get; set; }
    }
}
