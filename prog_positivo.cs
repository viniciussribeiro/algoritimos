int valor;
Console.Write("Digite um valor:");
valor = int.Parse(Console.ReadLine());
if (valor>=0)   {
	    Console.Write("É positivo!");
}
else    {
	Console.Write("É negativo!");
}
Console.ReadKey();