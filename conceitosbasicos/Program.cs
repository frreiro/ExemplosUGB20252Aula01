// See https://aka.ms/new-console-template for more information

// Validar idade

/* int idade = 24;
Console.WriteLine("A idade é " + idade);

if (idade >= 18)
    Console.WriteLine("Você pode tirar habilitação");
else
    Console.WriteLine("Você não pode tirar habilitação");
*/


// Obter entradas
/*
Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informe seu salário: ");
decimal salario = decimal.Parse(Console.ReadLine());

Console.WriteLine("Seu nome é " + nome + " e seu salario é " + salario);
*/

// Calcular IRRF


Console.WriteLine("Informe seu salário: ");
double salario = double.Parse(Console.ReadLine());

string mensagemPrefixo = "Seu valor a recolher é: ";
double valorARecolher = 0;

if (salario <= 2428.80)
{
    Console.WriteLine(mensagemPrefixo + valorARecolher);
}
else if (salario >= 2428.81 && salario <= 2826.65)
{
    valorARecolher = (salario * 0.075) - 182.16;
    Console.WriteLine(mensagemPrefixo + valorARecolher);
}
else if (salario >= 2826.66 && salario <= 3751.05)
{
    valorARecolher = (salario * 0.15) - 384.16;
    Console.WriteLine(mensagemPrefixo + valorARecolher);
}
else if (salario >= 3751.06 && salario <= 4664.68)
{
    valorARecolher = (salario * 0.225) - 384.16;
    Console.WriteLine(mensagemPrefixo + valorARecolher);
}
else
{
    valorARecolher = (salario * 0.275) - 908.73;
    Console.WriteLine(mensagemPrefixo + valorARecolher);
}
