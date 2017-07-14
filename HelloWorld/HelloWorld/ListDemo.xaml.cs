using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelloWorld.Models;
using System.Collections.ObjectModel;

namespace HelloWorld
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class ListDemo : ContentPage
   {
      // We use this so that the ListView will be notified of any changes and refresh itself.
      private ObservableCollection<Contact> _contacts;

      public ListDemo()
      {
         InitializeComponent();

         _contacts = new ObservableCollection<Contact>
         {
            new Contact {Name = "Mosh", ImageUrl="http://lorempixel.com/100/100/people/1"},
            new Contact {Name = "John", ImageUrl="http://lorempixel.com/100/100/people/2", Status="hey, let's talk"},
            new Contact {Name = "Gary", ImageUrl="http://lorempixel.com/100/100/people/3"}
         };

         listView.ItemsSource = _contacts;
      }

      // This does not work as expected on Android as it does on IOS.
      // IOS you can slide open the context menu, but in Android, you hold tap and it appears at the top.

      private void Call_Clicked(object sender, EventArgs e)
      {
         MenuItem menuItem = sender as MenuItem;
         Contact contact = menuItem.CommandParameter as Contact;

         DisplayAlert("Call", contact.Name, "OK");
      }

      private void Delete_Clicked(object sender, EventArgs e)
      {
         // Cleaner code
         Contact contact = (sender as MenuItem).CommandParameter as Contact;
         _contacts.Remove(contact);
         // The above code doesn't notify the list that it's been changed 
         //   so we have to use an ObservableCollection
      }
   }
}