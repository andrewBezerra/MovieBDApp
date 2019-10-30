using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieDBApp.Services
{
    public interface IHttpRequest
    {
        Task<TResult> GetAsync<TResult>(string uri);
    }
}
