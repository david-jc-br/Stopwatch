class Program
{
    static void Main()
    {
        MenuLanguage();
    }

    static void MenuLanguage()
    {
        Console.Clear();
        Console.WriteLine(" Choose Language\n(Escolha o idioma)");
        Console.WriteLine("--------------------");
        Console.WriteLine("P - Portuguese\nE - English");
        Console.WriteLine("--------------------");
        
        char option = char.Parse(Console.ReadLine().ToLower());

        switch(option)
        {
            case 'p': MenuPortuguese(); break;
            case 'e': MenuEnglish(); break;
            default: MenuLanguage(); break;
        }
    }
    static void MenuEnglish()
    {
        Console.Clear();
        Console.WriteLine("-----Stopwatch-----\n");
        Console.WriteLine("Options:");
        Console.WriteLine("-------------------");
        Console.WriteLine("1 - Exit\n2 - Change Language");
        Console.WriteLine("...................");
        Console.WriteLine("M = Minutes => 1m = 1 minute");
        Console.WriteLine("S = Seconds => 1s = 1 second");
        Console.WriteLine("-------------------\n");
        Console.Write("How long do you want to count?\n(Example: 10s)\n->");

        string data = Console.ReadLine().ToLower();

        if (data == "1")
        {
            Console.Clear();
            Console.WriteLine("\'Thanks for using the App\'");
            Environment.Exit(0);
        }
        else if (data == "2")
            MenuLanguage();

        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;
        
        if (type == 'm')
            multiplier = 60;

        PreStart("en");
        Start(time * multiplier);

        Console.Clear();
        Console.WriteLine("\'Stopwatch finished\'");
        Thread.Sleep(2500); //2500 milliseconds of sleep
        MenuEnglish();
    }

    static void MenuPortuguese()
    {
        Console.Clear();
        Console.WriteLine("-----Cronômetro-----\n");
        Console.WriteLine("Opções:");
        Console.WriteLine("...................");
        Console.WriteLine("1 - Sair\n2 - Mudar idioma");
        Console.WriteLine("-------------------");
        Console.WriteLine("M = Minutos => 1m = 1 minuto");
        Console.WriteLine("S = Segundos => 1s = 1 segundo");
        Console.WriteLine("-------------------\n");
        Console.Write("Quanto tempo você deseja contar?\n(Exemplo: 10s)?\n->");

        string data = Console.ReadLine().ToLower();

        if (data == "1")
        {
            Console.Clear();
            Console.WriteLine("\'Obrigado por usar o App\'");
            Environment.Exit(0);
        }
        else if (data == "2")
            MenuLanguage();

        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;

        if (type == 'm')
            multiplier = 60;

        PreStart();
        Start(time * multiplier);

        Console.Clear();
        Console.WriteLine("\'Cronômetro Finalizado\'");
        Thread.Sleep(2500); //2500 milliseconds of sleep
        MenuPortuguese();
    }

    static void PreStart(string option = "pt")
    {
        if (option == "en")
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Preparado...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Vamos...");
            Thread.Sleep(2500);
        }
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine($"{currentTime}s");
            Thread.Sleep(1000); //1000 milliseconds of sleep
        }
    }
}
