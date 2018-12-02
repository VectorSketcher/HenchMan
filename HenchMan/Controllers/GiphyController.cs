using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HenchMan.Libs.Services;
using Microsoft.AspNetCore.Mvc;

namespace HenchMan.Controllers
{
    public class GiphyController : Controller
    {
        private readonly IGiphyServices _giphyServices;

        public GiphyController(IGiphyServices giphyServices)
        {
            _giphyServices = giphyServices;
        }

        [HttpGet]
        [Route("v1/giphy/random/{searchCritera}")]
        public async Task<IActionResult> GetRandomGif(string searchCritera)
        {
            var result = await _giphyServices.GetRandomGifBasedOnSearchCritera(searchCritera);

            return Ok(result);
        }
    }
}