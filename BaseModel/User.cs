﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel
{
    public class User: BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Blog> Blogs { get; set; }

    }
}
