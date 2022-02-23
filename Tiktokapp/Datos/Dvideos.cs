using System;
using System.Collections.Generic;
using System.Text;
using Tiktokapp.Modelo;
using System.Collections.ObjectModel;
namespace Tiktokapp.Datos
{
   public class Dvideos
    {
        public static ObservableCollection<Mvideos> Mostrarvideos()
        {
            return new ObservableCollection<Mvideos>()
            {
                new Mvideos()
                {
                    Video="https://firebasestorage.googleapis.com/v0/b/tiktokapp-19e96.appspot.com/o/video1.mp4?alt=media&token=bf4f4c79-e88f-415e-9013-c0103d8d4ec6"
                    ,Indicador=true
                    ,IndicadorIconoplay=false
                },
                new Mvideos()
                {
                    Video="https://firebasestorage.googleapis.com/v0/b/tiktokapp-19e96.appspot.com/o/messi.mp4?alt=media&token=64e4b1f1-9b89-4e80-886f-c80d51f8a47f"
                    ,Indicador=true
                    ,IndicadorIconoplay=false
                },
                new Mvideos()
                {
                    Video="https://firebasestorage.googleapis.com/v0/b/tiktokapp-19e96.appspot.com/o/video2.mp4?alt=media&token=710ff355-aa47-4093-945d-0100d5ff5f10"
                    ,Indicador=true
                    ,IndicadorIconoplay=false
                },
            };
        }
    }
}
