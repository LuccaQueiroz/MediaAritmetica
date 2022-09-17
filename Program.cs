Console.WriteLine("Média Aritmética de 3 números");

Console.WriteLine("Digite o primeiro número: ");
double numero1 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Digite o primeiro número: ");
double numero2 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Digite o primeiro número: ");
double numero3 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine(numero1);
Console.WriteLine(numero2);
Console.WriteLine(numero3);

double media = (numero1 + numero2 + numero3) / 3;

Console.WriteLine($"Média: {media:N1}");