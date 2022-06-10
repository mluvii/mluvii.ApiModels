using System;
using mluvii.ApiModels.Sessions;

namespace mluvii.ApiModels.Webhooks.Payloads
{
    public class SessionActivityAvResponsePayload
    {
        public long SessionId { get; set; }

        public long OperatorId { get; set; }

        public SessionAVRequestState Response { get; set; }

        public DateTimeOffset Time { get; set; }
    }
}
