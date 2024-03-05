using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Cars.Command.UpdateCar
{
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommandRequest, UpdateCarCommandResponse>
    {
        private readonly ICarRepository _carRepository;
        private readonly IColorRepository _colorRepository;
        private readonly IMapper _mapper;

        public UpdateCarCommandHandler(ICarRepository carRepository, IMapper mapper, IColorRepository colorRepository)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _colorRepository = colorRepository;
        }

        public async Task<UpdateCarCommandResponse> Handle(UpdateCarCommandRequest request, CancellationToken cancellationToken)
        {
            Car? car = await _carRepository.GetAsync(predicate: x => x.Id.Equals(request.Id));

            List<string> colorNames = new List<string>();

            foreach (var colorId in request.ColorIds)
            {
                var color = await _colorRepository.GetAsync(x => x.Id.Equals(colorId));
                car.CarColors.Add(
                    new CarColor
                    {
                        CarId = car.Id,
                        ColorId = color.Id
                    });

                colorNames.Add(color.Name);
            }

            car = _mapper.Map(request, car);

            await _carRepository.UpdateAsync(car);

            UpdateCarCommandResponse response = _mapper.Map<UpdateCarCommandResponse>(car);
            response.ColorName = colorNames;

            return response;
        }
    }
}
