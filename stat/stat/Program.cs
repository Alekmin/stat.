
using System.ComponentModel.Design;

var name ="Alek";
var gender = "Male";
var age = 20;

if (gender =="Male")
{
    if (age < 30)
    {
        Console.WriteLine("Mężczyzna poniżej 30 lat");  
    } 
    else if (age == 20 && name == "Alek")
    {
        Console.WriteLine("Alek, lat 20");
    }
}
if (gender == "Male")
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else if (age >= 18)
    {
        Console.WriteLine("Pełnoletni Mężczyzna");
    }
}



    
    