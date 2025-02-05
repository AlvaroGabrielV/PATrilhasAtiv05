using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{			
			Console.Write("Escolha uma letra: ");
			string cor = Console.ReadLine();
			
			switch (cor.ToLower())
			{
				case "A":
					Console.WriteLine("\r\nA letra inserida é uma vogal!");
					break;
				case "E":
					Console.WriteLine("\r\nA letra inserida é uma vogal!");
					break;
				case "I":
					Console.WriteLine("\r\nA letra inserida é uma vogal!");
					break;
				case "O":
					Console.WriteLine("\r\nA letra inserida é uma vogal!");
					break;
				case "U":
					Console.WriteLine("\r\nA letra inserida é uma vogal!");
					break;
				default:
					Console.WriteLine("\r\nA letra inserida é uma consoante!");	
					break;
			}
			
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}		
