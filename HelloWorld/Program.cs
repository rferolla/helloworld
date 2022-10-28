using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Int - 156 como 12334
            // Float - 15.6 como 232.132
            // Bool - true or false
            // String - "Hello World"
            // Char - 'a'

            int segundaGuerraMundial = 1942;
            string myFavoriteColor = "pink";
            float carSpeed = 200.5f;
            bool worldWarII = true;

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(carSpeed);
            Console.WriteLine(worldWarII);  
            Console.WriteLine(myFavoriteColor);

            carSpeed = 201.2f;
            myFavoriteColor = "purple";

            Console.WriteLine(carSpeed);
            Console.WriteLine(myFavoriteColor); 

            Console.ReadLine();
        }
    }
}
