// Screen Sound

Dictionary<string, List<int>> bandsInfo = new Dictionary<string, List<int>>();
bandsInfo.Add("Link Park", new List<int> {10, 8, 6 });
bandsInfo.Add("Artic Monkeys", new List<int>());

void ShowLogo()
{
    string mensageWelcome = "Welcome to Screen Sound";
    //logo screan sound
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    Console.WriteLine(mensageWelcome);
}

void ShowTitleOptions(string title)
{
    int qty = title.Length;
    string asterisk = string.Empty.PadLeft(qty, '*');
    Console.WriteLine(asterisk);
    Console.WriteLine(title);
    Console.WriteLine(asterisk + "\n");
}

void ShowOptionsToMenu()
{
    ShowLogo();
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
        case 1: RegisterBand();
            break;
        case 2: ShowAllBands();
            break;
        case 3: EvaluatingBand();
            break;
        case 4: DisplayTheBandAverage();
            break;
        default: Console.WriteLine("Option invalid!");
            break;
    }
}
void RegisterBand()
{
    Console.Clear();
    ShowTitleOptions("Register bands");
    Console.Write("Enter the name of the band you want to register: ");
    string nameBand = Console.ReadLine()!;
    bandsInfo.Add(nameBand, new List<int>());
    Console.WriteLine($"Band: {nameBand} was successfully registered");
    Thread.Sleep(2300);
    Console.Clear();
    ShowOptionsToMenu();
}
void ShowAllBands()
{
    Console.Clear();
    ShowTitleOptions("Show all bands");
    foreach (string band in bandsInfo.Keys)
    {
        Console.WriteLine("Banda: " + band);
    }
    Console.WriteLine("\nType any key to return to the menu");
    Console.ReadKey();
    Console.Clear();
    ShowOptionsToMenu();
}

void EvaluatingBand()
{
    // search a band to evaluating
    Console.Clear();
    ShowTitleOptions("Evaluating a band");
    Console.Write("Which band do you want to rate? ");
    string bandToEvaluating = Console.ReadLine()!;

    if(bandsInfo.ContainsKey(bandToEvaluating))
    {
        Console.Write($"How would you rate the band *{bandToEvaluating}*: ");
        int rateBand = int.Parse(Console.ReadLine()!);
        bandsInfo[bandToEvaluating].Add(rateBand);
        Thread.Sleep(2000);
        Console.WriteLine($"The note {rateBand} has been added to band {bandToEvaluating}");
        Thread.Sleep(3500);
        Console.Clear();
        ShowOptionsToMenu();
    }
    else
    {
        Console.WriteLine($"The band {bandToEvaluating} was not found");
        Console.WriteLine("\nType any key to return to the menu");
        Console.ReadKey();
        Console.Clear();
        ShowOptionsToMenu();
    }
}

void DisplayTheBandAverage()
{
    Console.Clear();
    ShowTitleOptions("Display the band's average score");
    Console.Write("Which band do you want to knowa avarege score? ");
    string bandSelected = Console.ReadLine()!;

    if (bandsInfo.ContainsKey(bandSelected))
    {
        Console.WriteLine("Calculando...");
        Thread.Sleep(2000);
        List<int> result = bandsInfo[bandSelected];
        Console.WriteLine($"The avarege score to band {bandSelected} is: {result.Average()}");
        Thread.Sleep(2000);
        Console.Clear();
        ShowOptionsToMenu();
    }
    else
    {
        Console.WriteLine($"The band {bandSelected} was not found");
        Console.WriteLine("\nType any key to return to the menu");
        Console.ReadKey();
        Console.Clear();
        ShowOptionsToMenu();
    }
}

ShowOptionsToMenu();