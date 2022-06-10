using System;

namespace mluvii.ApiModels.Webhooks.Payloads
{
    public class EmailThreadOperatorLeftPayload
    {
        public long Id { get; set; }

        public int TenantId { get; set; }

        public int UserId { get; set; }

        public DateTimeOffset Time { get; set; }
    }
}
