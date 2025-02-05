using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{			
			Console.WriteLine("Escolha uma cor: VERMELHO, AZUL OU VERDE ");
			string cor = Console.ReadLine();
			
			switch (cor.ToLower())
			{
				case "vermelho":
					Console.WriteLine("\r\nO usuario escolheu vermelho!");
					break;
				case "azul":
					Console.WriteLine("\r\nO usuario escolheu azul!");
					break;
				case "verde":
					Console.WriteLine("\r\nO usuario escolheu verde!");
					break;	         
			}
			
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}		
