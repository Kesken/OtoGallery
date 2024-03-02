using Core.Repositories.Concretes;
using DataAccess.Abstract;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class BrandDal : RepositoryBase<Brand>, IBrandDal
    {
        public BrandDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
