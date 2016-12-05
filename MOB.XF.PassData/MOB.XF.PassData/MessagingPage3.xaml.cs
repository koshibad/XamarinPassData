using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.XF.PassData
{
    public partial class MessagingPage3 : ContentPage
    {
        public MessagingPage3()
        {
            InitializeComponent();

            AtivarCentroMensagens();
        }

        public void AtivarCentroMensagens()
        {
            MessagingCenter.Subscribe<MessagingPage1, Professor>(this,
                ViewModelBasePassingData.TipoNav.Alterar.ToString(),
                (navParam, paraViewModel) =>
                {
                    BindingContext = paraViewModel;
                    MessagingCenter.Unsubscribe<MessagingPage1, Professor>(this,
                        ViewModelBasePassingData.TipoNav.Alterar.ToString());
                });
        }
    }
}
