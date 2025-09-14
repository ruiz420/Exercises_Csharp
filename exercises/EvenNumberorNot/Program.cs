using shared;

var response = String.Empty;
do
{
    try
    {
        var number = ConsoleExtensions.GetInt("ingrese numero entero: ");
        if (number % 2 == 0)
        {
            Console.WriteLine($"el numero: {number} es par");
        }
        else
        {
            Console.WriteLine($"el numero: {number} es impar: ");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine("Desea Continuar [S/N]? ");
    response = Console.ReadLine()!.ToUpper();

} while (response == "S");