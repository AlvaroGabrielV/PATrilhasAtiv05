using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira sua data de nascimento: ");
			DateTime data_nascimento = DateTime.Parse(Console.ReadLine());
			
			DateTime dataatual = DateTime.Now;
				
			TimeSpan idade = data_nascimento - dataatual;
			
			double anos = idade.TotalDays / 365.25;
			double idadetotal = Math.Abs(anos);
			
			Console.WriteLine("\r\nA idade é {0} Anos", idadetotal.ToString("F0"));
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}		
