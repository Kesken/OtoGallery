using Core.Entities.Concretes;

namespace Entities.Concretes
{
    public class Car : EntityBase
    {

        public int BrandId { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public string Description { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual ICollection<CarColor> CarColors { get; set; } = new HashSet<CarColor>();

        public Car()
        {
        }

        public Car(int brandId, decimal dailyPrice, int modelYear, string description)
        {
            BrandId = brandId;
            DailyPrice = dailyPrice;
            ModelYear = modelYear;
            Description = description;
        }
    }
}
