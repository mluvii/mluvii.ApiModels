using System.Collections.Generic;

namespace mluvii.ApiModels.Groups
{
    public class GroupSettingsModel
    {
        public int OperatorGroupId { get; set; }

        public IDictionary<string, string> Settings { get; set; }
    }
}
