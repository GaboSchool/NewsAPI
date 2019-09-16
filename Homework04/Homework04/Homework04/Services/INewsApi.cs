using Homework04.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Homework04.Services
{
    public interface INewsApi
    {
        [Get("/v2/top-headlines?country={country}&apiKey=86c8904d7bd1480b8b936749335eb393")]
        Task<CountryNews> GetNews(string country);


    }
}
