using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Cars.Command.DeleteCar
{
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommandRequest, DeleteCarCommandResponse>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public DeleteCarCommandHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<DeleteCarCommandResponse> Handle(DeleteCarCommandRequest request, CancellationToken cancellationToken)
        {
            Car? car = await _carRepository.GetAsync(predicate: x => x.Id.Equals(request.Id));

            await _carRepository.DeleteAsync(car);

            DeleteCarCommandResponse response = _mapper.Map<DeleteCarCommandResponse>(car);

            return response;
        }
    }
}
