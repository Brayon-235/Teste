using System;
class Program
{
   static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        double num = Convert.ToDouble(Console.ReadLine());
	
	/*
        Console.WriteLine("Digite um segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
	*/

        double soma = num + num2;
        Console.WriteLine("A soma desses números é: " + soma);

	
        

        Console.ReadKey();
    }
}
