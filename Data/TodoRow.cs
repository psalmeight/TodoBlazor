using System;

namespace TodoBlazor.Data
{
    public class TodoRow
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Text { get; set; }

        public TodoRow(int Id, string Status, string Text)
        {
            this.Id = Id;
            this.Status = Status;
            this.Text = Text;
        }
    }
}
