using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Pronin_Maksim
{
    class Plane:Transport
    {
        private double max_height;
        public string Name { set; get; }
        public Plane(string name, double max_speed, double weidth, double height)
        {
            this.Name = name;
            this.Weidth = weidth;
            this.Max_speed = max_speed;
            this.Max_height = height;
        }
        public double Max_speed
        {
            set
            {
                if (value < 300 || value > 11000)
                {
                    Console.WriteLine("Введите скорость из диапозона (10;11000)");
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
                if (value < 750 || value > 250000)
                {
                    Console.WriteLine("Введите массу из диапозона (350;20000)");
                }
                else
                {
                    weidth = value;
                }
            }
            get => weidth;
        }
        public double Max_height
        {
            set
            {
                if(value < 1.5 || value > 35)
                {
                    Console.WriteLine("Введите высоту из диапозона (1.5;35)");
                }
                else
                {
                    max_height = value;
                }
            }
            get => max_height;
        }
        override public void GetInfo()
        {
            Console.WriteLine($"Название {Name}, Максимальная скорость = {Max_speed}, Вес = {Weidth}, Максимальная высота полёта {max_height}");
        }
        public void Fly_up(int time, double acceleration, double ascent)
        {
            double speed = 0;
            double height = 0;
            for (int i = 1; i < time; i++)
            {
                speed += acceleration;
                if (speed > max_speed)
                {
                    speed -= acceleration;
                }
                height += ascent;
                if (height > max_height)
                {
                    height -= ascent;
                }
                Console.WriteLine($"Секунда {i} Скорость = {Math.Round(speed, 2)}, Высота = {Math.Round(height,2)}");
            }
            Console.WriteLine($"Максимальная скорость достигнута за {Math.Round((max_speed / acceleration), 2)} с");
            Console.WriteLine($"Максимальная высота достигнута за {Math.Round((max_height / ascent), 2)} с");
            Console.WriteLine($"Расстояние {Math.Round(((speed / 2) * (time) / 3.6),2)} м");
        }
    }
}
