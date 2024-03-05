using Core.Entities.Concretes;

namespace Entities.Concretes
{
    public class Brand : EntityBase
    {
        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public Brand()
        {
            Cars = new HashSet<Car>();
        }

        public Brand(string name)
        {
            Name = name;
        }
    }
}
