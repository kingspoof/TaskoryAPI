using System;
using System.Collections.Generic;
using System.Linq;
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
        public static Organisation GetOrganisation(int id)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            return context.Organisations.Where(e => e.ID == id).FirstOrDefault();
        }
        public static IEnumerable<Organisation> GetOrganisation()
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            return context.Organisations.ToList();
        }

        //update organisation
        public static void UpdateOrganisation(int id, Organisation org)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            {
                var target = context.Organisations.Where(e => e.ID == id).FirstOrDefault();
                target = org == null ? target : org;
            }
        }

        //delete organisation
        public static void DeleteOrganisation(int id)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            context.Organisations.Remove(context.Organisations.Where(o => o.ID == id).FirstOrDefault());
            context.SaveChanges();
        }
    }
}
