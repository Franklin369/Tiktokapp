using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Octane.Xamarin.Forms.VideoPlayer;
namespace Tiktokapp.Triggers.Treproductor
{
    public class Treprovideo : TriggerAction<VideoPlayer>
    {
        public bool Indicador { get; set; }
        protected override void Invoke(VideoPlayer sender)
        {
           if(Indicador==true)
            {
                sender.Play();
            }
           else
            {
                sender.Pause();
            }
        }
    }
}
