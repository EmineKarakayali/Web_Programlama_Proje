﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtremeSports.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentTxt { get; set; }
        public Member Member { get; set; }
    }
}
