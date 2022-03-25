using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LinkIndia.Services.Post;
using LinkIndia.Dtos;
using LinkIndia.Models;
using Microsoft.AspNetCore.Cors;
using System.IO;
using System.Net.Http.Headers;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LinkIndia.Controllers
{

    [EnableCors("_myAllowSpecificOrigins")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
   

        public PostController(IPostService postLoadService)
        {
            _postService = postLoadService;
          
        }


        [HttpPost("load/postload")]
        public async Task<ActionResult<ServiceResponse<List<GetPostLoadDtos>>>> PostLoad([FromBody] AddPostLoadDtos addPostLoadDtos)
        {
            return Ok(await _postService.AddPostLoad(addPostLoadDtos));
        }

        [HttpGet("load/findLoads")]
        public async Task<ActionResult<ServiceResponse<List<GetPostLoadDtos>>>> FindLoad(string fromLocation, string toLocation)
        {
            return Ok(await _postService.FindLoad(fromLocation, toLocation));
        }

        [HttpPost("truck/posttruck")]
        public async Task<ActionResult<ServiceResponse<List<GetPostTruckDtos>>>> PostTruck([FromBody] AddPostTruckDtos addPostTruckDtos)
        {
            return Ok(await _postService.AddPostTruck(addPostTruckDtos));
        }

    }
}
