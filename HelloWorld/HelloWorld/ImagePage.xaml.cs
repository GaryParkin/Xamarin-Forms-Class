using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Reflection;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

         //image.Source = ImageSource.FromResource("HelloWorld.background.jpg");

         //var embeddedImage = new Image { Aspect = Aspect.AspectFit };
         //image.Source = ImageSource.FromResource("HelloWorld.images.background.jpg");

         //var assembly = typeof(EmbeddedImages).GetTypeInfo().Assembly;
         //foreach (var res in assembly.GetManifestResourceNames())
         //{
         //   System.Diagnostics.Debug.WriteLine("found resource: " + res);
         //}

         //var embeddedImage = new Image { Aspect = Aspect.AspectFit };
         //image.Source = ImageSource.FromResource("smallbk.jpg");

      }
	}
}