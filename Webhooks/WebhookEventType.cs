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
        EmailThreadForwarded,
        GuestIdentityUpdated,
        SessionActivityChatMessage,
        SessionActivitySharedFile,
        SessionActivitySharedScreen,
        SessionActivityCobrowsingStarted,
        SessionActivityCobrowsingStoppedByGuest,
        SessionActivityScreenSharingFailedByGuest,
        SessionActivityFileUploadFailed,
        SessionActivityHeroCard,
        SessionActivityHeroCardSubmission,
        SessionActivityChatbotMessage,
        SessionActivityCallScript,
        SessionActivityCallScriptSubmission,
        SessionActivityWelcomeMessage,
        SessionActivityLastFarewellMessage,
        SessionActivityPreviewUrl,
        SessionActivityExternalMessage,
        SessionActivityOnHold,
        SessionActivityResumeGuest,
        SessionActivityChatToMail,
        SessionActivityAutoActivity,
        SessionActivityChatbotHeroCardSubmission,
        SessionActivitySessionEnded,
        SessionActivitySessionForwarded,
        SessionActivityOperatorInvited,
        SessionActivityOperatorInviteCanceled,
        SessionActivityOperatorInviteRejected,
        SessionActivityOperatorKicked,
        SessionActivityAvRequest,
        SessionActivityAvResponse,
        SessionActivityAvMediaResult,
        SessionActivityAvTerminated,
        EmailThreadParamsUpdated
    }
}
