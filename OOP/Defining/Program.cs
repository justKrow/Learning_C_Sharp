using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new object instances using the "new" operator
            Book b1 = new Book("Love is war", "JP guy", 800);
            Book b2 = new Book("vinland", "JP old", 500);

            // TODO: Call a method on the object
            Console.WriteLine(b1.getDescription());
            Console.WriteLine(b2.getDescription());

            // TODO: try to set one of the properties -- 
            // this will result in an error
            b1._name = "not jp";
        }
    }
}
