﻿using System;
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
		public PlatformImagePage ()
		{
			InitializeComponent ();

         btn.Image = (FileImageSource) ImageSource.FromFile("clock.png");

		}
	}
}