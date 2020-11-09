using System;

namespace mluvii.ApiModels.Common.Filters
{
    public class DateTimeFilter
    {
        public bool? Null { get; set; }

        public DateTimeOffset? Min { get; set; }

        public DateTimeOffset? Max { get; set; }
    }
}
