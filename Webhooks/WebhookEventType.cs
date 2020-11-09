namespace mluvii.ApiModels.Webhooks
{
    public enum WebhookEventType
    {
        UNKNOWN = 0,
        UserStatusChanged,
        SessionCreated,
        SessionStarted,
        SessionEnded,
        SessionForwarded,
        SessionOperatorJoined,
        SessionOperatorLeft,
        SessionOperatorConcluded,
        SessionCallParamsUpdated,
        EmailThreadCreated,
        EmailThreadOperatorJoined,
        EmailThreadOperatorLeft,
        EmailThreadForwarded
    }
}
