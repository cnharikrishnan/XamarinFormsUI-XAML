using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinXAML.View;

namespace XamarinXAML
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new DemoTabbedPage();
            //MainPage = new Styling();
        }
    }
}
