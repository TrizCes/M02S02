namespace MyProject;
class Program
{
  static void Main(string[] args)
  {
    int num1, num2, result;

    Console.WriteLine("Olá! Vamos somar numeros!");
    Console.Write("Digite o primeiro numero:");
    num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo numero:");
    num2 = int.Parse(Console.ReadLine());

    result = num1 + num2;

    Console.WriteLine("Resolução:");
    Console.Write(num1 + " + " + num2 + " = " + result);
  }
}