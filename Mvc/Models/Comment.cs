using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportProject.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentTxt { get; set; }
        public DateTime SendDate { get; set; }
        public string UserNick { get; set; }
        public int CourseId { get; set; }
        public virtual Courses Courses { get; set; }

    }
}
