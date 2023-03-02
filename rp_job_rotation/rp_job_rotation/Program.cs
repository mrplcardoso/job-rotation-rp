class Program
{
	static void Main(string[] args)
	{
		/*
		 1) 91
		 */

		/*
		 2)
		 
		bool FindInFibonacci(int value, int iterations)
		{
			if(value < 0 || iterations < 1)
			{ Console.WriteLine("Parametros invalidos");

			List<int> list = new List<int>();
			list.Add(0);
			list.Add(1);
			for(int i = list.Count; i < iterations; i++)
			{
				list.Add(list[(i - 2) + (i - 1)]);
			}
			
			if(list.Contains(value))
			{
				Console.WriteLine("valor encontrado");
				return true;
			}
			Console.WriteLine("valor nao encontrado");
			return false;
		}
		*/

		/*
		 3) 
		a) 9 (soma 2 a cada número da sequencia).
		b) 128 (potência de 2).
		c) 49 (soma de números ímpares).
		d) 100 (numero par elevado a 2).
		e) 13 (soma dos dois anteriores).
		f) ----
		 */

		/*
		 4) Ambos estarão na mesma distância.
		 */

		/*
		 5)
		string Inverse(string value)
		{
			if(string.IsNullOrEmpty(value))
			{
				Console.WriteLine("string invalida");
				return "";
			}
			string inverse = "";
			for(int i = value.Length; i > -1; --i)
			{
				inverse += value[i];
			}
			return inverse;
		}
		 */
	}
}