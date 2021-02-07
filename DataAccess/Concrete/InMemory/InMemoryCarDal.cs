using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear="2018",DailyPrice=150,Description="Kiralık Hyundai"},
                new Car{Id=2,BrandId=1,ColorId=1,ModelYear="2019",DailyPrice=120,Description="Kiralık BMW"},
                new Car{Id=3,BrandId=1,ColorId=1,ModelYear="2020",DailyPrice=180,Description="Kiralık Honda"},
                new Car{Id=4,BrandId=1,ColorId=1,ModelYear="2015",DailyPrice=130,Description="Kiralık Mercedes"},
                new Car{Id=5,BrandId=1,ColorId=1,ModelYear="2017",DailyPrice=140,Description="Kiralık Hyundai"}

            };
        }
        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == entity.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
