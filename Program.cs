namespace SewHü
{
    internal class Program
    {
      
            static void Main()
            {
                Console.Write("Bitte geben Sie eine ganze positive Zahl ein: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number) && number > 1)
                {
                    if (IsPrime(number))
                    {
                        Console.WriteLine($"{number} ist eine Primzahl.");
                    }
                    else
                    {
                        Console.WriteLine($"{number} ist keine Primzahl.");
                    }
                }
                else
                {
                    Console.WriteLine("Bitte geben Sie eine ganze positive Zahl größer als 1 ein.");
                }
            }

            static bool IsPrime(int n)
            {
                if (n == 2 || n == 3)
                {
                    return true;
                }

                if (n % 2 == 0 || n == 1)
                {
                    return false;
                }

                int sqrt = (int)Math.Sqrt(n);

                for (int i = 3; i <= sqrt; i += 2)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

    }

