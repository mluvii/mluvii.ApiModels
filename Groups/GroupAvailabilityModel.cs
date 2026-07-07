using mluvii.ApiModels.Common;
using System.Collections.Generic;

namespace mluvii.ApiModels.Groups
{
    public class GroupAvailabilityModel
    {
        public Dictionary<int, GroupState> State { get; set; }

        public Dictionary<int, GroupOverallWorkload> OverallWorkload { get; set; }
    }

    public class GroupState
    {
        public Dictionary<Channel, GroupChannelState> ChannelState { get; set; }
    }

    public class GroupOverallWorkload
    {
        public Dictionary<Channel, GroupWorkload> Workload { get; set; }
    }

    public class GroupChannelState
    {
        public WidgetOperatorGroupState WidgetState { get; set; }

        public OfflineReason OfflineReason { get; set; }
    }

    public class GroupWorkload
    {
        public int InQueueCountTotal { get; set; }

        public int FreeQueueSlotsCountTotal { get; set; }
    }
}
