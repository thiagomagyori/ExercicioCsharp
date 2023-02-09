//arrays estrutura basica

//Lembrando que ele começa sempre em 0 na posição 0


// int[] listaTelefone = new int[4]; //[4] falamos que ele sera de 4 posição
// listaTelefone[2] =32; //aqui falamos que na posição 2 ira ter o valor 32 

// long[] listaTelefone = new long[15] {19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933};

// Console.WriteLine(listaTelefone[0]);
// Console.WriteLine(listaTelefone[1]);
// Console.WriteLine(listaTelefone[2]);
// Console.WriteLine(listaTelefone[3]);


//ultilizando o for para percorrer o arrays 15x
long[] listaTelefone = new long[15] {19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933,19988982933};

for (int itemArray =0; itemArray < listaTelefone.Length; itemArray++)

{
    Console.WriteLine(listaTelefone[itemArray]);
}