using System.Collections.Generic;

namespace mluvii.ApiModels.Routing
{
    public class RoutingRuleSetSettingsModel
    {
        public int RoutingRuleSetId { get; set; }

        public IDictionary<string, string> Settings { get; set; }
    }
}
