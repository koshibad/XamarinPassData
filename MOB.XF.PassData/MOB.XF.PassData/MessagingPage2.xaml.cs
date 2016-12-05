using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.XF.PassData
{
    public partial class MessagingPage2 : ContentPage
    {
        public MessagingPage2()
        {
            InitializeComponent();
        }

        protected async void OnClicked(object sender, EventArgs args)
        {
            MessagingCenter.Send<MessagingPage1>(new MessagingPage1(), "MensagemCode");
            await Navigation.PopAsync();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
