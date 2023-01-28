using NutriApp.ViewModels.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace NutriApp.Views.Article
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticleParallaxHeaderPage : ContentPage
    {
        public ArticleParallaxHeaderPage()
        {
            InitializeComponent();
            this.BindingContext = ArticleParallaxHeaderPageViewModel.BindingContext;
        }
    }
}