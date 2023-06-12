using ContosoPizza.Models;
using System.Diagnostics.Contracts;

namespace ContosoPizza.Services
{
    public class CarService
    {
        static List<Car> Cars {  get; set; }
        static int nextId = 0;
        static CarService()
        {

        }

        public static List<Car> GetAll() => Cars;
        public static Car? Get(int id) => Cars.FirstOrDefault(c => c.Id == id);
        public static void Add(Car car)
        {
            car.Id = nextId++;
            Cars.Add(car);
        }
        public static void Update(Car car)
        {
            var index = Cars.FindIndex(c => c.Id == car.Id);
            if (index == -1) return;
            Cars[index] = car;
        }
        public static void Delete(int id)
        {
            var car = Get(id);
            if (car is null) return;
            Cars.Remove(car);
        }



    }
}
