using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
        List<Brand> _brands;
        List<Color> _colors;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{ Id=1, BrandId=1, ColorId=2, DailyPrice=150, Description="Aile Arabası", ModelYear=2012},
                new Car{ Id=2, BrandId=2, ColorId=1, DailyPrice=100, Description="Eski Araba", ModelYear=2010},
                new Car{ Id=3, BrandId=1, ColorId=1, DailyPrice=350, Description="Suv Araba", ModelYear=2019},
                new Car{ Id=4, BrandId=2, ColorId=1, DailyPrice=400, Description="Spor Araba", ModelYear=2021},
                new Car{ Id=5, BrandId=2, ColorId=2, DailyPrice=200, Description="Yeni Araba", ModelYear=2015},
                new Car{ Id=6, BrandId=1, ColorId=1, DailyPrice=250, Description="Hızlı Araba", ModelYear=2018},
            };

            _brands = new List<Brand> {
                new Brand{BrandId=1, BrandName="BMW"},
                new Brand{BrandId=2, BrandName="Mercedes"}
            };

            _colors = new List<Color> {
            new Color{ColorId=1, ColorName="Kırmızı"},
            new Color{ColorId=2, ColorName="Siyah"}
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var deleteToCar = _cars.FirstOrDefault(c => c.Id == car.Id);
            _cars.Remove(deleteToCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var updateToCar = _cars.FirstOrDefault(c => c.Id == car.Id);
            updateToCar.Id = car.Id;
            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.ModelYear = car.ModelYear;
            updateToCar.Description = car.Description;
        }

    }
}
