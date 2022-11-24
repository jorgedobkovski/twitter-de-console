// See https://aka.ms/new-console-template for more information
using atividade.Models;

Console.WriteLine("Aluno: Jorge Luiz Dourado Dobkovski (SI)");
Console.WriteLine("Iniciando aplicação . . .");

Usuario admin1 = new Admin("Manoel Gomes", "canetaazulofc", "ocanetaazul@gmail.com");
Usuario cli1 = new Cliente("Naruto da Silva Joestar", "narutopvh", "joestarna@gmail.com");
Usuario cli2 = new Cliente("Lucas Gonçalves", "proflucas", "lucasprof@gmail.com");

var thread1 = admin1.CriarThread("Diretor de Elden Ring revela interesse em fazer mais jogos.");
Console.WriteLine(thread1.Conteudo);
var thread2 = cli1.CriarThread("digite \"eu quero...\" e deixe seu corretor completar");
Console.WriteLine(thread2.Conteudo);
var thread3 = cli2.CriarThread("De 24 até o dia 28 de Novembro vai ter EXP em dobro no Overwatch 2.");
Console.WriteLine(thread3.Conteudo);
cli1.EditarThread("Diretor de God of War: Ragnarok revela interesse em fazer mais jogos.", thread3);
Console.WriteLine(thread1.Conteudo);
cli1.EditarThread("Diretor de God of War: Ragnarok revela interesse em fazer mais jogos.", thread2);
Console.WriteLine(thread2.Conteudo);
cli1.ExcluirThread(thread3);
((Admin)admin1).FornecerAcesso(cli2);
cli2.ExcluirThread(thread1);
cli2.ResponderThread("eu quero um abraço", thread2);
Console.WriteLine(thread2.Respostas[0]);

Console.ReadLine();

