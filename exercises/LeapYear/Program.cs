using shared;

int counter = 0;  // se crea contador con el fin de que en cada 5 comandos pregunte si desea continuar
string response = "S";  
do
{
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    var Year = ConsoleExtensions.GetInt("ingrese Año ");

    if (Year == currentYear)
    {
        message = "";
    }
    else if (Year > currentYear)
    {
        message = "va a ser";
    }
    else
    {
        message = "fue";
    }

    if (Year % 4 == 0)
    {
        if (Year % 100 == 0)
        {
            if (Year % 400 == 0)
            {
                Console.WriteLine($"EL Año: {Year}, Si {message} es biciesto");
            }
            else
            {
                Console.WriteLine($"el año: {Year} No {message} es biciesto ");
            }

        }
        else
        {
            Console.WriteLine($"el año: {Year}, Si {message} es biciesto");
        }
    }
    else
    {
        Console.WriteLine($"El año: {Year}, No {message} biciesto ");

    }
    counter++;
    if (counter % 5 == 0)
    {
        Console.WriteLine("¿Desea continuar? [S/N]");
        response = Console.ReadLine()!.ToUpper();
    }
    else
    {
        response = "S";
    }

} while (response == "S");