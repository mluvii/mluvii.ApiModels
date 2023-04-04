namespace mluvii.ApiModels.Campaigns
{
    public enum CampaignIdentityState
    {
        UNKNOWN = 0,
        INITIAL,
        AWAITING_FREE_OPERATOR,
        OPERATOR_ASSIGNED,
        BCW,
        ACW,
        CALLING,
        CALL_IN_PROGRESS,
        SUCCESS,
        DIAL_FAILED,
        RETRY_SCHEDULED,
        CANCELLED_BY_ADMIN,
        CANCELLED_BY_CLIENT,
        CANCELLED_BY_OPERATOR,
        BLACKLISTED,
        INVALID_RECORD
    }
}
