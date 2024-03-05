namespace Entities.Concretes
{
    public class CarColor
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }

        public int ColorId { get; set; }
        public Color Color { get; set; }
    }
}
