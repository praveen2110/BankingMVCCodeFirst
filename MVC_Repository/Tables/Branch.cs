﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Repository
{
    public class Branch
    {
        [Key]
        public int Branch_Id { get; set; }
        public string Branch_Location { get; set; }

    }
}
