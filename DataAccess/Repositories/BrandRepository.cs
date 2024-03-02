using Business.Services.Repositories;
using Core.Repositories.Concretes;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Repositories;

public class BrandRepository : RepositoryBase<Brand, AppDbContext>, IBrandRepository
{
	public BrandRepository(AppDbContext context) : base(context)
	{
	}
}
