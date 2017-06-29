using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class PlatformImagePage : ContentPage
   {
      public PlatformImagePage()
      {
         InitializeComponent();

         // btn.Image = (FileImageSource) ImageSource.FromFile("clock.png");

         // Device.OnPlatform is obsolete
         //btn.Image = (FileImageSource)ImageSource.FromFile(Device.OnPlatform(
         //   iOS: "clock.png",
         //   Android: "clock.png",
         //   WinPhone: "images/clock.png"
         //   ));

         switch (Device.RuntimePlatform)
         {
            case Device.iOS:
               btn.Image = (FileImageSource)ImageSource.FromFile("clock.png");
               break;
            case Device.Android:
               btn.Image = (FileImageSource)ImageSource.FromFile("clock.png");
               break;
            case Device.Windows:
               btn.Image = (FileImageSource)ImageSource.FromFile("images/clock.png");
               break;
         }


      }
   }
}