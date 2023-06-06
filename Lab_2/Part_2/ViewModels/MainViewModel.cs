using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace MyApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _currentDateTime;

        public string CurrentDateTime
        {
            get => _currentDateTime;
            set
            {
                _currentDateTime = value;
                OnPropertyChanged();
            }
        }
        public ICommand UpdateTimeCommand { get; }

        public MainViewModel()
        {
            UpdateTimeCommand = new Command(UpdateTime);
            CurrentDateTime = DateTime.Now.ToString("F");
        }
        private void UpdateTime()
        {
            CurrentDateTime = DateTime.Now.ToString("F");
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string deviceInfo
        {
            get
            {
                var deviceInfo = new StringBuilder()
                    .AppendLine($"Model: {DeviceInfo.Model}")
                    .AppendLine($"Manufacturer: {DeviceInfo.Manufacturer}")
                    .AppendLine($"Platform: {DeviceInfo.Platform}")
                    .AppendLine($"OS Version: {DeviceInfo.VersionString}");

                return deviceInfo.ToString();
            }
        }

    }
}
