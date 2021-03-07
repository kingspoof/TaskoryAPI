using System.ComponentModel.DataAnnotations;

namespace Taskory.DAL.Models
{
    public class Login
    {
        [Key]
        public string ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }
    }
}
