namespace mluvii.ApiModels.Sessions
{
    public enum SessionSource
    {
        UNKNOWN = 0,
        Default,
        Callback,
        Invitation,
        ChatInvitation,
        IncomingCall,
        OutgoingCall,
        Campaign,
        API,
        Facebook,
        WhatsApp,
        VK,
        Apple
    }
}
