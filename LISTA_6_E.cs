using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{			
			Console.WriteLine("Escolha uma opçao: 1, 2 ou 3");
			int opcao = Int32.Parse(Console.ReadLine());
			
			switch (opcao) 
			{
				case 1:
					Console.WriteLine("\r\nVoçê selecionou a opçao 1!");
					break;
				case 2:
					Console.WriteLine("\r\nVoçê selecionou a opçao 2!");
					break;
				case 3:
					Console.WriteLine("\r\nVoçê selecionou a opçao 3!");
					break;	         
			}
			
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}		
