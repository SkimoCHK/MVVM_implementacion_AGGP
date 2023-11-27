﻿using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using MVVM_implementacion_AGGP.Modelo;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_AGGP.VistaModelo
{
    public class VMpage2 : BaseViewModel
    {

        #region VARIABLES
        string _Texto;
        public List<Musuarios> listausuarios { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMpage2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }
        #endregion
        #region OBJETOS

        public string Texto
        {
            get { return _Texto; }
            set { SetValue (ref _Texto, value); }

        }

        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre = "Frank",
                    Imagen = "https://i.ibb.co/3fVpTWR/frankenstein.png"
                },
                new Musuarios
                {
                    Nombre = "Juan",
                    Imagen = "https://i.ibb.co/HYh2G6j/momia.png"
                },
                new Musuarios
                {
                    Nombre = "Carlos",
                    Imagen = "https://i.ibb.co/c2dSWqB/zombi.png"
                }

            };

        }

        #endregion
        #region PROCESOS

        public async Task Volver()
        {

            await Navigation.PopAsync();

        }
        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "Ok");
        }

        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());

        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Alertacommand => new Command <Musuarios>(async (p) => await Alerta(p));

        #endregion

    }
}
