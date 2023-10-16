using AutomobileLibrary.BussinessObjects;
using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Reponsitory
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarByID(int carID) => CarDBContext.Instance.GetCarByID(carID);
        public IEnumerable<Car> GetCars () => CarDBContext.Instance.GetCarsList;

        public void InsertCar(Car car) => CarDBContext.Instance.AddNewCar(car);

        public void DeleteCar(int carID) => CarDBContext.Instance.RemoveCar(carID);

        public void UpdateCar (Car car) => CarDBContext.Instance.UpdateCar(car);    


    }
}
