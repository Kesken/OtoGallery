using AutoMapper;
using Business.Services.Repositories;
using Entities.Concretes;
using MediatR;

namespace Business.Features.Cars.Command.CreateCar
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommandRequest, CreateCarCommandResponse>
    {
        private readonly ICarRepository _carRepository;
        private readonly IColorRepository _colorRepository;
        private readonly IMapper _mapper;
        public CreateCarCommandHandler(ICarRepository carRepository, IMapper mapper, IColorRepository colorRepository)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _colorRepository = colorRepository;
        }

        public async Task<CreateCarCommandResponse> Handle(CreateCarCommandRequest request, CancellationToken cancellationToken)
        {
            Car car = _mapper.Map<Car>(request);

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

            await _carRepository.AddAsync(car);

            CreateCarCommandResponse response = _mapper.Map<CreateCarCommandResponse>(car);
            response.ColorName = colorNames;

            return response;
        }
    }
}
