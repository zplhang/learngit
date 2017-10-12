using System;

namespace PolymorphismApplication
{
	//»ùÀà
	class Printdata
	{
		void print(int i)
		{
			Console.WriteLine("Printing int: {0}", i);
		}
		
		void print(double d)
		{
			Console.WriteLine("Printing double: {0}", d);
		}
		
		void print(string s)
		{
			Console.WriteLine("Printing string: {0}", s);
		}
		
		static void Main(string[] args)
		{
			Printdata p = new Printdata();
			p.print(7);
			p.print(34.53);
			p.print("Hello c#");
			Console.ReadKey();
		}
	}
	
}