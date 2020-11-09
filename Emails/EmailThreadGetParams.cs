using mluvii.ApiModels.Common.Filters;

namespace mluvii.ApiModels.Emails
{
    public class EmailThreadGetParams
    {
        public IdSetFilter ThreadId { get; set; }

        public EnumSetFilter<EmailThreadState> State { get; set; }

        public TextFilter Client { get; set; }

        public StringSetFilter Inbox { get; set; }

        public TextFilter Subject { get; set; }

        public DateTimeFilter Created { get; set; }

        public EnumSetFilter<EmailThreadInitiator> Initiator { get; set; }

        public IdSetFilter MessageCount { get; set; }

        public DateTimeFilter LastClientMessage { get; set; }

        public DateTimeFilter LastOperatorMessage { get; set; }

        public IntSetFilter OperatorUserId { get; set; }

        public bool? HasAttachment { get; set; }

        public bool? AutoReplySent { get; set; }

        public StringSetFilter Tags { get; set; }
    }
}
