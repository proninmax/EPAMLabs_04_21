using System;

namespace Lab2_Pronin_Maksim
{
    class Car : Transport
    {
        public string Name { set; get; }
        public Car(string name, double max_speed, double weidth)
        {
            this.Name = name;
            this.Weidth = weidth;
            this.Max_speed = max_speed;
        }
        public double Max_speed
        {
            set
            {
                if (value < 10 || value > 482.8)
                {
                    throw new ArgumentException("Введена некорректная скорость");
                }
                else
                {
                    max_speed = value;
                }
            }
            get => max_speed;
        }
        public double Weidth
        {
            set
            {
                if (value < 350 || value > 20000)
                {
                    throw new ArgumentException("Введена некорректная масса");
                }
                else
                {
                    weidth = value;
                }
            }
            get => weidth;
        }
        override public void GetInfo()
        {
            Console.WriteLine($"Название {Name}, Максимальная скорость = {Max_speed} км/ч, Вес = {Weidth} кг");
        }
        public void Drive(int time, double acceleration)
        {
            double speed = 0;
            for (int i = 1; i < time; i++)
            {
                speed += acceleration;
                if (speed > max_speed)
                {
                    speed -= acceleration;
                }
                Console.WriteLine($"Секунда {i} Скорость = {Math.Round(speed, 2)}");
            }
            Console.WriteLine($"Максимальная скорость достигнута за { Math.Round(max_speed / acceleration, 2)} с");
            Console.WriteLine($"Расстояние {Math.Round((speed / 2) * (time) / 3.6, 2)} м");
        }
    }
}
