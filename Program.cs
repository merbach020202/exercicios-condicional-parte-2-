Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Digite seu nome: ");
Console.ResetColor();
string nome = Console.ReadLine();

while (nome.Length <= 2)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Digite novamente seu nome: ");
    Console.ResetColor();
    nome = Console.ReadLine();
}



Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Digite sua idade: ");
Console.ResetColor();
int idade = int.Parse(Console.ReadLine());

while (idade > 100 || idade == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Digite novamente sua idade: ");
    Console.ResetColor();
    idade = int.Parse(Console.ReadLine());
}



Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"Digite seu salario:R$ ");
Console.ResetColor();
float salario = float.Parse(Console.ReadLine());

while (salario == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"Digite novamente seu salario:R$ ");
    Console.ResetColor();
    salario = float.Parse(Console.ReadLine());
}



Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Qual o seu estado civil?");
Console.ResetColor();

Console.WriteLine($"Digite a letra conforme a sua situação:");

Console.WriteLine($"s = solteiro");
Console.WriteLine($"c = casado");
Console.WriteLine($"v = viuvo");
Console.WriteLine($"d = divorciado");
char estadoCivil =  char.Parse(Console.ReadLine().ToLower());

while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd')
{
    Console.WriteLine($"Digite novamente seu estado civil: ");
    estadoCivil = char.Parse(Console.ReadLine());
}










