double aulas, valor, desconto, salario;
		Console.Write("Digite a qtd. aulas dadas: ");
		aulas = double.Parse(Console.ReadLine());
		Console.Write("Digite o valor da hora aula: ");
		valor = double.Parse(Console.ReadLine());
		Console.Write("Digite o percentual do desconto: ");
		desconto = double.Parse(Console.ReadLine());
		salario= aulas*valor*(1-desconto/100);
		Console.Write("Seu salário descontado é: "+salario);
        Console.ReadKey();