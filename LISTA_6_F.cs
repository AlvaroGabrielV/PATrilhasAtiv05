using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{
			Console.Write("Insira um numero: ");
			int opcao = Int32.Parse(Console.ReadLine());
			
			if (opcao > 0) {
				Console.WriteLine("\r\n{0} é um numero positivo", opcao);
			}
			else if (opcao < 0) {
				Console.WriteLine("\r\n{0} é um numero negativo", opcao);
			}
			else {
				Console.WriteLine("\r\n{0} é igual a zero", opcao);
			}
				
			
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
