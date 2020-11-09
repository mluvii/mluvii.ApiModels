namespace mluvii.ApiModels.Sessions
{
    public enum SessionTerminationReason
    {
        UNKNOWN = 0,

        GuestLeft,
        OperatorLeft,
        ChatbotLeft,
        GuestAbandoned,
        OperatorAbandoned,

        CampaignFailedDial,
        CampaignTerminated,

        CallForwardedToExternalPhone,
        OperatorWithoutExtension,

        FailedRouting,
        ExternalSessionExpired,

        SessionApiCall
    }
}
