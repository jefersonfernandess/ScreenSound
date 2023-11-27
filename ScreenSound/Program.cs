// Screen Sound

void ShowMesageToWelcome()
{
    string mensageWelcome = "Welcome to Screen Sound";
    //logo screan sound
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    Console.WriteLine(mensageWelcome);
}

void ShowOptionsToMenu()
{
    Console.WriteLine("\nEnter 1 to register a new band");
    Console.WriteLine("Enter 2 to show all the bands");
    Console.WriteLine("Enter 3 to rate a band");
    Console.WriteLine("Enter 4 to display the average of a band");
    Console.WriteLine("Enter 0 to exit");

    Console.Write("\nType your option: ");
    int optionSelected = int.Parse(Console.ReadLine()!);

    switch(optionSelected)
    {
        case 0:
            break;
        case 1: Console.WriteLine("You select the option => " + optionSelected);
            break;
        case 2:
            Console.WriteLine("You select the option => " + optionSelected);
            break;
        case 3:
            Console.WriteLine("You select the option => " + optionSelected);
            break;
        case 4:
            Console.WriteLine("You select the option => " + optionSelected);
            break;
        default: Console.WriteLine("Option invalid!");
            break;
    }
}
ShowMesageToWelcome();
ShowOptionsToMenu();