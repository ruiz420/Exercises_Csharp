using shared;

var response = String.Empty;

do
{
    var a = ConsoleExtensions.GetInt("ingrese primer numero: ");
    var b = ConsoleExtensions.GetInt("ingrese segundo numero: ");
    if (a % b == 0)
    {
        Console.WriteLine($"{a} es multiplo de {b}  ");
    }
    else
    { 
        Console.WriteLine($"{a} No es multiplo de {b}");
    }
        Console.WriteLine("Desea Continuar [S/N]? ");
    response = Console.ReadLine()!.ToUpper();

} while (response == "S") ;