using AutomobileLibrary.BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        public static List<Car> Cars = new List<Car>()
        {
            new Car { CarId = 1, CarName = "CRV", Manufacturer = "Honda", Price = 30000, ReleaseYear = 2021 },
            new Car { CarId = 2, CarName = "Ford Focus", Manufacturer = "Ford", Price = 15000, ReleaseYear = 2020 }
        };

        //Using Singleton Pattern 
        private static CarDBContext instance = null;
        public static readonly object instanceLock = new object();

        public CarDBContext()
        {
        }

        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }

                    return instance;
                }
            }
        }

        public List<Car> GetCarsList => Cars;


        //get car by id 
        public Car GetCarByID(int carId) {
            return Cars.SingleOrDefault(pro  => pro.CarId == carId);
          
        }

        //Add new Car
        public void AddNewCar (Car car) { 
            Car pro = GetCarByID(car.CarId);
            if (pro != null)  throw new Exception("Product exits"); 
            else
            {
                Cars.Add(car);
            }


        }
        //update car
        public void UpdateCar(Car car)
        {
            Car pro = GetCarByID (car.CarId);

            if (pro == null) throw new Exception("Product not exits");
            else
            {
                int index = Cars.IndexOf(pro);
                Cars[index] = car;
            }
        }


        //remove car
        public void RemoveCar(int carId)
        {
            Car pro = GetCarByID((int)carId);

            if (pro == null) throw new Exception("Product not exits");
            else
            {
                Cars.Remove(pro);
            }
        }


    }



}
