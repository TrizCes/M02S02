internal class Program
{
  private static void Main(string[] args)
  {
    double num1 = 0;
    double num2 = 0;
    char operacao;

    Console.WriteLine(" Bem vindo(a) a calculadora! \n");
    Console.WriteLine("Agora escolha uma operação: ");
    Console.WriteLine("  + : soma");
    Console.WriteLine("  - : subtração");
    Console.WriteLine("  * : multiplicação");
    Console.WriteLine("  / : divisão");
    Console.WriteLine(" Para SAIR digite: ?");

    do
    {

      Console.Write("\n Digite a operação escolhida: ");
      operacao = char.Parse(Console.ReadLine());

      if (operacao != '?')
      {
        Console.Write("\nDigite o primeiro numero: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("\nDigite o segundo numero: ");
        num2 = int.Parse(Console.ReadLine());
      }


      if (operacao == '/' && num2 == 0)
      {
        while (num2 == 0)
        {
          Console.Write("O divisor não pode ser zero,\npor favor digite o segundo numero novamente: ");
          num2 = int.Parse(Console.ReadLine());
        }

      }
      switch (operacao)
      {
        case '+':
          Console.WriteLine("Resposta: " + (num1 + num2));
          break;
        case '-':
          Console.WriteLine("Resposta: " + (num1 - num2));
          break;
        case '*':
          Console.WriteLine("Resposta: " + (num1 * num2));
          break;
        case '/':
          Console.WriteLine("Resposta: " + (num1 / num2));
          break;
        case '?':
          Console.WriteLine("Você escolheu SAIR");
          Console.WriteLine("Obrigada por utilizar a calculadora C# da Triz!");
          Console.WriteLine("Tchau!!!\nAté + \n:D");
          break;
        default:
          Console.WriteLine("Opção inválida digite uma opção disponível no menu.");
          Console.WriteLine("Agora escolha uma operação: ");
          Console.WriteLine("  + : soma");
          Console.WriteLine("  - : subtração");
          Console.WriteLine("  * : multiplicação");
          Console.WriteLine("  / : divisão");
          Console.WriteLine(" Para SAIR digite: ?"); break;
      }
    } while (operacao != '?');
  }
}
