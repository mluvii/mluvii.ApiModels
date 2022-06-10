using System;

namespace mluvii.ApiModels.Webhooks.Payloads
{
    public class EmailThreadCreatedPayload
    {
        public long Id { get; set; }

        public int TenantId { get; set; }

        public DateTimeOffset Created { get; set; }
    }
}
