using System;

namespace Lab2_Pronin_Maksim
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Ferrary", 300, 700);
            car.GetInfo();
            car.Drive(10, 23);
            Console.ReadKey();
            Plane plane = new Plane("Mig-35", 2500, 3000, 10);
            plane.GetInfo();
            plane.Fly_up(100, 100, 0.03);
            Console.ReadLine();
        }
    }
}
