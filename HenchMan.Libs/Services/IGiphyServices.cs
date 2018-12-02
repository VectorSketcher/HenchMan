using HenchMan.Libs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HenchMan.Libs.Services
{
    public interface IGiphyServices
    {
        Task<GiphyModel> GetRandomGifBasedOnSearchCritera(string searchCritera);
    }
}
