using Practice_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создайте класс Car и добавьте возможность просматривать список автомобилей и добавлять новое значение в этот список.
критерии приемлемости
Добавить меню для работы со списком автомобилей
Добавьте в класс Car следующие свойства: int NumberModel , int Year , string Brand , decimal Price
цена
Все входные значения должны быть проверены. Если введенное пользователем значение с ошибкой печати неправильного типа
сообщение "Неверный формат. Повторите попытку"
 */
namespace Practice_2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberModel = 0;
            int year = 0;
            string brand = "";
            decimal price = 0;
            Car car = new Car(numberModel, year, brand, price);
            car.CreateCar();             
            
            List<Car> cars = new List<Car>();           
            int choice = 0;
            while (choice != 3)
            {
                choice = car.MenuCar();
                Console.Clear();
                if (choice == 1)
                {                                        
                    for (int i = 0; i < cars.Count; i++)
                    {
                        Car _car = cars[i];
                        _car.ShowCar();                        
                    }
                    Console.WriteLine("Press ENTER");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("ADDING A CAR: ");
                    numberModel = Convert.ToInt32(Console.ReadLine());
                    year = Convert.ToInt32(Console.ReadLine());
                    brand = Console.ReadLine();
                    price = Convert.ToInt32(Console.ReadLine());
                    cars.Add(new Car(numberModel, year, brand, price));
                    Console.WriteLine("CAR WAS ADDED");
                    Console.WriteLine("Press ENTER");
                    Console.ReadKey();
                    Console.Clear();
                }
            }   
        }
    }
}

