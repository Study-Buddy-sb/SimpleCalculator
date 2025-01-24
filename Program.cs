Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Welcome to our Amazing Wonderful Arithimetic Machine");
Console.ResetColor();
Console.Clear();
Console.WriteLine("Select An option from the list below");
Console.WriteLine("1. Addition\n2.Subtraction\n3.Division\n4.Multiplication\n5.power off");
string userChoice = Console.ReadLine();
if (userChoice == "1")
{

    Console.WriteLine("Enter First Number: ");
    var first = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Second Number: ");
    var second = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Result = " + (first + second));
}
else if (userChoice == "2")
{
    Console.WriteLine("Enter First Number: ");
    var first = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Second Number: ");
    var second = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Result = " + (first - second));

}
else if (userChoice == "3")
{
    Console.WriteLine("Enter First Number: ");
    var first = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Second Number: ");
    var second = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Result = " + (first / second));
}
else if (userChoice == "4")
{
    Console.WriteLine("Enter First Number: ");
    var first = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Second Number: ");
    var second = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Result = " + (first * second));

}
else if (userChoice == "5"){
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Closed Successfully");
}
else{
    Console.WriteLine("I dont understand you");
}

