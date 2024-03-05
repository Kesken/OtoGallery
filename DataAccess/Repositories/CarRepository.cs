using Business.Services.Repositories;
using Core.Repositories.Concretes;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Repositories;

public class CarRepository : RepositoryBase<Car, AppDbContext>, ICarRepository
{
    public CarRepository(AppDbContext context) : base(context)
    {
    }
}
