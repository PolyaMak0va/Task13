using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    /* Задан класс Building, который описывает здание. Класс содержит следующие элементы:
     * адрес здания;
     * длина здания;
     * ширина здания;
     * высота здания.
     * В классе Building нужно реализовать следующие методы:
     * конструктор с 4 параметрами;
     * свойства get/set для доступа к полям класса;
     * метод Print(), который выводит информацию о здании.
     * Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. 
     * В классе MultiBuilding реализовать следующие элементы:
     * конструктор с 5 параметрами – реализует вызов конструктора базового класса;
     * свойство get/set доступа к внутреннему полю класса;
     * метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
     * Класс MultiBuilding сделать таким, что не может быть унаследован.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Building bldng = new Building("Пушкина", "12П", 120, 45, 25);
            MultiBuilding multiBldng = new MultiBuilding(bldng.AddressB, bldng.NumberB, bldng.LengthB, bldng.WidthB, bldng.HeightB, 5);
            multiBldng.Print();
            Console.ReadKey();
        }
        class Building
        {
            public string AddressB { get; set; }
            public string NumberB { get; set; }
            int lengthB;
            int widthB;
            int heightB;

            public int LengthB
            {
                set
                {
                    if (value > 0)
                    {
                        lengthB = value;
                    }
                    else
                    {
                        Console.WriteLine("Длина здания не может быть отрицательной!");
                    }
                }
                get
                {
                    return lengthB;
                }
            }
            public int WidthB
            {
                set
                {
                    if (value > 0)
                    {
                        widthB = value;
                    }
                    else
                    {
                        Console.WriteLine("Ширина здания не может быть отрицательной!");
                    }
                }
                get
                {
                    return widthB;
                }
            }
            public int HeightB
            {
                set
                {
                    if (value > 0)
                    {
                        heightB = value;
                    }
                    else
                    {
                        Console.WriteLine("Высота здания не может быть отрицательной!");
                    }
                }
                get
                {
                    return heightB;
                }
            }
            public Building()
            {

            }
            public Building(string addressB, string numberB, int lengthB, int widthB, int heightB)
            {
                AddressB = addressB;
                NumberB = numberB;
                LengthB = lengthB;
                WidthB = widthB;
                HeightB = heightB;
            }
            public void Print()
            {
                Console.WriteLine("Здание находится по адресу:\nул. {0}, дом {1}\n ", AddressB, NumberB);
                Console.WriteLine("Параметры здания:\nдлина - {0} м\nширина - {1} м\nвысота - {2} м\n", LengthB, WidthB, HeightB);
            }
        }
        sealed class MultiBuilding : Building
        {
            int floorB;
            public int FloorB
            {
                set
                {
                    if (value > -1)
                    {
                        floorB = value;
                    }
                    else
                    {
                        Console.WriteLine("В здании предусматривается только один цокольный этаж");
                    }
                }
                get
                {
                    return floorB;
                }
            }
            public MultiBuilding(string addressB, string numberB, int lengthB, int widthB, int heightB, int floorB)
            {
                AddressB = addressB;
                NumberB = numberB;
                LengthB = lengthB;
                WidthB = widthB;
                HeightB = heightB;
                FloorB = floorB;
            }
            public new void Print()
            {
                base.Print();
                Console.WriteLine("этажность - {0}\t", FloorB);
            }
        }
    }
}
