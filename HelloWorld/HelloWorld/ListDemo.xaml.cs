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
      List<Contact> GetContacts()
      {
         return new List<Contact> {
                     new Contact {Name = "Mosh", ImageUrl="http://lorempixel.com/100/100/people/1"},
                     new Contact {Name = "John", ImageUrl="http://lorempixel.com/100/100/people/2", Status="hey, let's talk"}
                  };
      }

      public ListDemo()
      {
         InitializeComponent();


         listView.ItemsSource = GetContacts();
      }

      private void listView_Refreshing(object sender, EventArgs e)
      {
         listView.ItemsSource = GetContacts();

         listView.EndRefresh();
      }

   }
}