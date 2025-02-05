using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{			
			Console.WriteLine("Escolha uma opçao:\r\n \r\n1.INICIAR \r\n2.PAUSAR\r\n3.CONFIGURAÇÕES");
			int opcao = Int32.Parse(Console.ReadLine());
			
			switch (opcao) 
			{
				case 1:
					Console.WriteLine("\r\nVoçê iniciou a operação!");
					break;
				case 2:
					Console.WriteLine("\r\nVoçê pausou a operação!");
					break;
				case 3:
					Console.WriteLine("\r\nVoçê abriu as configurações!");
					break;	         
			}
			
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}		
