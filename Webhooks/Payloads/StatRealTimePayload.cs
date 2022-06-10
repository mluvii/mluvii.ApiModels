using System;
using System.Collections.Generic;

namespace mluvii.ApiModels.Webhooks.Payloads
{
    public class StatRealTimePayload
    {
        public int CompanyId { get; set; }

        public string MetricName { get; set; }

        public IDictionary<string, string> Tags { get; set; }

        public IDictionary<string, string> Fields { get; set; }

        public DateTimeOffset Time { get; set; }
    }
}
