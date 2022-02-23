using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace Tiktokapp.Triggers.Treproductor
{
    internal class Ticonplay : TriggerAction<Image>
    {
        public bool Indicador { get; set; }
        protected override async void Invoke(Image sender)
        {
            if(Indicador==true)
            {
                await sender.ScaleTo(1.8, 50, Easing.Linear);
                await sender.ScaleTo(1, 50, Easing.Linear);
            }
            else
            {
                sender.Scale = new Image().Scale;
            }
        }
    }
}
