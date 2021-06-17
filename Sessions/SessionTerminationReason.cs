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
        ExternalPartyLeft,

        CampaignFailedDial,
        CampaignTerminated,

        CallForwardedToExternalPhone,
        OperatorWithoutExtension,
        ForwardToExternalPhoneFailed,

        FailedRouting,
        ExternalSessionExpired,

        SessionApiCall
    }
}
