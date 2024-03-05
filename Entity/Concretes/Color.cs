using Core.Entities.Concretes;

namespace Entities.Concretes
{
    public class Color : EntityBase
    {
        public string Name { get; set; }

        public virtual ICollection<CarColor> CarColors { get; set; } = new HashSet<CarColor>();
        public Color()
        {

        }
        public Color(string name)
        {
            Name = name;
        }
    }
}
