using Core.Entities.Concretes;

namespace Entities.Concretes
{
    public class Customer : EntityBase
    {
        public int UserId { get; set; }

        public string CompanyName { get; set; }

        public virtual User User { get; set; }

        public Customer()
        {

        }
        public Customer(int userId, string companyName)
        {
            UserId = userId;
            CompanyName = companyName;
        }
    }
}
