using Core.Entities.Concretes;

namespace Entities.Concretes
{
    public class Car : EntityBase
    {

        public int BrandId { get; set; }
        public int ColorId { get; set; }

        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public string Description { get; set; }

        public virtual Color Color { get; set; }
        public virtual Brand Brand { get; set; }

        public Car()
        {

        }

        public Car(int brandId, int colorId, decimal dailyPrice, int modelYear, string description)
        {
            BrandId = brandId;
            ColorId = colorId;
            DailyPrice = dailyPrice;
            ModelYear = modelYear;
            Description = description;
        }
    }
}
