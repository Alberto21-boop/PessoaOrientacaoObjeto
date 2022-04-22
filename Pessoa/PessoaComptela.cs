using PessoaApp21;


Pessoa pessoa = new Pessoa();

pessoa.GetNome = Console.ReadLine();
pessoa.GetIdade = int.Parse(Console.ReadLine());
pessoa.GetProfissao = Console.ReadLine();



Console.WriteLine($"Nome : {pessoa.Nome()}");
Console.WriteLine($"Idade : {pessoa.Idade()}");
Console.WriteLine($"Emprego : {pessoa.Emprego()}");