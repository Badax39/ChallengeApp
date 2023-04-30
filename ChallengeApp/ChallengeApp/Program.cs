string name;
char sex;
int age;

name = "Ewa";
sex = 'm';
age = 100;

if (sex == 'k' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30");
}
else
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        if (age < 18 && sex == 'm')
        {
            Console.WriteLine("Niepełnoletni mężczyzna");
        }
        else
        {
            Console.WriteLine("Żaden z warunków nie został spełniony");
        }
    }
}


