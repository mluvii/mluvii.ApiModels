namespace mluvii.ApiModels.Sessions
{
    public enum GetMediaResult
    {
        UNKNOWN = 0,
        Success,
        NoCameraOnlyMic,
        NoDevices,
        UserDenied
    }
}
