using ExemploFundamentos.Models;

//Pessoa
Console.WriteLine("------PESSOA-----");
Pessoa pessoa = new Pessoa();
pessoa.Nome = "Michelle";
pessoa.Idade = 39;
pessoa.Apresentar();

//Calculadora
Console.WriteLine("-----CALCULADORA-------");
Calculadora calc = new Calculadora();
calc.Somar(10,2);
calc.Subtrair(10,5);
calc.Multiplicar(5,5);
calc.Dividir(20,2);
calc.Potencia(3,3);
calc.Seno(5);
calc.Tangente(10);
calc.Coseno(3);
calc.Incremento(2);
calc.RaizQuadrada(9);

//Estrutura de Repetições
Console.WriteLine("------FOR-------");
Repeticoes execFor = new Repeticoes();
execFor.ExecutarFor();

Console.WriteLine("------WHILE-------");
Repeticoes execWhile = new Repeticoes();
execWhile.ExecutarWhile();

Console.WriteLine("------DO WHILE-------");
Repeticoes executarDoWhile = new Repeticoes();
executarDoWhile.ExecutarDoWhile();

Console.WriteLine("------Menu-------");
Repeticoes menu = new Repeticoes();
menu.Menu();
