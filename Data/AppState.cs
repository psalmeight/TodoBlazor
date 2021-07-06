using System;

namespace TodoBlazor.Data
{
    public class AppState
    {
        public int PendingCount { get; set; }
        public string Filter { get; set; }
        public string CurrentText { get; set; }

        public AppState() { }
        public AppState(int PendingCount, string Filter, string CurrentText)
        {
            this.PendingCount = PendingCount;
            this.Filter = Filter;
            this.CurrentText = CurrentText;
        }
    }
}
