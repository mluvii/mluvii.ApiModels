using System;

namespace mluvii.ApiModels.Users
{
    public class OperatorStatesModel
    {
        public DateTime LastModified { get; set; }

        public int Limit { get; set; }

        public int Page { get; set; }

        public long TotalCount { get; set; }

        public OperatorStateModel[] Data { get; set; }
    }
}
