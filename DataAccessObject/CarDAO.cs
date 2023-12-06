using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class CarDAO
    {
        public static List<CarInformation> GetCarList()
        {
            List<CarInformation> CarList = new List<CarInformation>();
            try
            {
                using var db = new FUCarRentingManagementContext();
                CarList = db.CarInformations.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return CarList;
        }

        public static List<CarInformation> GetCarByName(string carName)
        {
            List<CarInformation> CarList = new List<CarInformation>();
            List<CarInformation> RealCarList = new List<CarInformation>();
            try
            {
                using var db = new FUCarRentingManagementContext();
                CarList = db.CarInformations.ToList();//.SingleOrDefault(m => m.CarName.Contains(carName)); 

                for (int i=0; i < CarList.Count;i++)
                {
                   if (CarList[i].CarName.Contains(carName))
                    {
                        RealCarList.Add(CarList[i]);
                    }
                }
                                                                               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return RealCarList;
        }

        public static void Delete(CarInformation ci)
        {
            try
            {
                using var db = new FUCarRentingManagementContext();
                var p1 = db.CarInformations.SingleOrDefault(m => m.CarId == ci.CarId);
                db.CarInformations.Remove(p1); // remove ra khỏi DbSet
                db.SaveChanges(); // cập nhật CSDL
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Register(CarInformation ci)
        {
            try
            {
                using var db = new FUCarRentingManagementContext();
                db.CarInformations.Add(ci); // thêm p vào trong DbSet
                db.SaveChanges(); // cập dữ liệu vào CSDL
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Update(CarInformation ci)
        {
            try
            {
                using (var db = new FUCarRentingManagementContext())
                {
                    db.Entry<CarInformation>(ci).State = EntityState.Modified; //gán trạng thái
                    db.SaveChanges(); // cập nhật CSDL
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
