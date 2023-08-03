namespace mluvii.ApiModels.Sessions
{
    public enum GuestLeftSessionInState
    {
        UNKNOWN = 0,
        LeftQueue,
        LeftSession,
        LeftAfterSession,
        StillConnected,
        LeftBeforeQueue
    }
}
