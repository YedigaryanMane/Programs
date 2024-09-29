using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    interface IAnimal
    {
        void Speak();
        void Move();
    }

    abstract class Animal : IAnimal
    {
        public abstract void Speak();
        public abstract void Move();
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Dog : Animal
    {
        public Dog(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public override void Move()
        {
            Console.WriteLine("Dog is moving");
        }

        public override void Speak()
        {
            Console.WriteLine("Dog is speaking");
        }
    }

    class Cat : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Cat is moving");
        }

        public override void Speak()
        {
            Console.WriteLine("Cat is speaking");
        }
    }
    class Bird : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Bird is Moving");
        }

        public override void Speak()
        {
            Console.WriteLine("Bird is speaking");
        }
    }

    interface IRepository<T>
    {
        void Add(T item);
        void RemoveAll();
        List<T> GetAll();   
    }

    class Repository<Dog> : IRepository<Dog>
    {
        
        List<Dog> list = new List<Dog>();
        
        public void Add(Dog item)
        {
            list.Add(item);            
        }

        public List<Dog> GetAll()
        {
          foreach(Dog item in list)
                return list;
          return null;
        }

        public void RemoveAll()
        {
           foreach(Dog item in list)
                list.Remove(item);
        }
    }

    /// <summary>
    /// ////////////////////////////////////
    /// </summary>
    /// 

    interface IEmployee
    {
        string Name { get; set; }
        int EmployeeId { get; set; }

        void CalculateSalary();
    }

    abstract class Employee : IEmployee
    {
        public abstract string Name { get ; set ; }
        public abstract int EmployeeId { get; set ; }

        public abstract void CalculateSalary();    
    }

    class FullTimeEmployee : Employee
    {
        public override string Name { get ; set ; }
        public override int EmployeeId { get ; set ; }

        public override void CalculateSalary()
        {
            Console.WriteLine(8*2000);
        }
    }

    class PartTimeEmployee : Employee
    {
        public override string Name { get ; set ; }
        public override int EmployeeId { get ; set ; }

        public override void CalculateSalary()
        {
            Console.WriteLine(4*2000);
        }
    }

    class EmployeeManager : IEmployee
    {
        public string Name { get; set ; }
        public int EmployeeId { get ; set ; }

        public void CalculateSalary()
        {
            Console.WriteLine(8*3000);
        }
    }

    class Extencion
    {
        public void Filter(Employee emp)
        {
            Console.WriteLine($"{emp.EmployeeId} || {emp.Name}");
        }

        public void CalculateTotalPayroll()
        {
            Console.WriteLine("1.FullTime || 2.PartTime");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
                fullTimeEmployee.CalculateSalary();
            }
            else if (n == 2)
            {
                PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
                partTimeEmployee.CalculateSalary();
            }
            else
            {
                Console.WriteLine("Number is incorrect.");
            }
        }
    }

    
    /// <summary>
    /// ///////////
    /// </summary>
    /// 

    interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
        decimal GetPrice();
    }

    abstract class Product : IProduct
    {
        public string Name { get ; set ; }
        public decimal Price { get ; set ; }
        
        public decimal GetPrice()
        {
            return Price;
        }
    }

    class Electronics : Product { }
    class Clothing : Product { }
    class  Grocery:Product { }

    class ShoppingCart : IProduct
    {
        public string Name { get; set ; }
        public decimal Price { get; set ; }

        public decimal GetPrice()
        {
            return Price;
        }
    }

    class Extencionn
    {
        Product product = null;
        public decimal TotalPrice()
        {
            return product.GetPrice();
        }

        public void Discounts()
        {
            Console.WriteLine("How many must the discount be?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((product.Price *n)/100);
        }
    }

    /// <summary>
    /// ///////////
    /// </summary>
    /// 

    interface IShape
    {
        void Draw();
        void CalculateArea();
    }

    abstract class Shape : IShape
    {
        public void CalculateArea() { }
        public void Draw() { }
    }

    class Circle : Shape { }
    class Rectangle:Shape { }
    class Triangle:Shape { }

    class Extension
    {
        Shape shape1 = null;
        public void Filter(Shape shape)
        {
            shape.Draw();
            shape.CalculateArea();
        }

        public void CalculateTotalArea()
        {
            
            Console.WriteLine("1.Circle || 2.Rectangle || 3.Triangle ");
            int n = int.Parse((Console.ReadLine()));

            if(n==1)
            {
                Circle circle = new Circle();
                circle.CalculateArea();
            }
            else if(n==2) 
            {
                 Rectangle rectangle = new Rectangle();
                rectangle.CalculateArea();  
            }
            else
            {
                Triangle triangle = new Triangle();
                triangle.CalculateArea();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
