namespace Arquivos

{
    
    class Program
    {
      static void Main(string[] ars)
      {
        //caminho do arquivo
        string caminhodoarquivo = "docTexto.txt";

        //ultilizado para escrever data em aquivos
        var stream = new StreamWriter(caminhodoarquivo);

        //escreve uma linha no arquivo
        stream.Write("Texto salvo com sucesso!");

        //fecha o objeto atual e o fluxo adjacente
        stream.Close();

        //o using finaliza a instrução no final do bloco de execução
        //streamreader para ler um arquivo

using (var reader = new StreamReader(caminhodoarquivo))
{
  //lê a linha e retorna a string
Console.WriteLine(reader.ReadLine());
}
      }
    }
}