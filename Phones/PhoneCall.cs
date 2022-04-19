using System;
using System.Collections.Generic;
using System.Text;

namespace mluvii.ApiModels.Phones
{
    public class PhoneCall
    {
        public long PhoneCallId { get; set; }
        public string UniqueId { get; set; }
        public int CompanyDepartmentId { get; set; }
        public DateTimeOffset Created { get; set; }
        public IList<PhoneCallEvent> Events { get; set; }
        public long? SessionId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}
