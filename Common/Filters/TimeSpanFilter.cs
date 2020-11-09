using System;

namespace mluvii.ApiModels.Common.Filters
{
    public class TimeSpanFilter
    {
        public bool? Null { get; set; }

        public TimeSpan? Min { get; set; }

        public TimeSpan? Max { get; set; }
    }
}
