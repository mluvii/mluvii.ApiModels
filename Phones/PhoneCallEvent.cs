using System;
using System.Collections.Generic;
using System.Text;

namespace mluvii.ApiModels.Phones
{
    public class PhoneCallEvent
    {
        public string Event { get; set; }
        public DateTime Date { get; set; }
        public IDictionary<string, string> Action { get; set; }
    }
}
