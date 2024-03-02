using Core.Entities.Concretes;

namespace Entities.Concretes
{
    public class Brand : EntityBase
    {
        public string Name { get; set; }

        public Car Car { get; set; }

        public Brand()
        {

        }

        public Brand(string name)
        {
            Name = name;
        }
    }
}
