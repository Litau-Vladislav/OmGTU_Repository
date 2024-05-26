using System;
using System.Collections.Generic;
namespace ConsoleApp43
{
    public class Cars
    {
        public string model;
        public Cars(string model)
        {
            this.model = model;
        }
    }
    class Garage
    {
        static public List<Cars> cars = new List<Cars>();
        public void NewCar(Cars car)
        {
            cars.Add(car);
        }
    }
    static class WashingCars
    {
        static public void WashCar(Cars car)
        {
            Console.WriteLine("Вы помыли автомобиль " + car.model);
        }
    }
        class Program
    {
        delegate void Clean();
        static void Main()
        {
            Garage garage = new Garage();
            garage.NewCar(new Cars("LADA"));
            garage.NewCar(new Cars("Toyota"));
            garage.NewCar(new Cars("Honda"));
            garage.NewCar(new Cars("Mazda"));
            Clean cl;
            cl = wash;
            cl();
            void wash()
            {
                foreach (var car in Garage.cars)
                {
                    WashingCars.WashCar(car);
                }
            }
        }
    }
}