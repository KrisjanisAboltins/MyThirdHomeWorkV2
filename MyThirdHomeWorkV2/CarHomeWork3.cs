using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThirdHomeWorkV2
{
    public class CarHomeWork3
    {
        public string CarBrand { get; set; }
        public string CarLicencePlate { get; set; }
        public double CarSpeed { get; set; }


        public void StartToDrive() 
        {
            
            Console.WriteLine($"The car {CarBrand}, {CarLicencePlate} starts to drive, the car speed is {CarSpeed}.");     
        }

        public void Beep()
        {

            Console.WriteLine($"The car siganalizes {Beep}.");
        }

        public void IncreaseTheSpeed()
        {
            CarSpeed += 1;
            Console.WriteLine($"The car speed is {CarSpeed}, the car drives faster.");            
        }
        public void DecreaseTheSpeed()
        {
            CarSpeed -= 2;
            Console.WriteLine($"The car speed is {CarSpeed}, the car decrease the speed.");

        }

    }
}
