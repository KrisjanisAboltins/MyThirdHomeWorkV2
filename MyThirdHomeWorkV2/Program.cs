
using MyThirdHomeWorkV2;

// Telefons - 1. Uzdevums
MyThirdHomeWorkV2.MyPhoneHomeWorkV2 phone = new MyPhoneHomeWorkV2();

Console.WriteLine("Please write your phone lenght");
string lengthText = Console.ReadLine();
double length = double.Parse(lengthText);
phone.Length = length;

Console.WriteLine();

Console.WriteLine("Please write your phone width");
string widthText = Console.ReadLine();
double width = double.Parse(widthText);
phone.Width = width;

Console.WriteLine();

double phoneArea = length * width;
double phoneAreaRounded = Math.Round(phoneArea, 2);
phone.Size();
Console.WriteLine($"Your phone area is {phoneAreaRounded}");

Console.WriteLine();

Console.WriteLine("Please write your phone brand");
string brandText = Console.ReadLine();
phone.Brand = brandText;

Console.WriteLine();

Console.WriteLine("Please write your phone model");
string modelText = Console.ReadLine();
phone.Model = modelText;

Console.WriteLine();

Console.WriteLine("Please write phone number to call");
string numberToCallText = Console.ReadLine();
phone.NumberToCall = numberToCallText;

Console.WriteLine();

Console.WriteLine("Please write the SMS text");
string smsText = Console.ReadLine();
phone.SmsText = smsText;

Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();

phone.Greeting();
phone.Call();
phone.SMS();

Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();



// Automašīna - 2. Uzdevums





