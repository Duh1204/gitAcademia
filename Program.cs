/*

int num = 100;
int sobra_cinquenta = num/50;

num = num % 50;
int sobra_dez = num/10;

num = num % 10;
int sobra_cinco = num / 5;

num = num % 5;
int sobra_um = num / 1;

Console.WriteLine("Notas de cinquenta: " + sobra_cinquenta);
Console.WriteLine("Notas de dez: " + sobra_dez);
Console.WriteLine("Notas de cinco: " + sobra_cinco);
Console.WriteLine("Notas de um: " + sobra_um);

*/
/*
9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. 
Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
da entrada e das duas prestações, de acordo com as regras acima. 
Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
conseqüente pagamento dos boletos das duas prestações.

Solução Inicial(1)

int prest1 = Convert.ToInt32(Math.Floor(valor/3));
Console.WriteLine(prest1);
int prest2 = prest1;
double entrada = (((valor / 3) - prest1)*3) + prest1;
Console.WriteLine("Entrada: " + entrada);
Console.WriteLine("Primeira Prestação: " + prest1);
Console.WriteLine("Segunda Prestação: " + prest2);
Console.WriteLine(prest1 + prest2 + entrada);


/*

Solução Mais simples(2)

double valor = 150;
double resto = valor % 3;
double prest1 = (valor - resto) / 3;
double prest2 = prest1;
double entrada = prest1 + resto;
Console.WriteLine(entrada);
Console.WriteLine(prest1);
Console.WriteLine(prest2);


/*
8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
A fórmula da conversão é F=(9*C+160)/5.


int celsius = 38;
int fahrenheit = (9 * celsius + 160) / 5;
Console.WriteLine(fahrenheit);

*/

/*
7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.

Console.WriteLine("Número do vendedor: ");
int num_vendedor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Salário: ");
double salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Total de vendas: ");
int total_vendas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Número do vendedor: " + num_vendedor);
Console.WriteLine("Salário: " + salario);
Console.WriteLine("Total de vendas: " + total_vendas);
*/

/*
6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
de IPI (única) a ser acrescentada. 


Console.WriteLine("Código A: ");
int codigo_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Quantidade A: ");
int quantidade_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Valor A: ");
double valor_A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Código B: ");
int codigo_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Quantidade B: ");
int quantidade_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Valor B: ");
double valor_B = Convert.ToDouble(Console.ReadLine());
double IPI = 5.7;

Console.WriteLine(codigo_A);
Console.WriteLine(quantidade_A);
Console.WriteLine(valor_A);
Console.WriteLine(valor_A + valor_A*(IPI/100));
Console.WriteLine(codigo_B);
Console.WriteLine(quantidade_B);
Console.WriteLine(valor_B);
Console.WriteLine(valor_B + valor_B * (IPI / 100));
*/

/*
5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
consumido para percorrê-la (medido em l).


Console.WriteLine("Digite quantos km seu carro faz por litro: ");
int km_litro = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite quantos km você pretende andar: ");
int distancia = Convert.ToInt32(Console.ReadLine());
int litros = distancia / km_litro;
Console.WriteLine(litros);
*/

/*
4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.


Console.WriteLine("Dia: ");
string dia = Console.ReadLine();
Console.WriteLine("Mês: ");
string mes = Console.ReadLine();
Console.WriteLine("Ano: ");
int ano = Convert.ToInt16(Console.ReadLine());
string ano_string = Convert.ToString(ano);

Console.WriteLine(ano_string + mes + dia);

ano = ano - 2000;
Console.WriteLine(ano + mes + dia);
*/

/*
3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
si os valores de duas variáveis A e B.


string a = "A";
string b = "B";
string c = a;
a = b;
b = c;
Console.WriteLine(a);
Console.WriteLine(b);
*/

/*
2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.


int num1 = 10;
int num2 = 20;
int num3 = 30;
int num4 = 40;
double soma = (num1 + num2 + num3 + num4) / 4;
Console.WriteLine(soma);
*/

/*
 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer. 
 
int num1 = 10;
int num2 = 20;

double soma = (num1 + num2) / 2;
Console.WriteLine(soma);
*/