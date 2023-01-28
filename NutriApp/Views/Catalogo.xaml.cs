using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NutriApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Catalogo : ContentPage
    {
        public Catalogo()
        {
            InitializeComponent();
            //EventListView.ItemTapped += (object sender, ItemTappedEventArgs e) => {
            //        // don't do anything if we just de-selected the row.
            //        if (e.Item == null) return;

            //        if (sender is ListView lv) lv.SelectedItem = null;
            //    };
        }

        private async void BtnImc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IMC());

        }
    }
}