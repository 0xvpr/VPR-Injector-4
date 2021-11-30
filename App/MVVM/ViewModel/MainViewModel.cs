using System.Diagnostics;
using Testing.Core;

namespace Testing.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        private object _currentView;

        public InjectionViewModel InjectionView { get; set; }
        public SettingsViewModel  SettingsView  { get; set; }
        public AdvancedViewModel  AdvancedView  { get; set; }
        public LogsViewModel      LogsView      { get; set; }

        public RelayCommand InjectionViewCommand { get; set; }
        public RelayCommand SettingsViewCommand  { get; set; }
        public RelayCommand AdvancedViewCommand  { get; set; }
        public RelayCommand LogsViewCommand      { get; set; }

        public MainViewModel()
        {
            InjectionView = new InjectionViewModel();
            SettingsView  = new SettingsViewModel();
            AdvancedView  = new AdvancedViewModel();
            LogsView      = new LogsViewModel();

            CurrentView = InjectionView;

            InjectionViewCommand = new RelayCommand(o => { CurrentView = InjectionView; });
            SettingsViewCommand  = new RelayCommand(o => { CurrentView = SettingsView;  });
            AdvancedViewCommand  = new RelayCommand(o => { CurrentView = AdvancedView;  });
            LogsViewCommand      = new RelayCommand(o => { CurrentView = LogsView; });
        }

        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
    }
}
