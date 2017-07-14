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
      IEnumerable<Contact> GetContacts(string searchText = null)
      {
         IEnumerable<Contact> contacts = new List<Contact> {
                     new Contact {Name = "Mosh", ImageUrl="http://lorempixel.com/100/100/people/1"},
                     new Contact {Name = "John", ImageUrl="http://lorempixel.com/100/100/people/2", Status="hey, let's talk"},
                     new Contact {Name = "Jim", ImageUrl="http://lorempixel.com/100/100/people/3"},
                     new Contact {Name = "Joey", ImageUrl="http://lorempixel.com/100/100/people/4", Status="Yo, Joey!"}
                  };

         if (String.IsNullOrWhiteSpace(searchText))
            return contacts;

         return contacts.Where(c => c.Name.StartsWith(searchText, StringComparison.OrdinalIgnoreCase));
      }

      public ListDemo()
      {
         InitializeComponent();

         listView.ItemsSource = GetContacts();
      }

      private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
      {
         listView.ItemsSource = GetContacts(e.NewTextValue);
      }
   }
}