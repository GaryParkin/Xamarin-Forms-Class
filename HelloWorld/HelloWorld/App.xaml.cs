using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

// Initial Hello World
namespace HelloWorld
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

         // IMPORTANT!  Don't just assign the page, use the NavigationPage
         MainPage = new NavigationPage(new ContactsPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
