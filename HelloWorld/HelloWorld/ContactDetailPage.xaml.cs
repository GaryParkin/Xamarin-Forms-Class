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
   public partial class ContactDetailPage : ContentPage
   {
      public ContactDetailPage(Contact contact)
      {

         //if (contact == null)
         //   throw new ArgumentNullException();
         //BindingContext = contact;

         // VS has a better way to do this!
         BindingContext = contact ?? throw new ArgumentNullException();

         InitializeComponent();
      }
   }
}