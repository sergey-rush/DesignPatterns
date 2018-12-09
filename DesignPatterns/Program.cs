using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 32;
            person.Name = "Alex";
            
            Guid df = person.GetRefId();

            string s1 = "name";
            string s2 = "name";

            Guid us1 = s1.GetRefId();
            Guid us2 = s2.GetRefId();

        }

        public class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
    }
}
