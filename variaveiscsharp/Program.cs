

 
// Console.Write("Olá\nMundo"); faz pular linha como temos outros diversos \t \" \" aspas dentro de aspas


//variáveis em C# declarações e modo e usalas

//sem valor iniciado 
int variavelDoTipoInteiro;
float variavelDoTipoFloat;
bool variavelDoTipoBoleano;
decimal variavelDoTipoDecimal; 

//nota que pode ter mais tipo mais esses ai em cima são os mais ultilizados


// já iniciada com algum valor
int idade = 31;
float altura = 1.65f;
bool trabalhando = false;
decimal peso = 52.700m;

//exibindo na tela os valores atributo mais valor da variavel
Console.WriteLine("Idade:" + idade);
Console.WriteLine("Altura:" + altura);
Console.WriteLine("Trabalhando:" + trabalhando);
Console.WriteLine( "Peso:" + peso);

// fazendo o mesmo codigo a cima mais exibindo de uma forma diferente
int anoCarro = 2006;
float cilindradas = 1.6f;
bool usado = true;
decimal quilometragem = 2.956m;

//interpolação
Console.WriteLine($"Ano: {anoCarro} Modelo 2007");
Console.WriteLine($"Cilindrada: {cilindradas} Flex");
Console.WriteLine($"Usado: {usado} Com Revisão");
Console.WriteLine($"Quilómetros {quilometragem} Km Rodados");

// Temos as variaveis do tipo constante que seu valor não pode ser mudado

string nome = "Thiago";
const long cpf = 26634424636; //esse numero de cpf eu não consigo motificar ele no codigo 

//outra regra importante é declaração de variaveis var 
// variavel do tipo implícita

var meuNome = "Thiago silva"; //inicio a variavel com um nome ai ela passa ser string 

meuNome = "Luis"; // nesse ponto eu motifico seu conteudo mais eu só posso motificar por string não posso motificar por ex por um numero por que ela já foi inicializada como string

Console.WriteLine(meuNome);


