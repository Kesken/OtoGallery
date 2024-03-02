using Core.Entities.Concretes;

namespace Entities.Concretes
{
    public class Color : EntityBase
    {
        public string Name { get; set; }

        public Color()
        {

        }
        public Color(string name)
        {
            Name = name;
        }
    }
}
