
using MyThirdHomeWorkV2;

// Telefons - 1.Uzdevums
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
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

phone.Greeting();
phone.Call();
phone.SMS();

Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();



// Automašīna - 2. Uzdevums

MyThirdHomeWorkV2.CarHomeWork3 myCar = new CarHomeWork3();

Console.WriteLine("Please write your car brand");
string carBrandText = Console.ReadLine();
myCar.CarBrand = carBrandText;

Console.WriteLine();

Console.WriteLine("Please write your the car licence plate");
string carLicencePlateText = Console.ReadLine();
myCar.CarLicencePlate = carLicencePlateText;

Console.WriteLine();

Console.WriteLine("Please write driving speed");
string carSpeedText = Console.ReadLine();
double carSpeedNumber = double.Parse(carSpeedText);
myCar.CarSpeed = carSpeedNumber;

Console.WriteLine();
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

myCar.StartToDrive();
myCar.IncreaseTheSpeed();
myCar.DecreaseTheSpeed();

Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();

// Prece - 3. Uzdevums

MyThirdHomeWorkV2.ItemHomeWork3 myItem = new ItemHomeWork3(3, 3, 5);


myItem.ItemParameters();


Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();


// Persona - 4. Uzdevums

MyThirdHomeWorkV2.Person persona = new Person();

Console.WriteLine("Please write your first name");
string firstNameText = Console.ReadLine();
persona.FirstName = firstNameText;

Console.WriteLine("Please write your last name");
string lastNameText = Console.ReadLine();
persona.LastName = lastNameText;

Console.WriteLine("Please write your BirthDate");
string birthDatetext = Console.ReadLine();
DateTime birthDateDate = DateTime.Parse(birthDatetext);
persona.BirthDate = birthDateDate;

Console.WriteLine("Please write your hobby");
string hobbyText = Console.ReadLine();
persona.Hobby = hobbyText;

Console.WriteLine("Please write your gender");
string genderText = Console.ReadLine();
persona.Gender = genderText;

persona.GetAge();
persona.PersonGreeting();

