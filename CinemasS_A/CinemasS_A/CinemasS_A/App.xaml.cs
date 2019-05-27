using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CinemasS_A
{
    public partial class App : Application
    {
        public NavigationPage Page { get; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            Page = new NavigationPage(new CrearTarjeta());
            Page = new NavigationPage(new RecargarTarjeta());
            Page = new NavigationPage(new CrearReserva());
            Page = new NavigationPage(new EliminarReserva());
            Page = new NavigationPage(new PagarReserva());
            Page = new NavigationPage(new PagarReservaEnEfectivo());
            Page = new NavigationPage(new PagarReservaConTarjeta());
            Page = new NavigationPage(new VisualizarSillas());
            Page = new NavigationPage(new VisualizarDineroCaja());
            Page = new NavigationPage(new Registro());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
