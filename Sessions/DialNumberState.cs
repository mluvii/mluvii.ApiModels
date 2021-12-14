namespace mluvii.ApiModels.Sessions
{
    public enum DialNumberState
    {
        UNKNOWN = 0,
        DIALING,
        ANSWERED,
        RINGING,
        FAILED,
        NO_ANSWER,
        BLACKLISTED,
        REJECTED,
        INVALID_NUMBER,
        UNREACHABLE,
        CANCELLED_BY_USER
    }
}
