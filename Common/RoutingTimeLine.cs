using System;
using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Common
{
    public class RoutingTimeLine
    {
        public long RoutingRequestId { get; set; }

        public DateTimeOffset Timestamp { get; set; }

        [EnumDataType(typeof(RoutingTimelineActivityType))]
        public RoutingTimelineActivityType ActivityType { get; set; }

        public IdNameModel Group { get; set; }

        public string PhoneNumber { get; set; }

        public RoutingTimelineOperator Operator { get; set; }

        public RoutingTimelineOperator ForwardedByOperator { get; set; }

        public RoutingTimelineOperator InvitedByOperator { get; set; }
    }

    public class RoutingTimelineOperator
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public enum RoutingTimelineActivityType
    {
        UNKNOWN = 0,
        RoutingRequestCreated = 1,
        EnteredGroupQueue,
        GroupQueueTimeoutExpired,
        LeftGroupQueue,
        AssignedToOperator,
        OperatorTimeoutExpired,
        AcceptedByOperator,
        ForwardedToGroup,
        ForwardedToUser,
        ForwardedToPhone,
        RoutingEnded,
        InvitedGroup,
        InvitedUser
    }

    public class IdNameModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
