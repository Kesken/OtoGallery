using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Business.Features.Cars.Queries.GetCar
{
    public class GetCarQueriesHandler : IRequestHandler<GetCarQueriesRequest, GetCarQueriesResponse>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetCarQueriesHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<GetCarQueriesResponse> Handle(GetCarQueriesRequest request, CancellationToken cancellationToken)
        {

            Car? car = await _carRepository.GetAsync(predicate: x => x.Id.Equals(request.Id),
                include: x => x
                   .Include(x => x.Brand)
                   .Include(x => x.CarColors).ThenInclude(x => x.Color));

            GetCarQueriesResponse response = _mapper.Map<GetCarQueriesResponse>(car);

            return response;
        }
    }
}
