
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SumaAppMvvm
{
   
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();
                BindingContext = new MainPageViewModel();
            }

            private void Sumar_Clicked(object sender, EventArgs e)
            {
                ((MainPageViewModel)BindingContext).Sumar();
            }

            private void Limpiar_Clicked(object sender, EventArgs e)
            {
                ((MainPageViewModel)BindingContext).Limpiar();
            }
        }

}


