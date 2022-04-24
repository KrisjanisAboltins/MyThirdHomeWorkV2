using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThirdHomeWorkV2
{
    public class ItemHomeWork3
    {
        
        
        public ItemHomeWork3(double itemLenghtNumber, double itemWidthNumber, double itemWeightNumber)
        {
            itemLenghtNumber = ItemLenght;
            itemWidthNumber = ItemWidth;
            itemWeightNumber = ItemWeight;
        }



        public string ItemName { get; set; }
        public double ItemLenght { get; }
        public double ItemWidth { get; }
        public double ItemWeight { get; }

        public void ItemParameters() 
        {
            Console.WriteLine($"The item lenght is {ItemLenght}, the with is {ItemWidth} and the weight is {ItemWeight}");
        }
            
    }
}



