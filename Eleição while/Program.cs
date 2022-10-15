?using System;


Console.WriteLine("Eleições 2022");

int qtdc26 = 0;
int qtdc44 = 0;
int qtdc56 = 0;
int qtdcnulo = 0;
bool continuar = true;

while (continuar)
{
    Console.WriteLine("Qual seu nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("Digite o número do seu candidato");
    Console.WriteLine("");

    Console.WriteLine("26 | 44 | 56 | 0");
    int numero = Convert.ToInt32(Console.ReadLine());
    
    if (numero == 26) { qtdc26 = qtdc26 + 1; }
    else if (numero == 44) { qtdc44 = qtdc44 + 1; }
    else if (numero == 56) { qtdc56 = qtdc56 + 1; }
    else qtdcnulo = qtdcnulo + 1;

    Console.WriteLine("Quer continuar");
    Console.WriteLine("");

    Console.WriteLine("Sim | não");
    string resposta = Console.ReadLine();

    if (resposta == "sim") { continuar = true; } else { continuar = false; }
    
    Console.Clear();

}
//proxima linha



antony.txt
Exibindo antony.txt.
