using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana9_Vilchez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeBinding : ContentPage
    {
        public SwipeBinding()
        {
            InitializeComponent();
            BindingContext = new SwipeCommandPageViewModel();
        }
    }
}