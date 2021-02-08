using System;
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
            context.Add(org);
            context.SaveChanges();
            return org;
        }

        //get orgnisation
        public static Organisation GetOrganisation(int id)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            return context.Organisations.Where(e => e.ID == id).FirstOrDefault();
        }

        //update organisation
        public static void ChangeNameOfOrganisation(int id, Organisation org)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            {
                var target = context.Organisations.Where(e => e.ID == id).FirstOrDefault();
                target.Name = String.IsNullOrEmpty(org.Name) ? target.Name : org.Name;
            }
        }

        //delete organisation
        public static void DeleteOrganisation(int id)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            context.Organisations.Remove(context.Organisations.Where(o => o.ID == id).FirstOrDefault());
            context.SaveChanges();
        }

        //add Administrator
        public static void AddAdministrator(int id, User admin)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            context.Organisations.Where(e => e.ID == id).FirstOrDefault().Administrator.Add(admin);
            context.SaveChanges();
        }

        //remove Administrator
        public static void RMVAdministrator(int id, int adminid)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            context.Organisations.Where(o => o.ID == id).FirstOrDefault().Administrator.Remove(
                context.Organisations.Where(o => o.ID == id).FirstOrDefault().Administrator.Where(a => a.ID == adminid).FirstOrDefault());
        }

        //add User
        public static void AddUser(int id, User user)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            context.Organisations.Where(e => e.ID == id).FirstOrDefault().Users.Add(user);
            context.SaveChanges();
        }

        //remove User
        public static void RMVUser(int id, int userid)
        {
            using TaskoryDBContext context = new TaskoryDBContext();
            context.Organisations.Where(o => o.ID == id).FirstOrDefault().Administrator.Remove(
                context.Organisations.Where(o => o.ID == id).FirstOrDefault().Users.Where(a => a.ID == userid).FirstOrDefault());
        }
    }
}
