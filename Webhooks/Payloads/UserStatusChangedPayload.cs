using mluvii.ApiModels.Users;

namespace mluvii.ApiModels.Webhooks.Payloads
{
    public class UserStatusChangedPayload
    {
        public int UserId { get; set; }

        public UserSimplifiedStatus Status { get; set; }

        public UserAvailabilityStatus AvailabilityStatus { get; set; }

        public string AvailabilityStatusReason { get; set; }
    }
}
