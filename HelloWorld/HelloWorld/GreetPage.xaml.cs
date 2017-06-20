using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class GreetPage : ContentPage
   {

      private List<string> quotes;
      private int counter;

      public GreetPage()
      {
         InitializeComponent();

         counter = 0;
         quotes = new List<string>
         {
            "Whenever I think of the past, it brings back so many memories",
            "The Bermuda Triangle got tired of warm weather. It moved to Alaska. Now Santa Claus is missing",
            "You can't have everything. Where would you put it?"
         };

         txtQuote.Text = quotes[0];
         counter++;
      }


      private void btnNext_Clicked(object sender, EventArgs e)
      {
         string quote = quotes[counter];
         txtQuote.Text = quote;

         if (counter < quotes.Count - 1)
            counter++;
         else
            counter = 0;

      }
   }
}