using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CarRepository : ICarRepository
    {
        public void Delete(CarInformation ci) => CarDAO.Delete(ci);

        public List<CarInformation> GetCarByName(string carName) => CarDAO.GetCarByName(carName);

        public List<CarInformation> GetCarList() => CarDAO.GetCarList();

        public void Register(CarInformation ci) => CarDAO.Register(ci);

        public void Update(CarInformation ci) => CarDAO.Update(ci);
    }
}
