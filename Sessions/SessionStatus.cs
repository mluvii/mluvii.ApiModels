namespace mluvii.ApiModels.Sessions
{
    public enum SessionStatus
    {
        UNKNOWN = 0,
        CREATED,
        IN_QUEUE,
        WAITING,
        ACTIVE,
        ACW,
        BCW,
        CLOSED,
        BLACKLISTED
    }
}
