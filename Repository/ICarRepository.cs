using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICarRepository
    {
        List<CarInformation> GetCarList();
        List<CarInformation> GetCarByName(string carName);
        void Delete(CarInformation ci);
        void Register(CarInformation ci);
        void Update(CarInformation ci);
    }
}
