using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Taskory.Logic;
using Taskory.DAL.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Taskory.API.Controllers
{
    [Route("api/Task")]
    public class TaskController : Controller
    {
        //Permission:
        //C -> Admin
        //R -> Users
        //U -> Users (controlled)
        //D -> Admin

        // GET: api/values -> Get All Tasks of Organisation
        [HttpGet("{organisationID}")]
        public IEnumerable<Task> Get(int organisationID, [FromBody] DTO taskDTO)
        {
            if (Authentification.CheckTransmitionCode(taskDTO) == ReturnCodes.User)
                return TaskLogic.GET(organisationID);
            else
                HttpContext.Response.StatusCode = 403;
            return null;
        }

        [HttpGet("{organisationID}/{taskID}")]
        public Task Get(int organisationID, int taskID, [FromBody] DTO taskDTO)
        {
            if (Authentification.CheckTransmitionCode(taskDTO) == ReturnCodes.User)
                return TaskLogic.GET(organisationID, taskID);
            else
                HttpContext.Response.StatusCode = 403;
            return null;
        }

        // POST api/values/1 -> Create Task in organisation
        [HttpPost("{organisationID}")]
        public void Post(int organisationID, [FromBody] TaskDTO taskDTO)
        {
            if (Authentification.CheckTransmitionCode(taskDTO.TransmitionVerification) == ReturnCodes.Admin)
                TaskLogic.Create(organisationID, taskDTO.TransmitionTask);
            else
                HttpContext.Response.StatusCode = 403;

        }

        // PUT api/values/5 -> Edit task in organisation
        [HttpPut("{organisationID}")]
        public void Put(int organisationID, [FromBody] TaskDTO taskDTO)
        {
            if (Authentification.CheckTransmitionCode(taskDTO.TransmitionVerification) == ReturnCodes.User)
                TaskLogic.UpdateTask(organisationID, taskDTO.TransmitionTask);
            else
                HttpContext.Response.StatusCode = 403;
        }

        // DELETE api/values/5/1 -> Delete task in organisation
        [HttpDelete("{organisationID}/{taskID}")]
        public void Delete(int organisationID, int taskID, [FromBody] DTO taskDTO)
        {
            if (Authentification.CheckTransmitionCode(taskDTO) == ReturnCodes.Admin)
                TaskLogic.DeleteTask(organisationID, taskID);
            else
                HttpContext.Response.StatusCode = 403;
        }
    }
}
