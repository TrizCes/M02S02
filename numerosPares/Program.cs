internal class Program
{
  static void Main(string[] args)
  {
    int numero = 0;

    while (numero <= 0)
    {
      Console.Write("Digite um numero maior que zero: ");
      numero = int.Parse(Console.ReadLine());
      if (numero <= 0)
      {
        Console.WriteLine("Erro! \n Tente novamente.");
      }
    }

    for (int i = 0; i <= numero; i = i + 2)
    {
      Console.WriteLine(i);
    }
  }
}