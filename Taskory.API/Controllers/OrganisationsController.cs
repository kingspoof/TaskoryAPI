using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Taskory.Logic;
using Taskory.DAL.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Taskory.API.Controllers
{
    [Route("api/[controller]")]
    public class OrganisationsController : Controller
    {
        private ReturnCodes RequiredPermission = ReturnCodes.SA;
        // GET: api/values
        [HttpGet]
        public IEnumerable<Organisation> Get([FromBody] DTO value)
        {
            if (Authentification.CheckTransmitionCode(value) == RequiredPermission)
                return OrganisationLogic.GetOrganisation();
            else
                HttpContext.Response.StatusCode = 403;
            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Organisation Get(int id, [FromBody] DTO value)
        {
            if (Authentification.CheckTransmitionCode(value) == RequiredPermission)
                return OrganisationLogic.GetOrganisation(id);
            else
                HttpContext.Response.StatusCode = 403;
            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] OrganisationDTO value)
        {
            //if(Authentification.)
            if (Authentification.CheckTransmitionCode(value.TransmitionVerification) == RequiredPermission)
                OrganisationLogic.CreateOrganisation(value.TransmitionOrganisation);
            else
                HttpContext.Response.StatusCode = 403;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OrganisationDTO value)
        {
            if (Authentification.CheckTransmitionCode(value.TransmitionVerification) == RequiredPermission)
                OrganisationLogic.UpdateOrganisation(id, value.TransmitionOrganisation);
            else
                HttpContext.Response.StatusCode = 403;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id, [FromBody] DTO value)
        {
            if (Authentification.CheckTransmitionCode(value) == RequiredPermission)
                OrganisationLogic.DeleteOrganisation(id);
            else
                HttpContext.Response.StatusCode = 403;
        }
    }
}
