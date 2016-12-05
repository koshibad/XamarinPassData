using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.XF.PassData
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(string data)
        {
            InitializeComponent();

            this.lblData.Text = data;
        }

        protected async void OnNavigateButtonClicked(object sender, EventArgs args)
        {
            Professor prof = new Professor()
            {
                Nome = "no",
                Titulo = "ti",
                Disciplina = "di",
                Pais = "pa"
            };

            await Navigation.PushAsync(new SecondPage()
            {
                BindingContext = prof
            });
        }

        protected async void OnMessagingButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MessagingPage1());
        }
    }
}
