using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

      private void ToolbarItem1_Activated(object sender, EventArgs e)
      {
         DisplayAlert("Activated", "ToolbarItem1 Activated", "OK");
      }
      private void ToolbarItem2_Activated(object sender, EventArgs e)
      {
         DisplayAlert("Activated", "ToolbarItem2 Activated", "OK");
      }
      private void MenuItem1_Activated(object sender, EventArgs e)
      {
         DisplayAlert("Activated", "MenuItem1 Activated", "OK");
      }
      private void MenuItem2_Activated(object sender, EventArgs e)
      {
         DisplayAlert("Activated", "MenuItem2 Activated", "OK");
      }
      private void MenuItem3_Activated(object sender, EventArgs e)
      {
         DisplayAlert("Activated", "MenuItem3 Activated", "OK");
      }
   }
}
