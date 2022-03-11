using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace Tiktokapp.Triggers.Treproductor
{
    public class Tstoprotar : TriggerAction<Grid>
    {
        protected override async void Invoke(Grid sender)
        {
            await sender.RotateTo(0, 0);
        }
    }
}
