using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin_example
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("You clicked", "Yay", "Ok");
        }
    }
}

