using System;

namespace Entity.Concrete
{
    public class Comment 
    {
        public int CommentId { get; set; }
        public string CommentUserId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}