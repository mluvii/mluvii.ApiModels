namespace mluvii.ApiModels.Emails
{
    public enum EmailThreadState
    {
        UNKNOWN = 0,
        InQueue,
        Waiting,
        Accepted,
        SentToClient,
        DidNotAnswer
    }
}
