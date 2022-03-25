using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LinkIndia.Models;
using LinkIndia.Dtos;
using LinkIndia.Services.Util;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Net.Http.Headers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LinkIndia.Controllers
{
    [Route("[Controller]")]
    public class TransportUtil : ControllerBase
    {
        private readonly IUtility _utility;


        [HttpGet("GetTruckTypes")]
        public async Task<ActionResult<ServiceResponse<List<GetTruckTypesDtos>>>> GetTruckTypes()
        {
           
            return Ok(await _utility.GetTruckTypes());
        }


        [HttpGet("GetMaterialTypes")]
        public async Task<ActionResult<ServiceResponse<List<GetMaterialTypeDtos>>>> MaterialTypes()
        {

            return Ok(await _utility.GetMaterialTypes());
        }


        [HttpPost("uploadfile"), DisableRequestSizeLimit]
        public IActionResult Upload()
        {
            try
            {
                var files = Request.Form.Files;
                List<string> dbPath = new List<string>();
                var subFolderName = Request.Form["folderName"];

                var folderName = Path.Combine("Resources", subFolderName);

                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        var fullPath = Path.Combine(pathToSave, file.FileName);
                        dbPath.Add(Path.Combine(folderName, file.FileName));
                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                    }
                    else
                    {
                        return BadRequest();
                      
                    }
                }

                return Ok(new { dbPath });

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
           

        }


        public TransportUtil(IUtility utility)
        {
            _utility = utility;
        }
    }
}
