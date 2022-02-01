Console.WriteLine("Hi! Please enter your name");
string userName = Console.ReadLine();
bool loop = true;

do {
    Console.WriteLine("Thank you, " + userName + ". Please enter an integer between 1 and 100.");
    int userInt = int.Parse(Console.ReadLine());

    if (userInt < 1 || userInt > 100)
    {
        Console.Write("I can't believe you just did that...");
    } else if (userInt % 2 == 0 && userInt >= 2 && userInt <= 24) {
        Console.WriteLine("Thank you, " + userName + ". " + userInt + " is even and less than 25");
    } else if (userInt % 2 == 0 && userInt >= 26 && userInt <= 60)
    {
        Console.WriteLine("Thank you, " + userName + ". " + userInt + " is even and between 26 and 60 inclusive");
    } else if (userInt % 2 == 0 && userInt > 60)
    {
        Console.WriteLine("Thank you, " + userName + ". " + userInt + " is even and greater than 60");
    } else if (userInt % 2 == 1 & userInt > 60)
    {
        Console.WriteLine("Thank you, " + userName + ". " + userInt + " is odd and greater than 60");
    } else if (userInt % 2 == 1 && userInt < 60)
    {
        Console.WriteLine("Thank you, " + userName + ". " + userInt + " is odd and less than 60");
    }
    Console.WriteLine("Would you like to go again " + userName + "? y/n");
    string loopChoice = Console.ReadLine();
    if (loopChoice == "y")
    {
        loop = true;
    } else
    {
        loop = false;
        Console.WriteLine("Suit yourself. Goodbye!");
    }
} while (loop);
