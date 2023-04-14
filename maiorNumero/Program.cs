internal class Program
{
  private static void Main(string[] args)
  {
    int[] numeros = new int[5];

    for (int i = 0; i < 5; i++)
    {
      Console.Write("Digite um numero:");
      numeros[i] = int.Parse(Console.ReadLine());
    }

    Array.Sort(numeros);
    Console.WriteLine($"O maior numero digitado é {numeros[numeros.Length - 1]}");
  }
}
