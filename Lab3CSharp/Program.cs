namespace Lab3CSharp
{
    internal class Program
    {

        class Trapeze
        {
            private int a; // основа a
            private int b; // основа b
            private int h; // висота h
            private int color; // колір

            // Конструктор
            public Trapeze(int a, int b, int h, int color)
            {
                this.a = a;
                this.b = b;
                this.h = h;
                this.color = color;
            }

            // Метод для довжин
            public void PrintLengths()
            {
                Console.WriteLine($"a = {a}, b = {b}, h = {h}");
            }

            // Метод для периметру
            public int CalculatePerimeter()
            {
                return a + b + 2 * h;
            }

            // Метод для площі
            public double CalculateArea()
            {
                return (a + b) * h / 2.0;
            }

            // Доступ до основ
            public int A
            {
                get { return a; }
                set { a = value; }
            }

            public int B
            {
                get { return b; }
                set { b = value; }
            }

            // Доступ до висоти
            public int H
            {
                get { return h; }
                set { h = value; }
            }

            // Доступ до кольору(тільки для читання)
            public int Color
            {
                get { return color; }
            }

            // Перевірка трапеція чи квадрат (тільки для читання)
            public bool IsSquare
            {
                get { return a == b; }
            }
        }

        static void task1()
        {
            // Об'єкт трапеції
            Trapeze trapeze = new Trapeze(5, 7, 4, 1);

            // Виводимо
            Console.WriteLine("Lengths:");
            trapeze.PrintLengths();

            // Периметр
            Console.WriteLine($"Perimeter: {trapeze.CalculatePerimeter()}");

            // Площа
            Console.WriteLine($"Area: {trapeze.CalculateArea()}");

            // Трапеція чи квадрат
            if (trapeze.IsSquare)
            {
                Console.WriteLine("This trapeze is a square.");
            }
            else
            {
                Console.WriteLine("This trapeze is not a square.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 3 ");
            Console.WriteLine("Please input task");

            Console.Write("n=");

            byte n = byte.Parse(Console.ReadLine());

            switch (n)
            {
                case 1: Console.WriteLine("You choise task 1"); task1(); break;
                case 2: Console.WriteLine("You choise task 2"); break;
                case 3: Console.WriteLine("You choise task 3"); break;
            }
        }
    }
}
