using System;
using System.ComponentModel;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DatePickerFlyout
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        private string text;
        private DateTimeOffset datePickerDate;
        private DateTimeOffset datePickerFlyoutDate;

        public string Text
        {
            get => text;
            set
            {
                text = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Text)));
            }
        }

        public DateTimeOffset DatePickerDate
        {
            get => datePickerDate;
            set
            {
                datePickerDate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DatePickerDate)));
            }
        }

        public DateTimeOffset DatePickerFlyoutDate
        {
            get => datePickerFlyoutDate;
            set
            {
                datePickerFlyoutDate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DatePickerFlyoutDate)));
            }
        }

        public new event PropertyChangedEventHandler PropertyChanged;

        public MainPage()
        {
            this.InitializeComponent();
            DataContext = this;
        }
    }
}
