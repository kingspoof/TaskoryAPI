using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Taskory.Logic;
using Taskory.DAL.Models;
using System.Linq;
using Microsoft.AspNetCore.Cors;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Taskory.API.Controllers
{
    [Route("api/User")]
    public class UserController : Controller
    {
        // GET: api
        [HttpGet]
        public string Get(string username, string password)
        {
            return UserLogic.CheckLogin(username, password);
        }

        // GET api/values/5
        [HttpGet("{organisationID}")]
        public IEnumerable<User> Get(int organisationID,string transpondercode)
        {
            if (Authentification.HasPermission(transpondercode, ReturnCodes.User))
                return UserLogic.GetUser(organisationID);
            else
                HttpContext.Response.StatusCode = 403;
            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post(int organisationID,string transpondercode, [FromBody] User user)
        {
            if (Authentification.HasPermission(transpondercode, ReturnCodes.User))
            {
                var n = UserLogic.CreateUser(organisationID, user);
                HttpContext.Response.StatusCode = n switch
                {
                    "420" => 420,
                    _ => 200,
                };
            }
            else
                HttpContext.Response.StatusCode = 403;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id, string transpondercode)
        {
            if (Authentification.HasPermission(transpondercode, ReturnCodes.User))
                UserLogic.DeleteUser(id);
            else
                HttpContext.Response.StatusCode = 403;
        }
    }
}
