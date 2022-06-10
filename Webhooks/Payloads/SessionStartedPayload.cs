﻿using System;
using mluvii.ApiModels.Sessions;

namespace mluvii.ApiModels.Webhooks.Payloads
{
    public class SessionStartedPayload
    {
        public long Id { get; set; }

        public int TenantId { get; set; }

        public SessionChannel Channel { get; set; }

        public SessionSource Source { get; set; }

        public DateTimeOffset Started { get; set; }
    }
}
