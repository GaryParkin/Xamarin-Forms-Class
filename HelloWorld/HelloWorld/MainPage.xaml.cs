using System;
using Xamarin.Forms;

namespace HelloWorld
{
   public partial class MainPage : ContentPage
   {
      public MainPage()
      {
         InitializeComponent();
      }

      private async void Button_Clicked(object sender, EventArgs e)
      {
         var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");
         if (response)
            await DisplayAlert("Done", "Your response will be saved", "OK");
      }

      private async void Button_Clicked_1(object sender, EventArgs e)
      {
         var response = await DisplayActionSheet("title", "Cancel", "Delete", "Copy Link", "Message", "email");
         await DisplayAlert("Response", response, "OK");

      }
   }
}
