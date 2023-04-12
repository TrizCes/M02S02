internal class Program
{
  private static void Main(string[] args)
  {
    int num;

    Console.WriteLine("Olá! Vamos analisar o seu numero!");
    Console.Write("Digite o numero:");
    num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
      Console.WriteLine("O numero digitado é par!");
    }
    else
    {
      Console.WriteLine("O numero digitado é impar!");
    }
  }
}
