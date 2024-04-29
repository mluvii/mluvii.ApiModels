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
        FAILING,
        DIAL_FAILED,
        RETRY_SCHEDULED,
        WA_SENT,
        WA_SEND_FAILED,
        WA_DELIVERED,
        WA_DELIVERY_FAILED,
        WA_READ,
        CANCELLED_BY_ADMIN,
        CANCELLED_BY_CLIENT,
        CANCELLED_BY_OPERATOR,
        BLACKLISTED,
        INVALID_RECORD,
        REMOVED
    }
}
