using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 5, ColorId = 1, DailyPrice = 150, Description = "", ModelYear = 2018 },
                new Car { Id = 2, BrandId = 4, ColorId = 1, DailyPrice = 200, Description = "", ModelYear = 2020 },
                new Car { Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 125, Description = "", ModelYear = 2017 },
                new Car { Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 175, Description = "", ModelYear = 2019 },
                new Car { Id = 5, BrandId = 1, ColorId = 3, DailyPrice = 160, Description = "", ModelYear = 2019 },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
