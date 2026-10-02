using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GeorgePrismExercise.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _timeOfGettingContent;

        public string TimeOfGettingContent
        {
            get { return _timeOfGettingContent; }
            set { _timeOfGettingContent = value; RaisePropertyChanged(); }
        }
        public ICommand GetContentCommand => new DelegateCommand(
            () =>
            {
                System.Diagnostics.Process.Start(
                    new ProcessStartInfo
                    {
                        //FileName = "http://github.com/georgegaogao/georgehostexercise.git",
                        //FileName="http://github.com/prism",
                        //FileName = "http://github.com/georgegaogao",
                        FileName = "http://github.com/dotnet/wpf",

                        UseShellExecute = true
                    }
                    );
                TimeOfGettingContent = DateTime.Now.ToString();
            }
            );
        public ICommand TextBlockMouseupCommand => new DelegateCommand(
            () =>
            {
                MessageBox.Show("you clicked me");
            }
            );
        public ICommand TextBlockMouseupCommandWithParameter => new DelegateCommand<TextBlock> (
            (textblock) =>
            {
                MessageBox.Show($"the time is {textblock.Text}");
            }
            );
        public string Title { get; set; } = "20261002 national day holilday";
    }
}
