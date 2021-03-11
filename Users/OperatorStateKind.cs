namespace mluvii.ApiModels.Users
{
    public enum OperatorStateKind
    {
        UNKNOWN = 0,
        OFFLINE,
        DISCONNECTED,
        ONLINE,
        AWAY,
        BREAK,
        BEFORE_CALL,
        ON_CALL,
        AFTER_CALL
    }
}
