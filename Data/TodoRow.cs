using System;
using System.ComponentModel;

namespace TodoBlazor.Data
{
    public class TodoRow : INotifyPropertyChanged
    {
        public string Status { get; set; }
        public string Text { get; set; }

        public int id { get; set; }
        public int Id
        {
            get => id;
            set
            {
                this.id = value;
                NotifyPropertyChanged("Id");
            }
        }

        public TodoRow(int Id, string Status, string Text)
        {
            this.Id = Id;
            this.Status = Status;
            this.Text = Text;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
