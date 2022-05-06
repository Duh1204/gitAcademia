/*

15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

Console.WriteLine("Digite a área a ser pintada em metros quadrados ");
int mq = Convert.ToInt16(Console.ReadLine());
double litros = mq / 3;
double latas = litros / 18;
Console.WriteLine(litros + " litros");
Console.WriteLine(latas + " latas");


14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
do arquivo usando este link (em minutos).

Console.WriteLine("Digite o tamanho do arquivo que você deseja baixar em MB: ");
double mb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a velocidade de sua internet em MB por segundo: ");
double mbps = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Levará " + (mb / mbps) / 60 + " minuto(s)");

13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7 * h) - 58
Para mulheres: (62.1 * h) - 44.7

Console.WriteLine("Digite seu sexo(M/F): ");
string sexo = Console.ReadLine();
Console.WriteLine("Digite sua altura: ");
double altura = Convert.ToDouble(Console.ReadLine());
if (sexo == "M")
{
    double peso = (72.7 * altura) - 58;
    Console.WriteLine("Peso ideal: " + peso);
}
else
{
    double peso = (62.1 * altura) - 44.7;
    Console.WriteLine("Peso ideal: " + peso);
}

12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
No final do processamento, exibir o salário total e o salário excedente do operário.



Console.WriteLine("Digite o número de horas totais trabalhadas: ");
int numeroHoras = Convert.ToInt32(Console.ReadLine());
if ((numeroHoras - 50) > 0)
{
    int extra = numeroHoras - 50;
    Console.WriteLine("Seu salário será: " + (50 * 10 + extra * 20));
}
else
{
    Console.WriteLine("Seu salário será: " + (numeroHoras * 10));
}

11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
O programa deve exibir se a hora digitada está ou não válida. 
Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

Console.WriteLine("Digite que hora é agora: ");
int hora = Convert.ToInt32(Console.ReadLine());
if (hora>=0 && hora<=23)
{
    Console.WriteLine("Digite os minutos agora: ");
    int minutos = Convert.ToInt32(Console.ReadLine());
    if (minutos>=0 && minutos <= 60)
    {
        Console.WriteLine("Data válida");
    }
    else
    {
        Console.WriteLine("Data inválida");
    }
}
else
{
    Console.WriteLine("Data inválida");
}

10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
O programa deve mostrar os dados do atleta mais novo e mais alto.

Console.WriteLine("Digite o nome do atleta 1: ");
string nome1 = Console.ReadLine();
Console.WriteLine("Digite a idade do atleta 1: ");
int idade1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Digite a altura do atleta 1: ");
double altura1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o nome do atleta 2: ");
string nome2 = Console.ReadLine();
Console.WriteLine("Digite a idade do atleta 2: ");
int idade2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Digite a altura do atleta 2: ");
double altura2 = Convert.ToDouble(Console.ReadLine());

if (idade1<idade2 && altura1 > altura2)
{
    Console.WriteLine("Atleta 1 mais novo e mais alto");
}
else if(idade2<idade1 && altura2 > altura1)
{
    Console.WriteLine("Atleta 2 mais novo e mais alto");
}

9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
150, avisá-lo que será necessário adicionar 2 unidades de insulina.

Console.WriteLine("Por favor informe os 3 valores de glicemia medido aos 3 dias: ");
Console.WriteLine("Informe o primeiro dia: ");
int dia1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Informe o segundo dia: ");
int dia2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Informe o terceiro dia: ");
int dia3 = Convert.ToInt16(Console.ReadLine());

if (dia1<65 || dia2<65 || dia3 < 65)
{
    Console.WriteLine("Risco de hipoglicemia");
}
if (dia1 > 250 || dia2 > 250 || dia3 > 250)
{
    Console.WriteLine("Risco de hiperglicemia");
}

int media = (dia1 + dia2 + dia3)/3;
if (media < 80)
{
    Console.WriteLine("Necessário diminuir 2 unidades de insulina");
}
if (media > 150)
{
    Console.WriteLine("Necessário acrescentar 2 unidades de insulina");
}

8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
total de vendas. 



Console.WriteLine("Escreva seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Escreva seu salário base: ");
double salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escreva o total de vendas em R$: ");
double vendas = Convert.ToDouble(Console.ReadLine());

if (vendas > 5000)
{
    Console.WriteLine("Seu salário será " + (salario + (vendas * 0.1)));
}
else if (vendas > 1000)
{
    Console.WriteLine("Seu salário será " + (salario + (vendas * 0.07)));
}
else if (vendas > 500)
{
    Console.WriteLine("Seu salário será " + (salario + (vendas * 0.05)));
}

7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

Console.WriteLine("Digite uma frase: ");
string[] frase = Console.ReadLine().Split(' ');
Console.WriteLine("Digite uma palavra de pesquisa: ");
string palavra = Console.ReadLine();
bool has_word = frase.Contains(palavra);
if (has_word){
    Console.WriteLine("A palavra encontra-se na frase");
}
else
{
    Console.WriteLine("A palavra não se encontra na frase");
}


6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
O cálculo do imc = peso / (altura * altura)

IMC 
menor que 18                -> baixo peso
maior que 18 e menor que 25 -> peso normal
maior que 25 e menor que 30 -> sobrepeso
maior que 30 e menor que 35 -> obesidade
maior que 35                -> obesidade grau sério

Console.WriteLine("Nome:");
string nome = Console.ReadLine().ToUpper();
Console.WriteLine("Altura(metros):");
double altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Peso(Kg):");
double peso = Convert.ToDouble(Console.ReadLine());
double imc = peso / (altura * altura);

if (imc < 18)
{
    Console.WriteLine("Baixo peso");
}

if (imc > 18 && imc < 25)
{
    Console.WriteLine("Peso normal");
}

if (imc > 25 && imc < 30)
{
    Console.WriteLine("Sobrepeso");
}

if (imc > 30 && imc < 35)
{
    Console.WriteLine("Obesidade");
}

if (imc > 35)
{
    Console.WriteLine("Obesidade grau sério");
}
*/