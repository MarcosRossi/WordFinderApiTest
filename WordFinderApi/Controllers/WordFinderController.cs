using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WordFinderApi.Models;
using WordFinderApi.Services;

namespace WordFinderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordFinderController : ControllerBase
    {        
        [HttpPost]
        public IActionResult Search(ApiRequestModel model)
        {
            if (ModelState.IsValid)
            {

            }
            var apiResponse = new ApiResponseModel();
            var wFinder = new WordFinder(model.Dictionary);
            if (wFinder.Exceed2048 || wFinder.Exceed64x64(model.Src))
            {
                apiResponse.ErrorMessage = wFinder.Exceed2048 ? "The number of items in the dictionary does not exceed 2048" : "The size of the matrix does not exceed 64x64";
                return BadRequest(apiResponse);
            }
            else
            {
                apiResponse.Result = wFinder.Find(model.Src).ToList();
                return Ok(apiResponse);
            }
        }
    }
}