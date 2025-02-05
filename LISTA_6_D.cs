using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
					
			
			Console.Write("Insira uma data: ");
			DateTime data = DateTime.Parse(Console.ReadLine());
			
			DateTime natal = new DateTime(data.Year,12,25);
			DateTime independencia = new DateTime(data.Year,07,07);
			DateTime ano_novo = new DateTime(data.Year,01,01);
			
			if (data == natal || data == independencia ||data == ano_novo) {
				Console.WriteLine("\r\nEsse dia é feriado nacional");
			}
			else {
				Console.WriteLine("\r\nEsse dia não é um feriado nacional");
			}
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}		
