﻿using CinemaApp_JIJ.Models;
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
	public partial class FuncionesPage : ContentPage
	{
		public FuncionesPage (Pelicula FuncionPelicula)
		{
            InitializeComponent();
            BindingContext = FuncionPelicula;
            var peliculaElegida = new Pelicula();
            peliculaElegida = FuncionPelicula;
        }
        private async void Item_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var funcionSeleccionada = e.SelectedItem as Funcion;
            if (CantidadBoletas.Text == null)
            {
                DisplayAlert("ERROR", "Digite Cantidad de Boletas", "OK");
                return;
            }
            int boletas = Convert.ToInt32(CantidadBoletas.Text);



            await Navigation.PushAsync(new ResumenComprasPage(funcionSeleccionada));
        }

    }
}