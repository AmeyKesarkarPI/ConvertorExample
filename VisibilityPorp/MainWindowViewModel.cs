using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VisibilityPorp
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public bool ShowOnlyWhenProperty { get; set; } = true;
        public ICommand SetVisibility { get; set; }
        public MainWindowViewModel()
        {
            SetVisibility = new RelayCommand(ToggleVisibility);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void ToggleVisibility()
        {
            ShowOnlyWhenProperty = !ShowOnlyWhenProperty;
            OnPropertyChange(nameof(ShowOnlyWhenProperty));
        }
    }
}
