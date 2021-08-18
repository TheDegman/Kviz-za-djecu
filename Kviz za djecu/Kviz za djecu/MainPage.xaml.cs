using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kviz_za_djecu
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PrvoPitanje());
        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ONama());
        }
    }
}
