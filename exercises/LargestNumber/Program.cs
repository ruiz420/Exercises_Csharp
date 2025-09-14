using shared;

var response = String.Empty;
do
{
    try
    {
        var number1 = ConsoleExtensions.GetInt("ingrese primer numero: ");
        var number2 = ConsoleExtensions.GetInt("ingrese segundo numero: ");
        var number3 = ConsoleExtensions.GetInt("ingrese tercer numero: ");

        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine($"el numero mayor es: {number1}");
        }
        else if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine($"el numero mayor es: {number2}");
        }
        else if (number3 > number1 && number3 > number2)
        {
            Console.WriteLine($"el numero mayor es: {number3}");
        }
        else
        {
            Console.WriteLine("hay numeros iguales o no se puedo determinar un unico mayor");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine("Desea Continuar [S/N]? ");
    response = Console.ReadLine()!.ToUpper();

} while (response == "S");