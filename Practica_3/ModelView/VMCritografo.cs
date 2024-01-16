using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica_3.ModelView
{
     public class VMCritografo : BaseViewModel
     {
        #region VARIABLES
        public string _Mensaje;
        public string _Nombre;
        public string _Resultado;
        public bool _Hombre;
        public bool _Mujer;
        public bool _Alto;
        public bool _Feo;
        public bool _Listo;
        public bool _Extravagante;
        public bool _Raro;
        public bool _Grande;
        #endregion
        #region CONSTRUCTOR
         public VMCritografo(INavigation navigation)
         {
            Navigation = navigation;
         }
        #endregion
        #region OBJETOS
         public string Mensaje
         {
            get { return _Mensaje; }
            set {SetValue(ref _Mensaje, value); }
         }
        public string Nombre
        {
            get { return _Nombre; }
            set { SetValue(ref _Nombre, value);}
        }
        public string Resultado
        {
            get { return _Resultado; }
            set {  SetValue(ref _Resultado, value);}
        }
          public bool Hombre
        {
            get { return _Hombre; }
            set { SetValue(ref _Hombre, value);}
        }
        public bool Mujer
        {
            get { return _Mujer; }
            set { SetValue(ref _Mujer, value); }
        }
        public bool Alto
        {
            get { return _Alto; }
            set { SetValue(ref _Alto, value); }
        }
        public bool Feo
        {
            get { return _Feo; }
            set { SetValue(ref _Feo, value); }
        }
        public bool Listo
        {
            get { return _Listo; }
            set { SetValue(ref _Listo, value); }
        }
        public bool Extravagante
        {
            get { return _Extravagante; }
            set { SetValue(ref _Extravagante, value); }
        }
        public bool Raro
        {
            get { return _Raro; }
            set { SetValue(ref _Raro, value); }
        }
        public bool Grande
        {
            get { return _Grande; }
            set { SetValue(ref _Grande, value); }
        }
        #endregion

        #region PROCESO
        public async void Opciones()
        {
            string opciones = "";
            string nombre = Nombre;
            string genero = "";
            if(Hombre == true)
            {
                genero = "Hombre";
                if(Alto== true)
                {
                    opciones += ", Alto";
                }
                if(Feo == true)
                {
                    opciones += ", Feo";
                }
                if(Listo == true)
                {
                    opciones += ", Listo";
                }
                if(Extravagante == true)
                {
                    opciones += ", Extravagante";
                }
                if(Raro == true)
                {
                    opciones += ", Raro";
                }
                if(Grande == true)
                {
                    opciones += ", Grande";
                }
            }
            if (Mujer == true)
            {
                genero = "Mujer";
                if (Alto == true)
                {
                    opciones += ", Alta";
                }
                if (Feo == true)
                {
                    opciones += ", Fea";
                }
                if (Listo == true)
                {
                    opciones += ", Lista";
                }
                if (Extravagante == true)
                {
                    opciones += ", Extravagante";
                }
                if (Raro == true)
                {
                    opciones += ", Rara";
                }
                if (Grande == true)
                {
                    opciones += ", Grande";
                }

            }
            if (opciones == null || opciones == "")
            {
                opciones = opciones.Substring(2);

            }

            string mensaje = $"{Nombre} es {genero}{opciones}.";

            Resultado = mensaje;
        }
        #endregion
        #region COMANDOS
        public ICommand CalcularOpcionescommand => new Command(Opciones);
        #endregion
    }
}
