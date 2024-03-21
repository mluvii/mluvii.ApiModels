namespace mluvii.ApiModels.Sessions
{
    public enum DeliveryState
    {
        UNKNOWN = 0,
        Sent,
        SendingFailed,
        DeliveryFailed,
        Delivered,
        Read,
    }
}