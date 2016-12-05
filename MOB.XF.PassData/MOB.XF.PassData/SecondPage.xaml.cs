using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.XF.PassData
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        protected async void OnNavigateButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
        }
    }
}
