internal class Program
{
  private static void Main(string[] args)
  {
    string marca;
    string modelo;
    int kmRodados;

    Console.WriteLine("Olá! Bem vindo(a) a central de informações de veículos!");
    Console.Write("Digite a marca do seu veículo:");
    marca = Console.ReadLine();
    Console.Write("Digite o modelo do seu veículo:");
    modelo = Console.ReadLine();
    Console.Write("Informe quantos Km o veículo rodou:");
    kmRodados = int.Parse(Console.ReadLine());

    Console.WriteLine($"Veículo {modelo}, da marca {marca}, com a quilometragem atual de {kmRodados}km. ");

    if (kmRodados > 10000)
    {
      Console.WriteLine("Sua quilometragem ultrapassou o limite, é necessário realizar a revisão do veículo.");
    }
  }

}
