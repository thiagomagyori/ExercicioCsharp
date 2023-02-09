// Estrutura com switch quando queremos testar varias condições

// int numeroEntrada = 2; // aqui é o usuario que vai entrar com o valor
// string numeroCapiturado = " ";


// switch (numeroEntrada) //aqui ele faz a seleção
// {
//     case 1:
//     numeroCapiturado = "Mês janeiro";
//     break;

//           case 2:
//           numeroCapiturado = "Mês fefereiro";
//           break;
    
//     case 3:
//     numeroCapiturado = "Mês março";
//     break;

//         case 4:
//         numeroCapiturado = "Mês abril";
//         break;

//     case 5:
//     numeroCapiturado = "Mês maio";
//     break;

// //IMPORTANTE DEFAULT ELE VAI FILTRA TUDO NUMERO QUE NÃO FOR VALIDO
//     default:
//     numeroCapiturado = "Numero invalido";
//     break;
// }

// Console.WriteLine(numeroCapiturado);


int valorA = 50;
int valorB = 20;

string operacao = "*"; //valor escolhido pelo usuario

switch (operacao) //aqui ele faz a seleção
{
    case "+":
    Console.WriteLine( valorA + valorB );
    break;

    case "*":
    Console.WriteLine( valorA * valorB );
    break;

    case "-":
    Console.WriteLine( valorA - valorB );
    break;

    default:
     Console.WriteLine("Valor invalido");
     break;
}

