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
bool troca = false;
do{
    // 4. Ordenar o vetor usando o Bubble Sort
    troca = false;
    for(int i = 0; i < vet.Length - 1; i++)
    {
        if(vet[i]>vet[i+1])
        {
            troca = true;
            int aux = vet[i];
            vet[i] = vet[i+1];
            vet[i+1] = aux;
        }
    }
}while(troca == true);

for(int i = 0; i < vet.Length; i++){
    Console.Write(vet[i] + "|");
}