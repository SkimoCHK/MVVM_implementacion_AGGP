using MVVM_implementacion_AGGP.Modelo;
using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using MVVM_implementacion_AGGP.Vistas;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_AGGP.VistaModelo
{
    class VMmenuprincipal : BaseViewModel
    {

        #region VARIABLES
        string _Texto;
        public List<Mmenuprincipal> listapaginas { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpaginas();
        }
        #endregion
        #region OBJETOS

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }

        }

        public void Mostrarpaginas()
        {
            listapaginas = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina = "Entry, datapicker, picker, label, navegacion",
                    Icono = "https://i.ibb.co/1T1PxMM/Charigod.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "CollectionView sin enlace a Base de datos",
                    Icono = "https://i.ibb.co/6YmxBnN/Venousor.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "Crud Pokemon",
                    Icono = "https://i.ibb.co/h7S65s7/Blastoise.png"
                }

            };

        }

        #endregion
        #region PROCESOS

        public async Task Volver()
        {

            await Navigation.PopAsync();

        }
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, datapicker"))
            {
                await Navigation.PushAsync(new pagina1());
            }
            if(pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Page2());
            }
            if(pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }

        }

        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        //public ICommand Volvercommand => new Command(async () => await Volver());

        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));

        #endregion


    }
}
