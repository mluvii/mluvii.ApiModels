namespace mluvii.ApiModels.Emails
{
    public enum EmailMessageState
    {
        UNKNOWN = 0,
        WaitingToSend,
        Sending,
        FailedToSend,
        Sent,
        WaitingToRetrySending,
        Received,
        DidNotAnswer
    }
}
