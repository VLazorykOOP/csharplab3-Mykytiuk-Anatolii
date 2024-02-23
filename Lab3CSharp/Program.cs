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

// Базовий клас Test
    class Test
    {
        public string Subj { get; set; } // Предмет
        public DateTime Date { get; set; }  // Дата

        public virtual void Show()
        {
            Console.WriteLine($"Subject: {Subj}, Date: {Date}");
        }
    }

    // Похідний клас Exam
    class Exam : Test
    {
        public int Duration { get; set; } // Тривалість

        public override void Show()
        {
            Console.WriteLine($"Type: Exam, Subject: {Subj}, Date: {Date}, Duration: {Duration} minutes");
        }
    }

    // Похідний клас FinalExam
    class FinalExam : Exam
    {
        public bool IsOral { get; set; } // Усний

        public override void Show()
        {
            Console.WriteLine($"Type: Final Exam, Subject: {Subj}, Date: {Date}, Duration: {Duration} minutes, Oral: {IsOral}");
        }
    }

    // Похідний клас Trial
    class Trial : Test
    {
        public string Supervisor { get; set; } // Спостерігач

        public override void Show()
        {
            Console.WriteLine($"Type: Trial, Subject: {Subj}, Date: {Date}, Supervisor: {Supervisor}");
        }
    }


        static void task2()
        {
            // Створення масиву базового класу Test
            Test[] tests = new Test[5];

            // Заповнення масиву
            tests[0] = new Exam { Subj = "Math", Date = DateTime.Now.AddDays(10), Duration = 90 };
            tests[1] = new FinalExam { Subj = "History", Date = DateTime.Now.AddDays(15), Duration = 120, IsOral = false };
            tests[2] = new Trial { Subj = "Physics", Date = DateTime.Now.AddDays(5), Supervisor = "John Smith" };
            tests[3] = new Exam { Subj = "English", Date = DateTime.Now.AddDays(8), Duration = 60 };
            tests[4] = new FinalExam { Subj = "Biology", Date = DateTime.Now.AddDays(20), Duration = 150, IsOral = true };

            // Виведення масиву, впорядкованого за датою
            Array.Sort(tests, (x, y) => x.Date.CompareTo(y.Date));

            Console.WriteLine("Sorted array:");
            foreach (var test in tests)
            {
                test.Show();
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
                case 2: Console.WriteLine("You choise task 2"); task2(); break;
                case 3: Console.WriteLine("You choise task 3"); break;
            }
        }
    }
}
