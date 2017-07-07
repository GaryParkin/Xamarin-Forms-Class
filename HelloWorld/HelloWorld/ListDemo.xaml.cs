using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelloWorld.Models;

namespace HelloWorld
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class ListDemo : ContentPage
   {
      public ListDemo()
      {
         InitializeComponent();

         List<string> names = new List<string>
         {
            "Mosh",
            "John",
            "Bob"
         };

         listView.ItemsSource = new List<Contact>
         {
            new Contact {Name = "Mosh", ImageUrl="http://lorempixel.com/100/100/people/1"},
            new Contact {Name = "John", ImageUrl="http://lorempixel.com/100/100/people/2", Status="hey, let's talk"}
         };

      }

      // IOS works differently then Android.  
      // In IOS the first time you click the row, you get the Selected event.  The next time you only get the Tapped event.
      // In Android, the first time you click the row, you get both events. Tapped, then Selected, and it makes no difference what order they are.
      // And the next time you only get the Tapped event.

      private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
      {
         Contact contact = e.Item as Contact;
         DisplayAlert("Tapped", contact.Name, "OK");

      }

      private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
      {
         Contact contact = e.SelectedItem as Contact;
         DisplayAlert("Selected", contact.Name, "OK");

         // This would disable the selection - The above code also needs to be commented out if you use this
         // You'd use this to tap the row and keep it from being selected.
         // listView.SelectedItem = null;
      }

   }
}