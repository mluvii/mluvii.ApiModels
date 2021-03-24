using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Users
{
    public class SetOperatorStateModel
    {
        [Required]
        public OperatorStateKind StateKind { get; set; }

        public int? BreakStateId { get; set; }

        public string Note { get; set; }
    }
}
