using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MVVM_implementacion_AGGP.Modelo;
using MVVM_implementacion_AGGP.Vistas.Pokemon;
using System.Windows.Input;
using System.Data;
using MVVM_implementacion_AGGP.Datos;
using System.Collections.ObjectModel;

namespace MVVM_implementacion_AGGP.VistaModelo.VMpokemon
{
    public class VMlistapokmeon : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<Mpokemon> _Listpokemon;
        #endregion
        #region CONSTRUCTOR

        public VMlistapokmeon(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpokemon();
        }

        #endregion
        #region OBJETOS

        public ObservableCollection<Mpokemon> Listapokemon
        {
            get { return _Listpokemon; }
            set { SetValue(ref _Listpokemon, value);
                OnpropertyChanged();
            }
            

        }
        #endregion
        #region PROCESOS

        public async Task Mostrarpokemon()
        {
            var funcion = new Dpokemon();
            Listapokemon = await funcion.MostrarPokemones();
        }

        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new Registrarpokemon());
        }

        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Iraregistrocommmand => new Command(async () => await Iraregistro());

        public ICommand ProcesoSimpcommmand => new Command(ProcesoSimple);

        #endregion

    }
}
