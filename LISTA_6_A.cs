using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			var dataAtual = DateTime.Now;
			Console.WriteLine(dataAtual);
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}		
