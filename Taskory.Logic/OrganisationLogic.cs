using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Taskory.DAL;
using Taskory.DAL.Models;


namespace Taskory.Logic
{
    public class OrganisationLogic
    {
        //create orgnisation
        public static Organisation CreateOrganisation(Organisation org)
        {
            using TaskoryDBContext context = new TaskoryDBContext();

            if (org.Tasks == null)
                org.Tasks = new List<Task>();
            if (org.Users == null)
                org.Users = new List<User>();

            context.Organisations.Add(org);
            context.SaveChanges();
            return org;
        }

        //get orgnisation
        public static Organisation GetOrganisationFromUser(int id)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            var org = context.Organisations
                .Include("Tasks")
                .Include("Users")
                .Include("Administrator")
                .SingleOrDefault(o => o.Administrator.ID == id || o.Users.Any(u => u.ID == id));
            return org;
        }
        public static IEnumerable<Organisation> GetOrganisation()
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            return context.Organisations
                .Include("Tasks")
                .Include("Users")
                .Include("Administrator").
                ToList();
        }

        //update organisation
        public static void UpdateOrganisation(int id, Organisation org)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            context.Update(org);
            context.SaveChanges();
        }

        //delete organisation
        public static void DeleteOrganisation(int id)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            if (context.Organisations.Any(o => o.ID == id))
            {
                var org = context.Organisations.Where(o => o.ID == id).FirstOrDefault();
                org.Deleted = true;
            }
            context.SaveChanges();
        }
    }
}
