using CinemaApp_JIJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaApp_JIJ.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResumenComprasPage : ContentPage
	{
		public ResumenComprasPage (ResumenCompra resumen)
		{
			InitializeComponent ();
            BindingContext = resumen;
		}

        private void Button_Clicked(object sender, EventArgs e)

              {
            
             
                DisplayAlert("REALIZADA", "lA RESERVA SE HA GENERADO CORRECTAMENTE", "OK");
                return;
            }
    }
}