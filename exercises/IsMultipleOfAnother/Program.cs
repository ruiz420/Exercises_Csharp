using shared;

var response = String.Empty;

do
{
    try
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
 
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine("Desea Continuar [S/N]?: ");
    response = Console.ReadLine()!.ToUpper();
    while (response != "S" && response != "N")

    {
        Console.WriteLine("Por favor ingrese 'S' para continuar o 'N' para salir.");
        response = Console.ReadLine()!.ToUpper();
    }

} while (response == "S");

Console.WriteLine("Game Over");