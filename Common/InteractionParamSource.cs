namespace mluvii.ApiModels.Common
{
    public enum InteractionParamSource
    {
        UNKNOWN = 0,
        User = 1,
        Chatbot = 2,
        HeroCard = 3,
        EntryForm = 4,
        FeedbackForm = 5,
        OfflineForm = 6,
        ExternalMessaging = 7,
        Phone = 8,
        // ReSharper disable once InconsistentNaming -- it is an abbreviation
        API = 9
    }
}
