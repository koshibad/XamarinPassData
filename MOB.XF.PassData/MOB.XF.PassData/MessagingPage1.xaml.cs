using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.XF.PassData
{
    public partial class MessagingPage1 : ContentPage
    {
        public MessagingPage1()
        {
            InitializeComponent();

            AtivarCentroMensagens();
        }

        private void AtivarCentroMensagens()
        {
            MessagingCenter.Subscribe<MessagingPage1>(this, "MensagemCode",
            (sender) => { lblBoasVindas.Text = "Continue..."; });
        }

        protected async void OnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MessagingPage2());
        }

        protected async void OnClickedPassViewModel(object sender, EventArgs args)
        {
            var page = new MessagingPage3();
            await Navigation.PushAsync(page);

            Professor prof = new Professor()
            {
                Nome = "no",
                Titulo = "ti",
                Disciplina = "di",
                Pais = "pa"
            };

            MessagingCenter.Send<MessagingPage1, Professor>(this,
                ViewModelBasePassingData.TipoNav.Alterar.ToString(), prof);
        }
    }
}
