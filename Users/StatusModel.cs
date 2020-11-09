using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Users
{
    public class SetAvailabilityStatusModel
    {
        [Required]
        public UserAvailabilityStatus Status { get; set; }

        public string Reason { get; set; }
    }

    public class UserStatusInfoModel
    {
        public int UserId { get; set; }

        [EnumDataType(typeof(UserSimplifiedStatus))]
        public UserSimplifiedStatus SimplifiedStatus { get; set; }

        [EnumDataType(typeof(UserAvailabilityStatus))]
        public UserAvailabilityStatus AvailabilityStatus { get; set; }

        public string AvailabilityStatusReason { get; set; }
    }
}
