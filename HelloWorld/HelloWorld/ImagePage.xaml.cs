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
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

         // If you do this in xaml, the image will be cashed for 24 hours, so we do it here
         UriImageSource imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };

         // This removes casching
         imageSource.CachingEnabled = false;

         // We could set the length of casching to 1 hour
         //imageSource.CacheValidity = TimeSpan.FromHours(1);

         image.Source = imageSource;
		}
	}
}