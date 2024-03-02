using Core.Entities.Concretes;

namespace Entities.Concretes
{
    public class Rentals : EntityBase
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }

        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }

        public Rentals()
        {

        }
        public Rentals(int carId, int customerId, DateTime rentDate, DateTime returnDate)
        {
            CarId = carId;
            CustomerId = customerId;
            RentDate = rentDate;
            ReturnDate = returnDate;
        }
    }
}
