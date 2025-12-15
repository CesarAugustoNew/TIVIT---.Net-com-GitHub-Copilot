using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using TIVIT___.Net_com_GitHub_Copilot.Models;


string fala = "Ola, seja bem vindo";
int quantidade = 1;
double altura = 1.82;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(fala);
Console.WriteLine("Valor da variavel quantidade: " + quantidade);
Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variavel preco: " + preco);
Console.WriteLine("Valor da variavel condicao: " + condicao);


Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Cesar";
pessoa1.Idade = 22;
pessoa1.Endereco = "São Paulo";
pessoa1.Apresentar();  

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}

bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsalvel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsalvel)
{
    Console.WriteLine("Entrada liberada!");
}
else
{
    Console.WriteLine("Entrada não liverada");
}

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado");
}

bool choveu = true;
bool estaTarde = true;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar um outro dia");
}

Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(30, 100);
calc.Multiplicar(10, 50);
calc.Dividir(4, 20);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);

int numero = 10;

Console.WriteLine(numero);

Console.WriteLine("Incrementando o 10");
numero = numero + 1;
numero++;

int numeroDecremento = 20;
Console.WriteLine("Decrementando o 20");
numeroDecremento--;

Console.WriteLine(numeroDecremento);

int number = 5;

for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{number} x {contador} = {number * contador}");
}

int numeroWhile = 5;
int contadorWhile = 0;

while (contadorWhile <= 10)
{
    Console.WriteLine($"{contadorWhile} Execução: {numeroWhile} x {contadorWhile} = {numeroWhile * contadorWhile}");
    contadorWhile++;

    if (contadorWhile == 6)
    {
        break;
    }
}

int total = 0, Numbers = 0;

do
{
    Console.WriteLine($"Digite um numeor (0 para parar)");
    Numbers = Convert.ToInt32(Console.ReadLine());

    total += Numbers;
} while(Numbers != 0);

Console.WriteLine($"Total da soma dos numeros digitados é {total}");

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{   
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar clientes");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadasteo de cliente");
            break;
        
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        
        case "3":
            Console.WriteLine("Apaga de cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção invalida");
            break;
    }       
}




















