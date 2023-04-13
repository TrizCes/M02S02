namespace OdenandoNumeros
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] numeros = new int[4];

      for (int i = 0; i < 4; i++)
      {
        Console.Write("Digite um numero:");
        numeros[i] = int.Parse(Console.ReadLine());
      }

      Array.Sort(numeros);
      Console.WriteLine("Os numeros que você digitou em ordem crescente são:");

      for (int i = 0; i < numeros.Length; i++)
      {
        Console.WriteLine($"{numeros[i]}");
      }
    }
  }
}

