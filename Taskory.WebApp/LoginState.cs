using System;
namespace Taskory.WebApp
{
    public class LoginState
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Transmitioncode { get; set; }
        public int OrganisationID { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool SA { get; set; }
    }
    public class Properties
    {
        public string APIConnection { get; set; }
    }
}
