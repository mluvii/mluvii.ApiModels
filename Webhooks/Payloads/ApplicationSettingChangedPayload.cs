namespace mluvii.ApiModels.Webhooks.Payloads
{
    public class ApplicationSettingChangedPayload
    {
        public string Name { get; set; }

        public int? CompanyId { get; set; }

        public int? DepartmentId { get; set; }

        public int? OperatorGroupId { get; set; }

        public int? UserId { get; set; }

        public int? RoutingRuleSetId { get; set; }
    }
}
