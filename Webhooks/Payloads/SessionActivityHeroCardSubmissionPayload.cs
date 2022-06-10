using System;
using System.Collections.Generic;
using mluvii.ApiModels.Sessions;

namespace mluvii.ApiModels.Webhooks.Payloads
{
    public class SessionActivityHeroCardSubmissionPayload
    {
        public long SessionId { get; set; }

        public HeroCardSubmissionResult Result { get; set; }

        public int OriginalFormID { get; set; }

        public bool SubmittedByClient { get;  set; }

        public IDictionary<string, string> Params { get; set; }

        public DateTimeOffset Time { get; set; }
    }
}
