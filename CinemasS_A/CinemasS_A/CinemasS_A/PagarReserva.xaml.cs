using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemasS_A
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PagarReserva : ContentPage
	{
		public PagarReserva ()
		{
			InitializeComponent ();
            BPagarReservaEnEfectivo.Clicked += BPagarReservaEnEfectivo_Clicked;
            BPagarReservaConTarjeta.Clicked += BPagarReservaConTarjeta_Clicked;


        }

        private void BPagarReservaConTarjeta_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PagarReservaConTarjeta());
        }

        private void BPagarReservaEnEfectivo_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PagarReservaEnEfectivo());
        }
    }
}