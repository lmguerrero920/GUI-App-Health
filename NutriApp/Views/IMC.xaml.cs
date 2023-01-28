using Acr.UserDialogs;
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
    public partial class IMC : ContentPage
    {
        public IMC()
        {
            InitializeComponent();
        }

        private async void ButtonCalcular_Clicked(object sender, EventArgs e)
        {

            bool cancel = false;
            using (var dialog = UserDialogs.Instance.Progress("Procesando", () => cancel = true, "Cancelar"))
            {
                for (int i = 1; i < 10; i++)
                {
                    if (!cancel)
                    {
                        dialog.PercentComplete = i * 50;
                    }

                }

            }
            var altura = Convert.ToDecimal(Altura.Text);
            var peso = Convert.ToDecimal(Peso.Text); 
            if (!string.IsNullOrEmpty(Altura.Text) &&  !string.IsNullOrEmpty(Peso.Text))
            {
                

                decimal imc = 0;

                imc = peso /(altura * altura);

                decimal imcfinal = decimal.Round(imc,2); ;

                IMCS.Text = imcfinal.ToString();

                string result = "";
                if ( Convert.ToDouble(imc) < 18.5)
                {
                    result = "Tienes Bajo Peso";
                    mensaje.IsVisible = true;
                    mensaje.TextColor = Xamarin.Forms.Color.YellowGreen;
                    mensaje.Text = "Debes realizar una dieta rigurosa,recuerda que los habitos saludables " +
                        "minimizan los riesgos cardiacos";
                }
                else if (Convert.ToDouble(imc) >= 18.5 && Convert.ToDouble(imc) <= 24.9)
                {
                    result = "Tienes Peso Normal";
                    mensaje.IsVisible = true;
                    mensaje.TextColor = Xamarin.Forms.Color.Green;
                    mensaje.Text = "Actalmente tienes un peso normal, sin embargo recuerda que los habitos saludables " +
                       "minimizan los riesgos cardiacos ¡no bajes la guardia!";
                }

                else if (Convert.ToDouble(imc) >= 25 && Convert.ToDouble(imc) <= 29.9)
                {
                    result = "Tienes Sobrepeso";
                    mensaje.IsVisible = true;
                    mensaje.TextColor = Xamarin.Forms.Color.Red;
                    mensaje.Text = "Debes realizar una dieta rigurosa,recuerda que los habitos saludables " +
                       "minimizan los riesgos cardiacos";
                }
                else
                {
                    result = "¡Tienes obedicidad,cuidate!";
                    mensaje.IsVisible = true;
                    mensaje.TextColor = Xamarin.Forms.Color.Red;
                    mensaje.Text = "Debes realizar una dieta rigurosa,recuerda que los habitos saludables " +
                       "minimizan los riesgos cardiacos";
                }
                DisplayAlert("IMC",result,"Ok");

            }
            else
            {
                if (string.IsNullOrEmpty(Altura.Text))
                {
                    Altura.Focus();
                    DisplayAlert("Importante","Campo Obligatorio","Ok");
                }
                else if (string.IsNullOrEmpty(Peso.Text))
                {
                    Peso.Focus();
                    DisplayAlert("Importante", "Campo Obligatorio", "Ok");
                }
                else
                {
                    Peso.Focus();
                    Altura.Focus();
                    DisplayAlert("Importante", "Campos Obligatorios", "Ok");
                }
            }


        }

        private void SfButton_Clicked(object sender, EventArgs e)
        {

        }

        private void Limpiar_Clicked(object sender, EventArgs e)
        {

            Peso.Text = string.Empty;
            Altura.Text = string.Empty;
            Edad.Text = string.Empty;
            IMCS.Text = "0.0";
            mensaje.IsVisible = false;

        }
    }
}