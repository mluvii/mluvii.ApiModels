using System;

namespace mluvii.ApiModels.Webhooks.Payloads
{
    public class SessionActivityAvTerminatedPayload
    {
        public long SessionId { get; set; }

        public long OperatorId { get; set; }

        public DateTimeOffset Time { get; set; }
    }
}
