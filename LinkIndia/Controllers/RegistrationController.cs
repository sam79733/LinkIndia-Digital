using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkIndia.Dtos;
using LinkIndia.Models;
using LinkIndia.Services.Registration;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LinkIndia.Controllers
{
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistration _registration;

        public RegistrationController(IRegistration registration)
        {
            _registration = registration;
        }


        [HttpPost("register/addNewTransporter")]
        public async Task<ActionResult<ServiceResponse<List<GetTransporterDtos>>>> AddTransporter([FromBody] AddTransporterDtos addTransportDtos)
        {
            return Ok(await _registration.AddTransporter(addTransportDtos));
        }

        [HttpPost("register/addNewTruckOwner")]
        public async Task<ActionResult<ServiceResponse<List<GetTruckOwnerDtos>>>> AddTruckOwner([FromBody] AddTruckOwnerDtos addTruckOwnerDtos)
        {
            return Ok(await _registration.AddTruckOwner(addTruckOwnerDtos));
        }

        [HttpPost("register/addNewLoadProvider")]
        public async Task<ActionResult<ServiceResponse<List<GetLoadProviderDtos>>>> AddLoadProvider([FromBody] AddLoadProviderDtos addLoadProviderDtos)
        {
            return Ok(await _registration.AddLoadProvider(addLoadProviderDtos));
        }

    }
}
