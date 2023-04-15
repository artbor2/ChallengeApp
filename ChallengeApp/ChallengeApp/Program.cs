var name = "Ewa";
bool female = true;
var age = 33;


if (female && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine(name + ", lat " + age);
}
else if (!female && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("To jest już koniec.");
}
