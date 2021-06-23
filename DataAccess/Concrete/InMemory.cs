using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemory : ICarDal
    {
        List<Car> _cars; // Car listesinin referansını tutmak için oluşturulan nesne 
        public InMemory()
        {
            List<Color> colors = new List<Color> // Color listesi
        {
            new Color{ ColorId=1,ColorName="Red"},
            new Color{ ColorId=2,ColorName="Blue"},
            new Color{ ColorId=1,ColorName="Green"}
        };
            List<Brand> brands = new List<Brand> // Brand Listesi
        {
            new Brand{BrandId=1,BrandName="Audi"},
            new Brand{BrandId=2,BrandName="BMW"},
            new Brand{BrandId=3,BrandName="Mercedes"}
        };
            _cars = new List<Car> // Car Listesi
        {
            new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2015,DailyPrice=100000,Description="Diesel 1.5"},
            new Car{CarId=2,BrandId=1,ColorId=2,ModelYear=2017,DailyPrice=200000,Description="Diesel 1.5"},
            new Car{CarId=3,BrandId=2,ColorId=3,ModelYear=2018,DailyPrice=300000,Description="Diesel 1.5"},
            new Car{CarId=4,BrandId=3,ColorId=2,ModelYear=2019,DailyPrice=400000,Description="Diesel 1.5"}
        };

        }
      
        public void Add(Car car)// Car listesine yeni kayıt ekleme
        {
            _cars.Add(car);
        }

        public void Delete(Car car)// Car listesine kayıt silme
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }
        public List<Car> GetAll()// Car listesini gösterir.
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)//CarId yi getirir.
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
