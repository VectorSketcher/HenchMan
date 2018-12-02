using HenchMan.Libs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HenchMan.Libs.Giphy
{
    public interface IGetRandomGif
    {
        Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCritera);
    }
}
