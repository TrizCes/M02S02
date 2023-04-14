internal class Program
{
  private static void Main(string[] args)
  {
    int quantidade;
    double soma = 0.0;
    double media = 0.0;

    Console.WriteLine("\n Bem vindo(a)! Vamos calcular a média dos valores que você desejar. \n");

    do
    {
      Console.Write(" Digite o total de numeros que deseja calcular a média: ");
      quantidade = int.Parse(Console.ReadLine());
      if (quantidade < 2)
      {
        Console.WriteLine($" Não é possivel calcular a média entre {quantidade} item(ns).");
      }
    } while (quantidade < 2);

    int[] valores = new int[quantidade];
    for (int i = 0; i < quantidade; i++)
    {
      Console.Write($" Digite o valor de numero {i + 1}: ");
      valores[i] = int.Parse(Console.ReadLine());
    }

    foreach (int valor in valores)
    {
      soma = soma + valor;
    }

    media = soma / quantidade;

    Console.WriteLine($"\n A média dos valores é: {media}");
  }
}

