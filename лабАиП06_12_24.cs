using System;
namespace _06._12
{
    public class Konstruct
    {
        public int a;
        public int b;

        public Konstruct()
        {
            a = 0;
            b = 0;
        }

        public Konstruct(int a)
        {
            this.a = a;
        }

        public Konstruct(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Sum()
        {
            int c = this.a + this.b;
            Console.WriteLine(c);
        }
        
        public void Umn()
        {
            Console.WriteLine(this.a*this.b);
        }

        public void Del()
        {
            if (this.b == 0)
            {
                Console.WriteLine("Деление на ноль невозможно!");
            }
            else
            {
                int d = this.a / this.b;
                Console.WriteLine(d);
            }
        }

        public void Raz()
        {
            int r = this.a - this.b;
            Console.WriteLine(r);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Konstruct[] array =
            {
                new Konstruct(),
                new Konstruct(7),
                new Konstruct(3,5)
            };
            foreach (Konstruct ar in array)
            {
                Console.WriteLine($"{ar.a}, {ar.b}");
                ar.Sum();
                ar.Umn();
                ar.Del();
                ar.Raz();
            }

        }
    }
}
