using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThirdHomeWorkV2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }

        public string Gender { get; set; }

        public int GetAge ()

        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public void PersonGreeting() 
        {
            Console.WriteLine($"Hi, my name is {FirstName} and my last name is {LastName}, I am {Gender} and like {Hobby}");
        }

    }
}
