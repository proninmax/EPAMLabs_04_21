using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2_Pronin_Maksim
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            Car car1 = new Car("Ferrary", 350, 700);
            Car car2 = new Car("Zhiguli", 150, 1000);
            Car car3 = new Car("Chevrolet", 210, 1100);
            Car car4 = new Car("Mitsubisy", 210, 1150);
            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);
            carList.Add(car4);
            var result = carList.OrderBy(car => car.Max_speed).ThenBy(car => car.Weidth);
            Console.WriteLine("CarName \t Speed \t Weidth");
            foreach (Car car in result)
                Console.WriteLine($"{car.Name} \t {car.Max_speed} \t {car.Weidth}");
            Console.WriteLine("Enter parametr car: Name, MaxSpeed, Weidth");
            string name = Console.ReadLine();
            double maxSpeed = double.Parse(Console.ReadLine());
            double weidth = double.Parse(Console.ReadLine());
            try
            {
                Car car5 = new Car(name, maxSpeed, weidth);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
