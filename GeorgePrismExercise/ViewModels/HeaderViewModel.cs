using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace GeorgePrismExercise.ViewModels
{
    public class HeaderViewModel:BindableBase
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
        public ICommand TextBlockMouseUpCommand => new DelegateCommand(
            () =>
            {
                MessageBox.Show("you clicked me");
            }
            );
        public ICommand TextBlockMouseUpCommandWithParameter => new DelegateCommand<Window>(
            (window) =>
            {
                MessageBox.Show($"the title is {window.Title}");
            }
            );
       
    }
}
