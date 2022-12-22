using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFContactRepository:GenericRepository<Contact>, IContactDal
    {

    }
}