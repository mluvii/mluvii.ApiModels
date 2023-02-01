using System;
using System.Collections.Generic;
using mluvii.ApiModels.Sessions;

namespace mluvii.ApiModels.Webhooks.Payloads
{
    public class SessionActivityGenericPayload
    {
        public long SessionId { get; set; }

        public long ActivityId { get; set; }

        public DateTimeOffset Time { get; set; }

        public SessionActivityType Type { get; set; }

        [Obsolete("This is a remnant of lazy programming, there should be public model but internal model is used.")]
        public ICollection<object> HeroCard { get; set; }

        [Obsolete("This is a remnant of lazy programming, there should be public model but internal model is used.")]
        public ICollection<object> HeroCardParams { get; set; }

        [Obsolete("This is a remnant of lazy programming, there should be public model but internal model is used.")]
        public ICollection<object> CallScript { get; set; }

        public ClientType? Client { get; set; }

        public string Text { get; set; }

        [Obsolete("This is a remnant of lazy programming, there should be public model but internal model is used.")]
        public object PreviewUrl { get; set; }

        public SessionModel.ActivityFile File { get; set; }

        public string AssociatedSharedFileUrl { get; set; }

        public int? ToOperatorUserId { get; set; }

        public string ToOperatorFullName { get; set; }

        public int? ToGroupId { get; set; }

        public string ToGroupName { get; set; }

        public string ToPhoneNumber { get; set; }

        public string Note { get; set; }

        public string ChatbotMessageContent { get; set; }

        public string SubmissionIdentification { get; set; }

        public int? UserId { get; set; }

        public int? ChatbotId { get; set; }

        public string ChatbotHeroCardSubmissionKey { get; set; }

        public string ChatbotHeroCardSubmissionValue { get; set; }

        public Guid? FormFieldSetUUID { get; set; }

        public SessionTerminationReason? TerminationReason { get; set; }
    }
}
