Console.WriteLine("Digite o valor em R$: ");

double valor = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Dolar: " + valor * 5.17);
Console.WriteLine("Euro: " + valor * 6.14);
Console.WriteLine("Peso Argentino: " + valor * 0.05);

// 1. Dólar (1 dólar = 5,17 reais)
// 2. Euro (1 euro = 6,14 reais)
// 3. Peso argentino (1 peso argentino = 0,05 reais)
