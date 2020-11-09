using mluvii.ApiModels.Common;
using mluvii.ApiModels.Common.Filters;

namespace mluvii.ApiModels.Sessions
{
    public class SessionGetParams
    {
        public IdSetFilter SessionId { get; set; }

        public IntSetFilter DepartmentId { get; set; }

        public IdSetFilter ChannelIdentityId { get; set; }

        public EnumSetFilter<SessionStatus> Status { get; set; }

        public EnumSetFilter<SessionChannel> Channel { get; set; }

        public EnumSetFilter<SessionSource> Source { get; set; }

        public TextFilter LandingPage { get; set; }

        public IntSetFilter OperatorUserId { get; set; }

        public IntSetFilter ChatbotId { get; set; }

        public StringSetFilter Widget { get; set; }

        public DateTimeFilter Created { get; set; }

        public DateTimeFilter Accepted { get; set; }

        public DateTimeFilter Ended { get; set; }

        public TimeSpanFilter WaitingTime { get; set; }

        public TimeSpanFilter Duration { get; set; }

        public StringSetFilter Result { get; set; }

        public IntSetFilter ClientStars { get; set; }

        public EnumSetFilter<FeedbackScale> ClientFeedbackScale { get; set; }

        public IdSetFilter ClientId { get; set; }

        public TextFilter IPAddress { get; set; }

        public TextFilter PhoneCallbackNumber { get; set; }

        public TextFilter InitialMessage { get; set; }

        public StringSetFilter Tags { get; set; }

        public StringSetFilter GuestIdentifications { get; set; }

        public EnumSetFilter<GuestBrowserType> Browser { get; set; }

        public EnumSetFilter<GuestOSType> OS { get; set; }

        public TextFilter Language { get; set; }

        public TextFilter GDPRVersion { get; set; }

        public EnumSetFilter<GuestLeftSessionInState> GuestLeftSession { get; set; }

        public bool? AutoAccepted { get; set; }

        public bool? HasConcurrentOperators { get; set; }

        public string ActivityTextsContain { get; set; }

        public EnumSetFilter<SessionTerminationReason> TerminationReason { get; set; }

        public DateTimeFilter Anonymized { get; set; }
    }
}
