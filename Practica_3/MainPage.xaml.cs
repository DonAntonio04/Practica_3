using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Criticar(object sender, EventArgs e)
        {
            string opciones = "";
            string nombre = Nombre.Text;
            string genero = "";

            if (Hombre.IsChecked)
            {
                genero = "Hombre";
                if (Alto.IsChecked)
                {
                    opciones += ", Alto";
                }
                if (Feo.IsChecked)
                {
                    opciones += ", Feo";
                }
                if (Listo.IsChecked)
                {
                    opciones += ", Listo";
                }
                if (Extravagante.IsChecked)
                {
                    opciones += ", Extravagante";
                }
                if (Raro.IsChecked)
                {
                    opciones += ", Raro";
                }
                if (Grande.IsChecked)
                {
                    opciones += ", Grande";
                }
            }
            if (Mujer.IsChecked)
            {
                genero = "Mujer";

                if (Alto.IsChecked)
                {
                    opciones += ", Alta";

                }
                if (Feo.IsChecked)
                {
                    opciones += ", Fea";
                }
                if (Listo.IsChecked)
                {
                    opciones += ", Lista";
                }
                if (Extravagante.IsChecked)
                {
                    opciones += ", Extravagante";
                }

                if (Raro.IsChecked)
                {
                    opciones += ", Rara";
                }
                if (Grande.IsChecked)
                {
                    opciones += ", Grande";
                }

            }
            if (opciones == null || opciones == "")
            {
                opciones = opciones.Substring(2);

            }
            opciones = opciones.Replace(",", ",");
            int index = opciones.LastIndexOf(',');
            if (index != -1)
            {
                opciones = opciones.Remove(index, 1).Insert(index, " y");
            }

            string mensaje = $"{nombre} es {genero}{opciones}.";

            Resultado.Text = mensaje;
        }
    }
}
