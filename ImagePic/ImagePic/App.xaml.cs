using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ImagePic
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            MainPage = new ImagePic.MainPage();
            var image = new Image { Source = "gentlemen.jpg" };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
