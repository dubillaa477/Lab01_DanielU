using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_DanielUbilla
{
    public class Person:ILogger
    {
        public Person(){

        }

        public Person(int id, string name, string lastname)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string  Lastname { get; set; }

        public void Log(string log)
        {
            Console.WriteLine(log);
        }
    }
}
