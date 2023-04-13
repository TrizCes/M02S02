internal class Program
{
  private static void Main(string[] args)
  {
    string nome;
    int idade = 0;

    Console.WriteLine("Bem vinda(o) ao hospital C#");
    Console.Write("Me infome o nome do paciente:");
    nome = Console.ReadLine();
    Console.Write("Agora me informe a idade do paciente:");
    idade = int.Parse(Console.ReadLine());

    Console.WriteLine("O paciente " + nome + " tem " + idade + " anos.");

    if (idade < 18)
    {
      Console.WriteLine(nome + " é menor de idade. Precisa de acompanhante.");
    }
    else if (idade >= 18 && idade < 65)
    {
      Console.WriteLine(nome + " é maior de idade.");
    }
    else
    {
      Console.WriteLine(nome + " é idoso. Precisa de acompanhante.");
    }
  }
}