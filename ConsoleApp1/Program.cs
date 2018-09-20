using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01_Console;
using Lab01_DanielUbilla;

namespace Lab01_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person");

            

            Person person = new Person(0,"Daniel","Ubilla");
            ILogger logger=person
                ;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //Metodo anonimo
            //Person person = new Person {
            //    Id = 1,
            //    Name = "Daniel",
            //    Lastname = "Ubilla"
            //};

            //Los numeros representan el campo en el arreglo de Format, sin ellos no hay referencia al parametro.
            string personString = string.Format("Id: {0}, Name: {1}, Lastname: {2}",person.Id, person.Name, person.Lastname);

            Console.WriteLine(personString);
            logger.Log("Hello  world!");

            Console.ReadKey();
        }
    }
}
