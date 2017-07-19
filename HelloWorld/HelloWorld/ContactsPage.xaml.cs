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
   public partial class ContactsPage : ContentPage
   {
      public ContactsPage()
      {
         InitializeComponent();

         listView.ItemsSource = new List<Contact>
         {
            new Contact {Name = "Mosh", ImageUrl="http://lorempixel.com/100/100/people/1"},
            new Contact {Name = "John", ImageUrl="http://lorempixel.com/100/100/people/2", Status="hey, let's talk"}
};
      }

      private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
      {
         // This keeps the code from running again when the listView.SelectedItem = null
         if (e.SelectedItem == null)
            return;

         // Get the selected item and cast it to type Contact
         var contact = e.SelectedItem as Contact;
         
         // Send them to the ContactDetailPage
         await Navigation.PushAsync(new ContactDetailPage(contact));

         // Deselect the item in the list
         listView.SelectedItem = null;
      }
   }
}