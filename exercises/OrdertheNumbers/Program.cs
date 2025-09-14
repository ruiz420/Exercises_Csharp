using shared;

var response = String.Empty;

do
{
    Console.WriteLine("ingrese 3 numeros diferentes"); 

    var a = ConsoleExtensions.GetInt("ingrese primer numero: ");
    var b = ConsoleExtensions.GetInt("ingrese segundo numero: ");
    if (a == b)
    {
        Console.WriteLine("lo numeros deben de ser diferentes, vuelva a empezar...");
        continue; 
    }
    var c = ConsoleExtensions.GetInt("ingrese tercer numero: ");
    if (b==c || c==a)

    { 
        Console.WriteLine("lo numeros deben de ser diferentes, vuelva a empezar...");
        continue;
    }

    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"El numero mayor es {a}, el medio es {b}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El numero mayor es {a}, el medio es {c}, el menor es {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El numero mayor es {b}, el medio es {a}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El numero mayor es {b}, el medio es {c}, el menor es {a}");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"El numero mayor es {c}, el medio es {a}, el menor es {b}");
        }
        else
        {
            Console.WriteLine($"El numero mayor es {c}, el medio es {b}, el menor es {a}");
        }
    }

    Console.WriteLine("Desea Continuar [S/N]? ");
    response = Console.ReadLine()!.ToUpper();

} while (response == "S"); 
