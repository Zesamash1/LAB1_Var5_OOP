using System;

namespace LAB1_Var5_OOP
{
    class Program
    {
        public class Shar
        {
            private double r;

            public Shar(double radius)
            {
                r = radius;
            }

            public bool Correct()
            {
                return r > 0;
            }

            public double Area()
            {
                return 4 * Math.PI * Math.Pow(r, 2);
            }

            public double Volume()
            {
                return (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            }

            public void Print()
            {
                Console.WriteLine($"Радіус кулі: r={r}");
            }

            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                try
                {
                    Console.Write("Введіть радіус кулі: ");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    Shar sharp = new Shar(radius);
                    sharp.Print();

                    if (sharp.Correct())
                    {
                        Console.WriteLine($"Площа поверхні кулі: {sharp.Area():F3}");
                        Console.WriteLine($"Об'єм кулі: {sharp.Volume():F3}");
                    }
                    else
                    {
                        Console.WriteLine("Куля з таким радіусом не існує!!!");
                    }
                }
                catch
                {
                    Console.WriteLine("Помилка!!!");
                }

                Console.ReadKey();
            }
        }
    }
}
