﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Taskory.WebApp
{
    public class Organisation
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public User Administrator { get; set; }
        public List<User> Users { get; set; }
        public List<Task> Tasks { get; set; }
        public bool Deleted { get; set; }
    }
}
