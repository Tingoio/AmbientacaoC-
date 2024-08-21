// 1. Criar um vetor de valores inteiros
int tamanho = 15;
int[] vet = new int[tamanho];

Random rand = new Random();
// 2. Percorrer o vetor com um laço 
for(int i = 0; i < vet.Length; i++)
{
// 3. Descobrir como gerar um valor aleatório
    vet[i] = rand.Next(1000);
    Console.Write(vet[i] + "|");
}

Console.WriteLine("\n");

Array.Sort(vet);

for(int i = 0; i < vet.Length; i++){
    Console.Write(vet[i] + "|");
}''