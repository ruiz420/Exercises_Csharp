namespace shared
{
    public class ConsoleExtensions
    {
        public static int GetInt(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }

            throw new ArgumentException("el valor ingresado no es un numero entero valido");
        }
    }
}