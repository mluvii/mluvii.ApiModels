using System;

namespace mluvii.ApiModels.Common
{
    /// <summary>
    /// Operator information
    /// </summary>
    public class GeneralOperatorInfo
    {
        public int UserId { get; set; }

        /// <summary>
        /// Unique operator username
        /// </summary>
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class EmailThreadOperators : GeneralOperatorInfo
    {
        public DateTimeOffset Assigned { get; set; }

        public DateTimeOffset Unassigned { get; set; }
    }

    public class SessionOperators : GeneralOperatorInfo
    {
        public DateTimeOffset Joined { get; set; }

        /// <summary>
        /// Operator left session.
        /// </summary>
        public DateTimeOffset? Left { get; set; }

        /// <summary>
        /// Operator completed After Call Work (submitted session conclusion form).
        ///
        /// </summary>
        public DateTimeOffset? Concluded { get; set; }

        /// <summary>
        /// Selected session result.
        /// </summary>
        public string FeedbackResult { get; set; }

        /// <summary>
        /// Freeform textual feedback by operator.
        /// </summary>
        public string FeedbackText { get; set; }
    }
}
