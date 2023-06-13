using mluvii.ApiModels.Common.Filters;

namespace mluvii.ApiModels.Emails
{
    public class EmailMessageGetParams
    {
        public IdSetFilter MessageId { get; set; }

        public StringSetFilter Client { get; set; }

        public StringSetFilter Inbox { get; set; }

        public IdSetFilter ThreadId { get; set; }

        public TextFilter Subject { get; set; }

        public DateTimeFilter Created { get; set; }

        public DateTimeFilter SLAExpires { get; set; }

        public DateTimeFilter Processed { get; set; }

        public IdSetFilter OperatorUserId { get; set; }

        public EnumSetFilter<EmailMessageState> Status { get; set; }

        public bool? HasAttachment { get; set; }

        public string BodyContain { get; set; }
    }
}
