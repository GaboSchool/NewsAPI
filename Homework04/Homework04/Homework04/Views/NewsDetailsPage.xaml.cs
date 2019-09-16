using Homework04.Models;
using Homework04.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Homework04.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsDetailsPage : ContentPage
    {
        public NewsDetailsPage(CountryNews articles)
        {
            InitializeComponent();
            BindingContext = new NewsDetailsPageViewModel(articles);
        }
    }
}