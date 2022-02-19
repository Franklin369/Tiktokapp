using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tiktokapp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reproductor : ContentPage
    {
        public Reproductor()
        {
            InitializeComponent();
            rvideo.Source = "https://firebasestorage.googleapis.com/v0/b/tiktokapp-19e96.appspot.com/o/messi.mp4?alt=media&token=64e4b1f1-9b89-4e80-886f-c80d51f8a47f";
        }
    }
}