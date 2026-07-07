using System;

namespace mluvii.ApiModels.Groups
{
    [Flags]
    public enum OfflineReason
    {
        NONE = 0,
        BUSINESS_HOURS = 1,
        NO_OPERATORS = 2,
        QUEUE_FULL = 4,
        DELETED = 8,
        AWAY_IS_OFFLINE = 16,
        CHANNEL_BLOCKED = 32
    }
}
