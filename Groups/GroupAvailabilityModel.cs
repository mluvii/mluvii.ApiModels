using mluvii.ApiModels.Common;
using System.Collections.Generic;

namespace mluvii.ApiModels.Groups
{
    public class GroupAvailabilityModel
    {
        public Dictionary<int, GroupOverallWorkload> OverallWorkload { get; set; }
    }

    public class GroupOverallWorkload
    {
        public Dictionary<Channel, GroupWorkload> Workload { get; set; }
    }

    public class GroupWorkload
    {
        public int InQueueCountTotal { get; set; }

        /// <summary>
        /// Count of used shared slots
        /// It is used in whole group routing
        /// </summary>
        public int SharedSlotsUsedTotal { get; set; }

        public int FreeQueueSlotsCountTotal { get; set; }
    }
}
