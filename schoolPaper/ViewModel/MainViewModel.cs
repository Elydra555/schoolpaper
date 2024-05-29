using schoolPaper.Command;
using schoolPaper.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace schoolPaper.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {

		private object currentView;

		public object CurrentView
		{
			get { return currentView; }
			set { currentView = value; OnPropertyChanged(); }
		}

		HomeView homeView;
		TaskOneView taskOneView;

        public event PropertyChangedEventHandler? PropertyChanged;

        public RelayCommand openHOme { get; }
        public RelayCommand TaskOneView { get; }

        public MainViewModel()
        {
            homeView = new HomeView();
            taskOneView = new TaskOneView();

            openHOme = new RelayCommand(X => CurrentView = homeView);
            TaskOneView = new RelayCommand(X=> CurrentView = taskOneView);

			CurrentView = homeView;
        }
        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
