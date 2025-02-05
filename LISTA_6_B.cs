using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira uma data: ");
			DateTime primeiraData = DateTime.Parse(Console.ReadLine());
			Console.Write("Insira outra data: ");
			DateTime segundaData = DateTime.Parse(Console.ReadLine());
			
			TimeSpan diferenca = primeiraData - segundaData;
			
			double totaldias = Math.Abs(diferenca.TotalDays);
			
			Console.WriteLine("\r\nA diferença de dias entre {0} e {1} é {2} dias",primeiraData.ToString("dd/MM/yyyy") ,segundaData.ToString("dd/MM/yyyy") , totaldias);
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}		
