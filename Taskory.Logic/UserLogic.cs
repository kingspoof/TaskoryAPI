using System;
using Taskory.DAL.Models;
using Taskory.DAL;
using System.Linq;

namespace Taskory.Logic
{
    public class UserLogic
    {
        public string CreateUser(User user)
        {
            string ret = "";

            if(user.IsValid && !UsernameExists(user.Username))
            {
                user.AuthentificationTempelate
            }

            return "unspecified error";
        }
        public static bool UsernameExists(string username)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            return context.Users.Any(u => u.Username.ToLower().Equals(username));
        }
    }
}
