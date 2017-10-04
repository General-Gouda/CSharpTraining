using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";

            
            List<Car> myList = new List<Car>();

            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1); //Wrong!

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

            /*
            Dictionary<string,Car> myDictionary = new Dictionary<string,Car>();
            myDictionary.Add(car1.Make,car1);
            myDictionary.Add(car2.Make,car2);

            Console.WriteLine(myDictionary["Geo"].Model);

            //string[] names = { "Bob","Steve","Brian","Chuck" };

            Car car1 = new Car()
            {
                Make = "Oldsmobile",
                Model = "Cutlass Supreme"
            };

            Car car2 = new Car()
            {
                Make = "Geo",
                Model = "Prism"
            };

            Car car3 = new Car()
            {
                Make = "Nissan",
                Model = "Altima"
            };
            */

            List<Car> cars = new List<Car>()
            {
                new Car {Make = "Oldsmobile", Model = "Cutlass Supreme" },
                new Car {Make = "Geo", Model = "Prism" },
                new Car {Make = "Nissan", Model = "Altima" }
            };

            foreach (Car car in cars)
            {
                Console.WriteLine("Make: {0}\nModel: {1}\n\n", car.Make, car.Model);
            }


            List<Book> books = new List<Book>() {
                new Book { ISBN = "978-1455509126", Title = "So Good They Can't Ignore You", Author = "Cal Newport"},
                new Book { ISBN = "978-0465050659", Title = "The Design of Everyday Things", Author = "Don Norman"},
                new Book { ISBN = "978-0321965516", Title = "Don't Make Me Think", Author = "Steve Krug"},
                new Book { ISBN = "978-1594484803", Title = "Drive", Author = "Daniel Pink"}
            };

            foreach (Book book in books)
            {
                Console.WriteLine("Title: {0}\nAuthor: {1}\nISBN: {2}\n\n",book.Title,book.Author,book.ISBN);
            }

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }


    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

}
