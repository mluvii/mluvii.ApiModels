namespace mluvii.ApiModels.Users
{
    public class OperatorStateModel
    {
        public int UserId { get; set; }

        public OperatorStateKind StateKind { get; set; }

        public int? BreakStateId { get; set; }

        public string BreakStateName { get; set; }

        public string Note { get; set; }
    }
}