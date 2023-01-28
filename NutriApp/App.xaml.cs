using NutriApp.Views;
 
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NutriApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDM5MTk2QDMxMzkyZTMxMmUzMFhFeTI2UzB5M1Q4YjJ5SS8zZ2crZFF0WFNyczhYcjNtTm51TnlGeDVoaFE9");

            MainPage = new MenuPrincipal();
           // MainPage = new MenuPrincipal();
           // MainPage = new MainPage();
        }

        #region Properties

        public static string ImageServerPath { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";

        #endregion


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
