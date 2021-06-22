using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car: IEntity //IEntity interface implementasyonu 
    {
        //public Car()
        //{

        //}
        //public Car(int carId,int brandId,int colorId,int modelYear, decimal dailyPrice, string description)
        //{
        //    CarId = carId;
        //    BrandId = brandId;
        //    ColorId = colorId;
        //    ModelYear = modelYear;
        //    DailyPrice = dailyPrice;
        //    Description = description;
        //}
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
       
        
    }
}
