namespace mluvii.ApiModels.Common
{
    public class AssignedTag
    {
        /// <summary>
        /// Operator who assigned the TAG.
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Name of TAG.
        /// </summary>
        public string Name { get; set; }
    }
}
