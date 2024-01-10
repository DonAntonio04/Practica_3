using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
            string nombre = Nombre.Text;

            string opciones = "";

            if(Alto.IsChecked)
            {
                opciones += "Alto,";
            }
             if(Feo.IsChecked)
            {
                opciones += "Feo,";
            }
             if(Listo.IsChecked)
            {
                opciones += "Listo,";
            }
             if(Extravagante.IsChecked)
            {
                opciones += "Extravagante,";
            }
             if(Raro.IsChecked)
            {
                opciones += "Raro,";
            }
             if (Grande.IsChecked)
            {
                opciones += "Grande,";
            }
          
            string mensaje = $"{nombre} es  {opciones}";
            Resultado.Text = mensaje;
        }
    }
}
