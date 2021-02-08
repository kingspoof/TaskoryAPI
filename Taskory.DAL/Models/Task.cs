using System;
using System.ComponentModel.DataAnnotations;

namespace Taskory.DAL.Models
{
    public class Task
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descriprion { get; set; }
        public int RepeatAfterXDays { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
