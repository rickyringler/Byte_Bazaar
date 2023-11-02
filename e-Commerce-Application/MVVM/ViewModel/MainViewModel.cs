using e_Commerce_Application.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace e_Commerce_Application.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        private object _currentView;
        public HomeViewModel HomeVM { get; set; }
       
        public object CurrentView
        {
            get { return _currentView; }

            set { _currentView = value;
                OnPropertyChanged(); }
        }
        public MainViewModel() 
        {
            HomeVM = new HomeViewModel();
            CurrentView = HomeVM;
        }

    }
}
