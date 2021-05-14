//1.Programa Par;
int p;
Console.WriteLine("Os números pares são: ");
for (p=11; p<=250; p++)  {
    if (p%2==0) {
        Console.WriteLine("{0}", p);
    }
   }
//Fim do programa;

//2.Programa Ímpar Descrescente;
int n1, n2; //Feito no Visual Studio;
			do
			{
				Console.Write("Digite o primeiro número(Para sair digite 0): ");
				n1 = int.Parse(Console.ReadLine());
				Console.Write("Digite o segundo número(Para sair digite 0): ");
				n2 = int.Parse(Console.ReadLine());
				if (n1 % 2 != 0 && n2 % 2 != 0 && n1 > n2)
				{
					Console.WriteLine("Os dois números ímpares: " + "{0}" + " e " + "{1}", n1, n2);
				}
				else if (n1 % 2 != 0 && n2 % 2 != 0 && n1 < n2)
				{
					Console.WriteLine("Os dois números ímpares: " + "{0}" + " e " + "{1}", n2, n1);
				}
				else if (n1 % 2 == 0 && n2 % 2 != 0)
				{
					Console.WriteLine("O número ímpar é: {0}", n2);
				}
				else if (n1 % 2 != 0 && n2 % 2 == 0)
				{
					Console.WriteLine("O número ímpar é: {0}", n1);
				}
				else
				{
					Console.WriteLine("Os dois números são pares.");
		  	}
			} while (n1 != 0 || n2 != 0);
			Console.Write("Fim do programa!");
//Fim do programa;

//3. Programa Tabuada;
int tab, x;
Console.Write("Escolha uma tabuada: ");
tab = int.Parse(Console.ReadLine());
for (x=1; x<=10; x++) {
	Console.WriteLine(tab+"x"+x+"= "+(tab * x));
}
//Fim do programa;

//4.Programa números ímpares;
int n1, n2; //Feito no Visual Studio;
			do
			{
				Console.Write("Digite o primeiro número(Para sair digite 0): ");
				n1 = int.Parse(Console.ReadLine());
				Console.Write("Digite o segundo número(Para sair digite 0): ");
				n2 = int.Parse(Console.ReadLine());
				if (n1 % 2 != 0 && n2 % 2 != 0)
				{
					Console.WriteLine("Os dois números ímpares: " + "{0}" + " e " + "{1}", n1, n2);
				}
				else if (n1 % 2 == 0 && n2 % 2 != 0)
				{
					Console.WriteLine("O número ímpar é: {0}", n2);
				}
				else if (n1 % 2 != 0 && n2 % 2 == 0)
				{
					Console.WriteLine("O número ímpar é: {0}", n1);
				}
				else
				{
					Console.WriteLine("Os dois números são pares.");
				}
			} while (n1 != 0 || n2 != 0);
			Console.Write("Fim do programa!");
//Fim do Programa;

//5.Programa Maior;
int n, x, maior=0;
for (x=1; x<=15; x++) {
	Console.WriteLine("Digite 0 para sair.");
	Console.Write("Digite o valor {0}: ", x);
	n= int.Parse(Console.ReadLine());
	if (n>maior || maior==0) {
		maior=n;
}
}
Console.Write("O maior número digitado foi: "+maior);
//Fim do Programa;

//6.Programa Média;
int x, not=1, soma=0, media;	
	for (x=1; x<=10; x++)	{
    	if (not>=0 && not <=10) {
			Console.WriteLine("Digite a nota {0}: ", x);
			not= int.Parse(Console.ReadLine());
			soma = soma + not;
    } else {
        Console.WriteLine("Valor inválido, favor repetir o processo com notas válidas!");
  }
}   
media= soma/10;
Console.Write("A média das notas é: "+media);
//Fim do programa;

//7. Programa Múltiplo de 100;
int num;
for (num=1; num<=100; num++) {
   Console.WriteLine("{0}", num);
   if (num % 10 == 0)	{
   		Console.WriteLine(num+"  MÚLTIPLO DE 10");
    }
}
//Fim do programa;

//8.Programa Fatorial;
int num, fator=1, x;
Console.WriteLine("Digite o número fatorial: ");
num = int.Parse(Console.ReadLine());
if(num<0)  {
	Console.WriteLine("Não é possível calcular um fatorial de um número negativo!");
} else if (num <=1) {
	Console.WriteLine("{0}!= {1}", num, fator);
} else {
	for (x=num; x>=2; x--) {
		fator= fator*x;
	}
	Console.WriteLine("{0}!= {1}", num, fator);
}
//Fim do programa;

//9.Programa Número;
int num, pares=0, impares=0, negativos=0, positivos=0;
do {
	Console.WriteLine("Digite um número: \nDigite 0 para terminar o programa.");
	num= int.Parse(Console.ReadLine());
	if (num % 2 ==0)  {
		pares++;
	} else {
		impares++;
	} if (num < 0) {
		negativos++;
	} else {
		positivos++;
	}
} while (num !=0);
Console.WriteLine("Números pares: "+pares+";");
Console.WriteLine("Números ímpares: "+impares+";");
Console.WriteLine("Números negativos: "+negativos+";");
Console.WriteLine("Números positivos: "+positivos+";");
//Fim do programa;

//10.Programa Salário;
double  c, n, e, salario = 0, salarioexc=0; //Feito no Visual Studio;
            string op = "s";
            do
            {
                Console.Write("Digite seu código: ");
                c = double.Parse(Console.ReadLine());
                Console.Write("Digite o número de horas trabalhadas: ");
                n = double.Parse(Console.ReadLine());
                salario = 10.00 * n;
                if (n > 50) 
                {
                    Console.Write("Digite as horas excedidas: ");
                    e = double.Parse(Console.ReadLine());
                    salarioexc = 20.00 * e;
                }
                else
      			{
                    salarioexc= 0;
                }
                Console.WriteLine("OPERADOR {0}", c);
                Console.WriteLine("O salário excedente é: R$" + "{0}" + ".00", salarioexc);
                Console.WriteLine("O salário total é: R$" + (salario + salarioexc) + ".00");
                Console.WriteLine("Deseja encerrar o programa?\nPara sair digite: S");
                op = Console.ReadLine();
} while (op != "S");
Console.Write("Fim do Programa!");
//Fim do programa;
