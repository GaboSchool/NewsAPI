using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Homework04.Models;
using Refit;

namespace Homework04.Services
{
    public class ApiService : INewsApi
    {
        public ApiService()
        {

        }

        public async Task<CountryNews> GetNews(string country)
        {
            var apiResponse = RestService.For<INewsApi>("https://newsapi.org");
            var countryNews = await apiResponse.GetNews(country);

            return countryNews;
        }
    }
}
