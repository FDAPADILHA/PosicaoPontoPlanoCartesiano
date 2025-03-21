double x, y;

string[] vet;

vet = Console.ReadLine().Split(' ');

x = double.Parse(vet[0]);
y = double.Parse(vet[1]);

//ORIGEM
if (x == 0.0 && y == 0.0)
{
    Console.WriteLine("Origem");
}
//EIXO Y
else if (x == 0.0 && y > 0.0 || x == 0.0 && y < 0.0)
{
    Console.WriteLine("Eixo Y");
}
//EIXO X
else if (y == 0.0 && x > 0.0 || y == 0.0 && x < 0.0)
{
    Console.WriteLine("Eixo X");
}
//Q1
else if (x >= 0.1 && y >= 0.1)
{
    Console.WriteLine("Q1");
}
//Q2
else if (x <= -0.1 && y >= 0.1)
{
    Console.WriteLine("Q2");
}
//Q3
else if (x <= -0.1 && y <= -0.1)
{
    Console.WriteLine("Q3");
}
//Q4
else if (x >= 0.1 && y <= -0.1)
{
    Console.WriteLine("Q4");
}
//FIM
else
{
    Console.WriteLine("Fora do Plano");
}