using System.Collections.Generic;

namespace mluvii.ApiModels.Users
{
    public class UserSettingsModel
    {
        public int UserId { get; set; }

        public IDictionary<string, string> Settings { get; set; }
    }
}
