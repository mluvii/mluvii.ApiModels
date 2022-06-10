using System;

namespace mluvii.ApiModels.Webhooks.Payloads
{
    public class EmailThreadForwardedPayload
    {
        public long Id { get; set; }

        public int TenantId { get; set; }

        public DateTimeOffset Time { get; set; }

        public int? UserId { get; set; }

        public int? OperatorGroupId { get; set; }
    }
}
