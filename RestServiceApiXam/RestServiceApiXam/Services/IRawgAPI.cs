using Refit;
using RestServiceApiXam.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestServiceApiXam.Services
{
    public interface IRawgAPI
    {
        [Get("/creators")]
        //Task<ApiResponse<HttpResponseMessage>> GetCreatorsAsync();
        Task<GetCreatorResponse> GetCreatorsAsync();
    }
}
