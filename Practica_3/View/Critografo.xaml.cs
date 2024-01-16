using Practica_3.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_3.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Critografo : ContentPage
    {
        public Critografo()
        {
            InitializeComponent();
            BindingContext = new VMCritografo(Navigation);
        }
    }
}