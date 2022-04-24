using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThirdHomeWorkV2
{
    public class MyPhoneHomeWorkV2
    {
        
        public double Length { get; set; }                      
        public double Width { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string NumberToCall { get; set; }
        public string SmsText{ get; set; }

        public void Size()
        {
            Console.WriteLine($"Your phone lenght is {Length} and width is {Width}");
        }


        public void Greeting()
        {
            Console.WriteLine($"Your new phone {Brand} , {Model}:");
        }

        public void Call()
        {
            Console.WriteLine($"    - is calling to the number {NumberToCall}");
        }

        public void SMS() 
        {
            Console.WriteLine($"    - and will send the SMS: {SmsText}, to the number {NumberToCall}");
        }
                  
    }
}
