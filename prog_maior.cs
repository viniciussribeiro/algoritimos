int v1,v2,v3,v4,maior;
	Console.Write("Digite o 1o valor:");
	v1 = int.Parse(Console.ReadLine());
	Console.Write("Digite o 2o valor:");
	v2 = int.Parse(Console.ReadLine());
	Console.Write("Digite o 3o valor:");
	v3 = int.Parse(Console.ReadLine());
	Console.Write("Digite o 4o valor:");
	v4 = int.Parse(Console.ReadLine());
	if (v1>v2 & v1>v3 & v1>v4)  	{
		maior=v1;
	}
	else if (v2>v1 & v2>v3 & v2>v4)	{
		maior=v2;
	}
	else if(v3>v1 & v3>v2 & v3>v4) 	{
		maior=v3;
	}
	else	{
		maior = v4;
	}
	Console.Write("O maior é: "+maior);
	Console.ReadKey();