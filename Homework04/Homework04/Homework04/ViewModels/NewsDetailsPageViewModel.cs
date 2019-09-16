using Homework04.Models;
using Homework04.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Homework04.ViewModels
{
    public class NewsDetailsPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CountryNews CountryNews{ get; set; }    


        public NewsDetailsPageViewModel(CountryNews articles)
        {
            this.CountryNews = articles;
            //GetArticles(country);        


        }

     
       

    }
}
