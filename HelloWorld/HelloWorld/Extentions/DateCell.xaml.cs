using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// Don't forget to change the namespace
namespace HelloWorld
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class DateCell : ViewCell
   {
      // This makes this have a Bindable Property
      // https://developer.xamarin.com/api/type/Xamarin.Forms.Label/

      // The name LabelProperty is a convention: Label is the property and Property is the ending part
      // Label is the property, return type is string and the declaring type is the class name
      public static readonly BindableProperty LabelProperty =
         BindableProperty.Create("Label", typeof(string), typeof(DateCell));

      public string Label
      {
         // LableProperty is the name defined above
         get { return (string) GetValue(LabelProperty); }
         set { SetValue(LabelProperty, value); }
      }

      public DateCell()
      {
         InitializeComponent();

         BindingContext = this;
      }
   }
}