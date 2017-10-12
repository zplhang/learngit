using System;
namespace TypeConversionApplication
{
	class ExplicitConversion
	{
		static void Main(string[] args)
		{
			double d = 56743.634;
			int i;
			
			//Ç¿ÖÆ×ª»»double->int
			i= (int)d;
			Console.WriteLine(i);
			
			int ii = 75;
			float ff = 34.33f;
			double dd = 2345.5343;
			bool bb = true;
			
			Console.WriteLine(ii.ToString());
			Console.WriteLine(ff.ToString());
			Console.WriteLine(dd.ToString());
			Console.WriteLine(bb.ToString());
			Console.ReadLine();
		}
	}
}