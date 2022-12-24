using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal writerDal;
        public WriterManager(IWriterDal WriterDal)
        {
            writerDal = WriterDal;
        }
        public void WriterAdd(Writer writer)
        {
            writerDal.Insert(writer);
        }
    }
}