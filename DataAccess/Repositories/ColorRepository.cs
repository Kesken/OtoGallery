using Business.Services.Repositories;
using Core.Repositories.Concretes;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Repositories;

public class ColorRepository : RepositoryBase<Color, AppDbContext>, IColorRepository
{
    public ColorRepository(AppDbContext context) : base(context)
    {
    }
}
