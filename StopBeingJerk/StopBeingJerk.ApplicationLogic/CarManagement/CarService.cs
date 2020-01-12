
using AutoMapper;
using StopBeingJerk.DataAccess;
using StopBeingJerk.DataAccess.RepositoryExtensions.CarManagement;
using StopBeingJerk.Domain.Entities;
using StopBeingJerk.Dto.CarManagement;
using StopBeingJerk.Dto.Comments;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StopBeingJerk.ApplicationLogic.CarManagement
{
    public class CarService : ApplicationService, ICarService
    {
        private readonly IRepository<RegistrationNumber> _registrationNumberRepository;
        private readonly IMapper _mapper;
        public CarService(IMapper mapper)
        {
            _registrationNumberRepository = new Repository<RegistrationNumber>(_context);
            _mapper = mapper;
        }
        public async Task<CarInfoOutput> GetCarInfo(string number)
        {
            var registrationNumber = await _registrationNumberRepository.GetRegistrationNumber(number);
            return _mapper.Map<RegistrationNumber, CarInfoOutput>(registrationNumber);
        }
    }
}
