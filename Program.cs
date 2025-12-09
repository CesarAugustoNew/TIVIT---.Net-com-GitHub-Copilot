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