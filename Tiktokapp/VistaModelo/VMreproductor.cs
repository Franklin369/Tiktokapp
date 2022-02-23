using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Tiktokapp.Modelo;
using Tiktokapp.Datos;
using System.Linq;
namespace Tiktokapp.VistaModelo
{
   public class VMreproductor:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<Mvideos> _listavideos;
        bool _indicadorIconoPlay;
        bool _indicador;
        #endregion
        #region CONSTRUCTOR
        public VMreproductor(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarvideos();
        }
        #endregion
        #region OBJETOS
        public bool Indicador
        {
            get { return _indicador; }
            set { SetValue(ref _indicador, value); }

        }
        public bool IndicadorIconoPlay
        {
            get { return _indicadorIconoPlay; }
            set { SetValue(ref _indicadorIconoPlay, value); }
        }
        public ObservableCollection<Mvideos> Listavideos
        {
            get { return _listavideos; }
            set { SetValue(ref _listavideos, value); }
        }
        #endregion
        #region PROCESOS
        public void Mostrarvideos()
        {
            Listavideos = new ObservableCollection<Mvideos>(Dvideos.Mostrarvideos());
        }
        public void Seleccionar(Mvideos parametros)
        {
            var index = Listavideos
                .ToList()
                .FindIndex(p => p.Video == parametros.Video);
            Indicador = Listavideos[index].Indicador;
            if(Indicador==true)
            {
                Listavideos[index].Indicador = false;
                Listavideos[index].IndicadorIconoplay = true;
            }
            else
            {
                Listavideos[index].Indicador = true;
                Listavideos[index].IndicadorIconoplay = false;
            }
        }
        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Seleccionarcommand => new Command<Mvideos>((p)=>Seleccionar(p));
        #endregion
    }
}
