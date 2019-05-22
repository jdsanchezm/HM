using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InterfazGrafica
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //Declaracion variables
            int taquilla = 0, boleta = 9000, disponible = 0, noBoletas = 0, fila, columna;

            //Declaracion e inicializacion de la matriz
            bool[,] sillas = new bool[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sillas[i, j] = false;
                }
            }

            //Venta
            Console.WriteLine("Venta\nNo de Boletas a comprar: ");
            noBoletas = int.Parse(Console.ReadLine());
            do
            {
                for (int i = 0; i < noBoletas; i++)
                {
                    Console.WriteLine("\nNo de fila: ");
                    do
                    {
                        fila = int.Parse(Console.ReadLine());
                    } while (fila <= 3 || fila > 0);
                    Console.WriteLine("\nNo de columna: ");
                    do
                    {
                        columna = int.Parse(Console.ReadLine());
                    } while (columna <= 4 || columna > 0);
                    sillas[fila, columna] = true;
                }
            } while (noBoletas <= 8 || noBoletas > 0);

            //Buscar valor en Taquilla
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (sillas[i, j] == true)
                    {
                        disponible = disponible + 1;
                    }
                }
            }
            taquilla = taquilla + boleta * disponible;
            Console.WriteLine("Taquilla: " + taquilla);
            Console.ReadLine();
        }
    }
}
