using Homework04.Models;
using Homework04.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Homework04.ViewModels
{
    public class NewsDetailsPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public IList<Article> CountryArticles { get; set;} 
        private Article _selectedArticle;
        public Article SelectedArticle
        {
            get
            {
                return _selectedArticle;
            }
            set
            {
                _selectedArticle = value;
                if (_selectedArticle != null)
                {
                    ArticleDetails(_selectedArticle);
                }
            }
        }

        public NewsDetailsPageViewModel(IList<Article> articles)
        {
            CountryArticles = new List<Article>();
            int count = 0;
            articles.OrderBy(x => x.PublishedAt);
            foreach (var item in articles)
            {
                if (count < 4)
                {
                    count++;
                    continue;
                }                    
                CountryArticles.Add(item);
                count++;
                
                if (count == 10)
                    break;
            }
            //CountryArticles = articles;
            //GetArticles(country);        


        }

        private async void ArticleDetails(Article article)
        {
            await App.Current.MainPage.DisplayAlert(article.Title, article.Description, "Ok");
        }





    }
}
