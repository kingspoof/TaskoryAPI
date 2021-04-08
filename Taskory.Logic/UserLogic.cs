using System;
using Taskory.DAL.Models;
using Taskory.DAL;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Taskory.Encryption;

namespace Taskory.Logic
{
    public class UserLogic
    {
        public static string CreateUser(int organisationID, User user)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            if (context.Organisations.Any(o => o.ID == organisationID))
                if (user.IsValid && !UsernameExists(user.Username))
                {

                    //encrypt Password
                    user.Password = Encryption.Encryption.UsingMD5(user.Password);

                    //create user
                    user.Username = user.Username.ToLower();


                    //user.AuthentificationTempelate = Authentification.GenerateTransmitionCode(user, organisationID);
                    user.Deleted = false;
                    context.Users.Add(user);

                    //add user to organisation if null
                    var org = context.Organisations.Where(o => o.ID == organisationID).FirstOrDefault();
                    if (org.Users == null)
                        org.Users = new List<User>();

                    //save the changes to the db
                    org.Users.Add(user);
                    context.SaveChanges();

                    //give user a new authentificationtempelate if he does not already have one
                    string userid = context.Users.Where(u => u.Username.ToLower().Equals(user.Username.ToLower()))?.FirstOrDefault().ID.ToString();
                    var targetuser = context.Users.FirstOrDefault(u => u.ID == Convert.ToInt32(userid));
                    if(targetuser != null)
                        if(targetuser.AuthentificationTempelate.StartsWith("79"))
                            targetuser.AuthentificationTempelate = $"{Convert.ToInt32(userid) * 79}-[1234]-{organisationID}";
                        else
                        targetuser.AuthentificationTempelate =  $"{userid}-[1234]-{organisationID}";

                    //save changes and return the authentification tempelate
                    context.Users.Update(targetuser);
                    context.SaveChanges();
                    return targetuser.AuthentificationTempelate;


                }

            return "420";
        }


        public static string CheckLogin(string username, string password)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            password = Encryption.Encryption.UsingMD5(password);
            var user = context.Users.Where(u => u.Username.Equals(username) && u.Password.Equals(password) && !u.Deleted);
            if (user.Any())
            {
                return user.FirstOrDefault().AuthentificationTempelate;
            }
            return "false";
        }


        public static IEnumerable<User> GetUser(int organisationID)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            if (context.Organisations.Any(o => o.ID == organisationID))
            {
                var n = context.Organisations.Include("Users").Single(o => o.ID == organisationID);
                return n.Users;
            }
            return null;
        }


        public static string DeleteUser(int id)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            if (context.Users.Any(u => u.ID == id))
            {
                var user = context.Users.Where(u => u.ID == id).FirstOrDefault();
                user.Deleted = true;
                context.Update(user);
                context.SaveChanges();
                return "Deleted";
            }
            return "User not found";
        }


        public static bool UsernameExists(string username)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            return context.Users.Any(u => u.Username.ToLower().Equals(username));
        }
    }
}
