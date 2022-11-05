using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; //araba listesi oluşturulur ve globalde yazdığım için _ kullanılır.
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=350,ModelYear=2019,Description="Güzel araba"},
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=600,ModelYear=2020,Description="Fena değil"},
                new Car{Id=3,BrandId=2,ColorId=1,DailyPrice=250,ModelYear=2020,Description="Bakımlı araba"},
                new Car{Id=4,BrandId=2,ColorId=2,DailyPrice=530,ModelYear=2021,Description="Muhteşem araba"},
                new Car{Id=5,BrandId=3,ColorId=2,DailyPrice=440,ModelYear=2022,Description="Tam senlik araba"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(c=>c.Id==car.Id);
        }

        public List<Car> GetAll()
        {
           return _cars;
        }

       

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            
        }
    }
}
