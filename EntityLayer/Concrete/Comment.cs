﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [StringLength(50)]

        public string Username { get; set; }
        [StringLength(50)]

        public string Mail { get; set; }
        [StringLength(200)]

        public string CommentText { get; set; }
        public int BlogID { get; set; }
        public virtual Blog Blogs { get; set; }
    }
}
