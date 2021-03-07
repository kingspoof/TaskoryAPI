using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Taskory.DAL.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public Login Login { get; set; }
        public string AuthentificationTempelate { get; set; }
        public bool Deleted { get; set; }
    }
}
