using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImagePic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage


    {

        
        public Page1()
        {
            InitializeComponent();
            //var embeddedImage = new Image { Source = ImageSource.FromResource("WorkingWithImages.beach.jpg") };
        }
    }
}