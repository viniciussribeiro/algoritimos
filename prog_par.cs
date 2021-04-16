int valor, x;
	Console.Write("Digite um valor:");
	valor = int.Parse(Console.ReadLine());
	x = valor % 2;
	if (x==0)   {
		Console.Write("É par!");
	}
	else    {
		Console.Write("É ímpar!");
		}
    Console.ReadKey();