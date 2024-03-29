﻿namespace mluvii.ApiModels.Common
{
    public enum InteractionParamSource
    {
        UNKNOWN = 0,
        User,
        WidgetApi,
        Chatbot,
        HeroCard,
        EntryForm,
        FeedbackForm,
        OfflineForm,
        ExternalMessaging,
        Phone,
        // ReSharper disable once InconsistentNaming -- it is an abbreviation
        API
    }
}
