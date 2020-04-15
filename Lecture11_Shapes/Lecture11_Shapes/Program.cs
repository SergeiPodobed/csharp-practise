using System;

namespace Lecture11_Shapes
{
    class Programm
    {
        static void Main(string[] args)
        {
        Random rnd = new Random();
        int side = rnd.Next(1, 10);
        int hight = rnd.Next(1, 10);
        int radius = rnd.Next(1, 10);
            Quadrate quadrate = new Quadrate(side);
            Rectang rectang = new Rectang(side, hight);
            Cyrcle cyrcle = new Cyrcle(radius);
            Console.ReadKey();
        }
    }
      
    
    abstract class Shapes
    {
        // Задача: 
        // вывести массив, отображаюший площадь круга, квадрата, равнобедренного треугольника со сторонами от 1 до 10
        // логика:
        //1. создать базовый класс для описания фигур
        //2. добавить методы для вычисления площади
        //3. создать производные класса квадрат, теугольник, круг
        //4. Задать поля (свойства) для хранения сторон и радиуса
        //5. задать методы для вычисления площади
        //6. написать алгоритм, создающий массив из 3 х фигур
        //7. вывод на консоль

        public abstract double Area();
         
    }
        class Quadrate : Shapes
    {
        public int Side { get; set; }

        public Quadrate(int side)
        {
            this.Side = side;
        }
        public override double Area()
        {
            return Side * Side;
        }
        class Rectang : Shapes
        {
            public int Side { get; set; }
            public int Hight { get; set; }
            
            public Rectang (int side, int hight)
            {
                this.Side = side;
                this.Hight = hight;
            }
            public override double Area()
            {
                return Side * Hight / 2;
            }
        }
        class Cyrcle : Shapes
        {
            public int Radius { get; set; }
            
            public Cyrcle(int radius)
            {
                this.Radius = radius;
            }
            public override double Area()
            {
                return Math.PI * Math.Pow(Radius, 2) / 2;
            }
        }
    }
}
