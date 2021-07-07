namespace mluvii.ApiModels.Campaigns
{
    public enum CampaignIdentityState
    {
        UNKNOWN = 0,
        INITIAL = 1,
        AWAITING_FREE_OPERATOR = 10,
        OPERATOR_ASSIGNED = 12,
        BCW = 14,
        ACW = 16,
        CALLING = 18,
        CALL_IN_PROGRESS = 20,
        SUCCESS = 22,
        DIAL_FAILED = 30,
        RETRY_SCHEDULED = 32,
        CANCELLED_BY_ADMIN = 50,
        CANCELLED_BY_CLIENT = 52,
        CANCELLED_BY_OPERATOR = 54,
        BLACKLISTED = 998,
        INVALID_RECORD = 999,
    }
}
