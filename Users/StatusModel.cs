using System;
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

        [Obsolete("Use State")]
        [EnumDataType(typeof(UserSimplifiedStatus))]
        public UserSimplifiedStatus SimplifiedStatus { get; set; }

        [Obsolete("Use State")]
        [EnumDataType(typeof(UserAvailabilityStatus))]
        public UserAvailabilityStatus AvailabilityStatus { get; set; }

        public string AvailabilityStatusReason { get; set; }

        [EnumDataType(typeof(OperatorStateKind))]
        public OperatorStateKind State { get; set; }
    }
}
