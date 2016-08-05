using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AdaptiveTriggerSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MyViewModel ViewModel{get;set;}
        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = new MyViewModel();
            ViewModel.IsPaneOpen = true;
            this.DataContext = ViewModel;
        }

        private void myBtn_Click(object sender, RoutedEventArgs e)
        {
            LayoutSplitView.IsPaneOpen = !LayoutSplitView.IsPaneOpen;
        }
    }

    public class MyViewModel
    {
        public bool IsPaneOpen { get; set; }
    }
}
