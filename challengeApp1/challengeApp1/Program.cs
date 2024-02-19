string name = "Ewa";
string sex = "Mężczyzna";
var age = 30;

if(sex == "Kobieta")
{
    if(age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    } 
    else if(age == 30 && name == "Ewa")
    {
        Console.WriteLine("Ewa ma 30 lat");
    }
}
else if(sex == "Mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełno letni Mężczyzna");
}