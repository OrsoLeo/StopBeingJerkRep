using StopBeingJerk.Dto.CarManagement;
using System.Threading.Tasks;

namespace StopBeingJerk.ApplicationLogic.CarManagement
{
    public interface ICarService
    {
        Task<CarInfoOutput> GetCarInfo(string number);
    }
}