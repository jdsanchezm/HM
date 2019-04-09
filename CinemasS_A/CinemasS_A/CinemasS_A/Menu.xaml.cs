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
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
            BCrearTarjeta.Clicked += BCrearTarjeta_Clicked;
            BRecargarTarjeta.Clicked += BRecargarTarjeta_Clicked;
            BCrearReserva.Clicked += BCrearReserva_Clicked;
            BEliminarReserva.Clicked += BEliminarReserva_Clicked;
            BPagarReservaEnEfectivo.Clicked += BPagarReservaEnEfectivo_Clicked;
            BPagarReservaConTarjeta.Clicked += BPagarReservaConTarjeta_Clicked;
            BVisualizarSillas.Clicked += BVisualizarSillas_Clicked;
            BVisualizarDinero.Clicked += BVisualizarDinero_Clicked;
        }

        private void BVisualizarDinero_Clicked(object sender, EventArgs e)
        {
           ((NavigationPage)this.Parent).PushAsync(new VisualizarDineroCaja());
        }

        private void BVisualizarSillas_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new VisualizarSillas());
        }

        private void BPagarReservaConTarjeta_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PagarReservaConTarjeta());
        }

        private void BPagarReservaEnEfectivo_Clicked(object sender, EventArgs e)
        {
           ((NavigationPage)this.Parent).PushAsync(new PagarReservaEnEfectivo());
        }

        private void BEliminarReserva_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new EliminarReserva());
        }

        private void BCrearReserva_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new CrearReserva());

        }

        private void BRecargarTarjeta_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new RecargarTarjeta());
        }

        private void BCrearTarjeta_Clicked(object sender, EventArgs e)
        {
              ((NavigationPage)this.Parent).PushAsync(new CrearTarjeta());
        }
    }
}