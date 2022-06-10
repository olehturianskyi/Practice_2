using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice_2.Models
{
    internal class Car
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
        public void ShowCar()
        {
            Car car = new Car(numberModel, year, brand, price);
            numberModel = car.NumberModel;
            year = car.Year;
            brand = car.Brand;
            price = car.Price;
            string _year = Convert.ToString(numberModel);
            string _brand = brand;
            string _price = Convert.ToString(price);
            string _numberModel = Convert.ToString(numberModel);
            Console.Clear();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("| Number of model |    Brand    |  Year  | Price |");
            Console.WriteLine("--------------------------------------------------");
            Console.SetCursorPosition(12, 6);
            Console.Write(_numberModel);
            Console.Write("  ");
            Console.SetCursorPosition(30, 6);
            Console.Write(_year);
            Console.Write("  ");
            Console.SetCursorPosition(50, 6);
            Console.Write(_brand);
            Console.Write("  ");
            Console.SetCursorPosition(70, 6);
            Console.Write(_price);
        }
    }
}
