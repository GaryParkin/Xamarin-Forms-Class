using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace HelloWorld
{
   [Preserve(AllMembers = true)]
   [ContentProperty ("ResourceId")]
   public class EmbeddedImageExtension : IMarkupExtension
   {
      public string ResourceId { get; set; }

      public object ProvideValue(IServiceProvider serviceProvider)
      {
         if (string.IsNullOrWhiteSpace(ResourceId))
            return null;

         var imageSource = ImageSource.FromResource(ResourceId);

         return imageSource;
      }
   }
}
