using System;
using System.Collections.Generic;
using System.Text;
using Tiktokapp.VistaModelo;
namespace Tiktokapp.Modelo
{
   public class Mvideos:BaseViewModel
    {
        public string Video { get; set; }
        public bool _indicador;
        public bool Indicador
        {
            get { return _indicador; }
            set { SetValue(ref _indicador, value); }
        }


        public bool _indicadorIconoplay;
        public bool IndicadorIconoplay
        {
            get { return _indicadorIconoplay; }
            set { SetValue(ref _indicadorIconoplay, value); }
        }
    }
}
