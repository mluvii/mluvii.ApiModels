namespace mluvii.ApiModels.Sessions
{
    public enum SessionActivityType
    {
        UNKNOWN = 0,
        ChatMessage,
        SharedFile,
        SharedScreen,
        PhotoRequest,
        CobrowsingStarted,
        CobrowsingStoppedByGuest,
        ScreenSharingFailedByGuest,
        FileUploadFailed,
        HeroCard,
        HeroCardSubmission,
        ChatbotMessage,
        CallScript,
        CallScriptSubmission,
        WelcomeMessage,
        LastFarewellMessage,
        PreviewUrl,
        ExternalMessage,
        AvRequest,
        AvResponse,
        AvGetMediaResult,
        AvTerminated,
        ChatToMail,
        AutoActivity,
        UpgradeToFull,
        SessionEnded,
        SessionForwarded,
        OperatorInvited,
        OperatorInviteCanceled,
        OperatorInviteRejected,
        OperatorKicked
    }
}
