using System;

namespace TodoBlazor.Data
{
    public class AppState
    {
        public int PendingCount { get; set; }
        public string Filter { get; set; }
        public string CurrentText { get; set; }

        public AppState() { }
    }
}
