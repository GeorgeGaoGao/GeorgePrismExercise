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
        public string Title { get; set; } = "20261002 national day holilday";
        public MainWindowViewModel(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion("HeaderRegion", "HeaderView");
        }
    }
}
