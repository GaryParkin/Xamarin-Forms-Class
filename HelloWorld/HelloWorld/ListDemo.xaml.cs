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

         listView.ItemsSource = new List<ContactGroup>
         {
            new ContactGroup("M", "M")
            {
            new Contact {Name = "Mosh", ImageUrl="http://lorempixel.com/100/100/people/1"},
            },
            new ContactGroup("J", "J")
            {
            new Contact {Name = "John", ImageUrl="http://lorempixel.com/100/100/people/2", Status="Hey, let's talk"}
            }
         };




      }
   }
}