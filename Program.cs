// int tabuada = 0;
// int resultado = 0;

// while( tabuada < 21)
// {
//     Console.WriteLine($"2 x {tabuada} = {resultado}");
//     tabuada += 1;
//     resultado = 2 * tabuada;
// }

// int i = 0;

//  Console.WriteLine("Digite um número entre 1 e 10: ");
//     i = int.Parse(Console.ReadLine());

// while(i < 1 || i > 10)
// {
//     Console.WriteLine("Número indisponível, insira novamente:");
//     i = int.Parse(Console.ReadLine());
// }

Console.WriteLine("Digite um numero: ");
bool ehNumero = int.TryParse(Console.ReadLine(), out int num);
while (!ehNumero)
{
    Console.WriteLine("Entrada inválida, Digite um numero: ");
    ehNumero = int.TryParse(Console.ReadLine(), out  num);
}

Console.WriteLine("O número digitado é: " + num);