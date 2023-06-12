using ContosoPizza.Models;
namespace ContosoPizza.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public float Price { get; set; }
        public bool Card { get; set; }
        public float Distance { get; set; }
        public List<Car> Cars{ get; set; }
        public Car PrefferedCar { get; set; }
    }
}
