using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ConsoleApp2.Models
{
    public class User : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string age;
        public string Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged(); }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; OnPropertyChanged(); }
        }

        private string position;
        public string Position
        {
            get { return position; }
            set { position = value; OnPropertyChanged(); }
        }

        private string hobby;
        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
