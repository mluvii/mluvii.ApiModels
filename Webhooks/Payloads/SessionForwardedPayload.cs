using System;
using mluvii.ApiModels.Sessions;

namespace mluvii.ApiModels.Webhooks.Payloads
{
    public class SessionForwardedPayload
    {
        public long Id { get; set; }

        public int TenantId { get; set; }

        public SessionChannel Channel { get; set; }

        public SessionSource Source { get; set; }

        public DateTimeOffset Time { get; set; }

        public int? UserId { get; set; }

        public int? OperatorGroupId { get; set; }

        public int? ChatbotId { get; set; }
    }
}
