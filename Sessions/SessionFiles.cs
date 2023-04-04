using System.Collections.Generic;

namespace mluvii.ApiModels.Sessions
{
    public class SessionFiles
    {
        public ICollection<int> FileIds { get; set; }
    }

    public enum SessionFileRemovalState
    {
        UNKNOWN = 0,
        REMOVED,
        ALREADY_REMOVED,
        INACCESSIBLE,
    }

    public class SessionFileResponse
    {
        public int FileId { get; set; }
        public SessionFileRemovalState State { get; set; }
    }

}
