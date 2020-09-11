using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinXAML.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Styling : ContentPage
    {
        public Styling()
        {
            InitializeComponent();
            Resources["dynamicLabelStyle"] = Resources["labelBlueStyle"];
        }

        private void SwitchToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
                Resources["dynamicLabelStyle"] = Resources["labelRedStyle"];
            else
                Resources["dynamicLabelStyle"] = Resources["labelBlueStyle"];
        }
    }
}