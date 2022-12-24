using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal commentDal;
        public CommentManager(ICommentDal CommentDal)
        {
            commentDal = CommentDal;
        }
        public void CommentAdd(Comment comment)
        {
            throw new System.NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
            return commentDal.GetListAll(x => x.BlogId == id);
        }
    }
}