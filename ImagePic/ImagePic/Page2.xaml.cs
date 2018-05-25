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
    public partial class Page2 : ContentPage
    {
        public String picURL="https://vignette.wikia.nocookie.net/finalfantasy/images/7/70/Kefka-boss-ffvi.png/revision/latest?cb=20101215194938";
        public Page2()
        {
            InitializeComponent();
            //
            var webImage = new Image {  };
            var buttonPic = new Button { };
        }

        private void PressMeButton_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "I was just clicked!";
        }
    }
}