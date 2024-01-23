using System.ComponentModel.DataAnnotations;

namespace mluvii.ApiModels.Phones
{
    public class TwoWayCallModel
    {
        /// <summary>
        /// Id of the tenant in which the phone session is to be created.
        /// </summary>
        [Required]
        public int DepartmentId { get; set; }

        /// <summary>
        /// First number to be dialed. This should be the agent/operator.
        /// </summary>
        [Required]
        public string FirstNumber { get; set; }

        /// <summary>
        /// Second number to be dialed. This should be the client.
        /// </summary>
        [Required]
        public string SecondNumber { get; set; }

        /// <summary>
        /// Number to be displayed on the client's device when they receive the call.
        /// </summary>
        [Required]
        public string MaskNumber { get; set; }
    }
}
