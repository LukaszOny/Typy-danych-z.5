string name;
string surname;
int age;
int hight;


Console.WriteLine("Please enter your name");

name = Console.ReadLine();


if (name == "Łukasz")
{
    Console.WriteLine("You are Ok!");
}
else
{
    Console.WriteLine("Enter corect name");
}


Console.WriteLine("Now, please enter your surname");
surname = Console.ReadLine();
Console.WriteLine($"You are:{name} {surname}");

if (surname == "Onyszko")
{
    Console.WriteLine("Welcome mr Onyszko!");
}
else
{
    {
        Console.WriteLine("Fuck you, it's not realy you");
    }
}



Console.WriteLine("Please enter your age");
string choice = Console.ReadLine();
int chosenOperation = 0;
Int32.TryParse(choice, out chosenOperation);

if (chosenOperation == 0)
{
    Console.WriteLine("You are too young");
}
else if (chosenOperation == 0 + 1)
{
    Console.WriteLine("Ok!");
}






Console.WriteLine("Please enter yor hight (cm)");
string choice2 = Console.ReadLine();
Int32.TryParse(choice2, out chosenOperation);


Console.WriteLine($"Your age is {choice} and hight is {choice2}");



   