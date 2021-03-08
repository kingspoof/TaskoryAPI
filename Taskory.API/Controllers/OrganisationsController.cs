using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Taskory.Logic;
using Taskory.DAL.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Taskory.API.Controllers
{
    [Route("api/Organisations")]
    public class OrganisationsController : Controller
    {
        private ReturnCodes RequiredPermission = ReturnCodes.SA;


        // GET: api/values -> Get All Organisations
        [HttpGet]
        public IEnumerable<Organisation> Get(string transpondercode)
        {
            if (Authentification.HasPermission(transpondercode, RequiredPermission))
                return OrganisationLogic.GetOrganisation();
            else
                HttpContext.Response.StatusCode = 403;
            return null;
        }

        // GET api/values/5 -> Get the Organisation with id
        [HttpGet("{id}")]
        public Organisation Get(int id, string transpondercode)
        {
            if (Authentification.HasPermission(transpondercode, RequiredPermission))
                return OrganisationLogic.GetOrganisation(id);
            else
                HttpContext.Response.StatusCode = 403;
            return null;
        }

        // POST api/values -> Create Organisation
        [HttpPost]
        public void Post(string transpondercode, [FromBody] Organisation value)
        {
            //if(Authentification.)
            if (Authentification.HasPermission(transpondercode, RequiredPermission))
                OrganisationLogic.CreateOrganisation(value);
            else
                HttpContext.Response.StatusCode = 403;
        }

        // PUT api/values/5-> Alter Organisation
        [HttpPut("{id}")]
        public void Put(int id,string transpondercode, [FromBody] Organisation value)
        {
            if (Authentification.HasPermission(transpondercode, RequiredPermission))
                OrganisationLogic.UpdateOrganisation(id, value);
            else
                HttpContext.Response.StatusCode = 403;
        }

        // DELETE api/values/5 -> Delete Organisation
        [HttpDelete("{id}")]
        public void Delete(int id, string transpondercode)
        {
            if (Authentification.HasPermission(transpondercode, RequiredPermission))
                OrganisationLogic.DeleteOrganisation(id);
            else
                HttpContext.Response.StatusCode = 403;
        }
    }
}
