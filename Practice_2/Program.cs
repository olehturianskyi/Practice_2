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
    class Car
    {
        int numberModel;
        int year;
        string brand;
        decimal price;

        int NumberModel
        {
            get { return numberModel; }
            set
            {
                if (numberModel.GetType() != value.GetType()) Console.WriteLine("Incorrect format!");
                else numberModel = value;
            }
        }
        int Year
        {
            get { return year; }
            set
            {
                if (year.GetType() != value.GetType()) Console.WriteLine("Incorrect format!");
                else year = value;
            }
        }
        string Brand
        {
            get { return brand; }
            set
            {
                if (brand.GetType() != value.GetType()) Console.WriteLine("Incorrect format!");
                else brand = value;
            }
        }
        decimal Price
        {
            get { return price; }
            set
            {
                if (price.GetType() != value.GetType()) Console.WriteLine("Incorrect format!");
                else price = value;
            }
        }
        public Car(int numberModel, int year, string brand, decimal price)
        {
            this.numberModel = numberModel;
            this.year = year;
            this.brand = brand;
            this.price = price;
        }
        public int MenuCar()
        {
            Console.WriteLine(new string('=', 50));

            Console.WriteLine("Menu for working:\n     1. CHECK ALL CARS\n     2. ADD NEW CAR\n     3. EXIT\nSelect option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }
        public Car CreateCar()
        {
            Car car = new Car(numberModel, year, brand, price);
            car.NumberModel = numberModel;
            car.Year = year;
            car.Brand = brand;
            car.Price = price;
            return car;
        }
           
    }
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
            cars.Add(car);
            int choice = 0;
            while (choice != 3)
            {
                choice = car.MenuCar();
                Console.Clear();
                if (choice == 1)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("| Number of model |    Brand    |  Year  | Price |");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine(Convert.ToString(numberModel) + Convert.ToString(year) +Convert.ToString(brand) +Convert.ToString(price));
                    
                    for (int i = 0; i < cars.Count; i++)
                    {
                        Car _car = cars[i];
                        Console.WriteLine(Convert.ToString(car));
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

