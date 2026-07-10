using System;

// ====== CAST (conversão explícita) =====

float vida = 10.6f;
int vidaInt = (int)vida;
Console.WriteLine($"Sua Vida é igual a {vidaInt}, você está vivo!"); // trunca vida para 10.

double dano = 23.99;
int danoInt =(int)dano;
Console.WriteLine($"Dano recebido {danoInt}"); //trunca casa decimal
string texto = "abc";
int textoInt = (int)texto;
Console.WriteLine($" {textoInt}"); - //ao tentarmos fazer esta conversao de texto, o terminal exibirá uma frase de erro no build e pedirá para corrijir o problema

// ===== ASCII/UNICODE (char para int) ====== 
char letra = 'a';
int codigo = (int)letra; // esta linha irá converter o char para o numero na sua tabela numérica
Console.WriteLine($"'{letra}'equivale ao código {codigo}"); // 97

string texto = "abc";
foreach (char c in texto) // nesta linha a função FOREACH pede para dividar cada caractere em char, para poder selecionar sua representação númerica.
{
    Console.WriteLine($"'{c}' = {(int)c}"); // aqui, terá três voltas, pelo numero de caractere, cada volta representará uma letra.
}

// ====== CONVERT (arredonda ao invés de truncar) ======

float velocidade = 5.7f;
int velocidadeInt = Convert.ToInt32(velocidade); // arredonda para o número mais próximo
Console.WriteLine($"Sua velocidade é {velocidadeInt}");

