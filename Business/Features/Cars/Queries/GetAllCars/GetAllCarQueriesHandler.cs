using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Business.Features.Cars.Queries.GetAllCars
{
    public class GetAllCarQueriesHandler : IRequestHandler<GetAllCarQueriesRequest, ICollection<GetAllCarQueriesResponse>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        public GetAllCarQueriesHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }
        public async Task<ICollection<GetAllCarQueriesResponse>> Handle(GetAllCarQueriesRequest request, CancellationToken cancellationToken)
        {
            ICollection<Car> cars = await _carRepository.GetListAsync(
                include: x => x
                    .Include(x => x.Brand)
                    .Include(x => x.CarColors).ThenInclude(x => x.Color));

            ICollection<GetAllCarQueriesResponse> getAllCars = _mapper.Map<ICollection<GetAllCarQueriesResponse>>(cars);


            return getAllCars;
        }
    }
}
