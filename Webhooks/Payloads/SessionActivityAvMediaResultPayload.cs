using System;
using mluvii.ApiModels.Sessions;

namespace mluvii.ApiModels.Webhooks.Payloads
{
    public class SessionActivityAvMediaResultPayload
    {
        public long SessionId { get; set; }

        public long OperatorId { get; set; }

        public GetMediaResult Result { get; set; }

        public bool IsStreamAvailable { get; set; }

        public DateTimeOffset Time { get; set; }
    }
}
