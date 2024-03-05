using Business.Services.Repositories;
using Core.Repositories.Concretes;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Repositories;

public class RentalRepository : RepositoryBase<Rental, AppDbContext>, IRentalRepository
{
    public RentalRepository(AppDbContext context) : base(context)
    {
    }
}
