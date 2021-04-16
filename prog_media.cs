double not1, not2, not3, not4, media;
string nome;
	Console.Write("Digite o nome do aluno: ");
	nome = Console.ReadLine();
	Console.Write("Digite a primeira nota: ");
	not1 = double.Parse(Console.ReadLine());
	Console.Write("Digite a segunda nota: ");
	not2 = double.Parse(Console.ReadLine());
	Console.Write("Digite a terceira nota: ");
	not3 = double.Parse(Console.ReadLine());
	Console.Write("Digite a quarta nota: ");
	not4 = double.Parse(Console.ReadLine());
	media = not1 + not2 + not3 + not4/4;
	if (media>=7)	{
		Console.Write("Parabéns! Aprovado.");
	}
	else	{
		Console.Write("Estude mais! Reprovado");
	}
    Console.ReadKey();