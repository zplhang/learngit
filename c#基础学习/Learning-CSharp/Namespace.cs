using System;
using FirstSpace;
using SecondSpace;

namespace FirstSpace
{
	class abc
	{
		public void func()
		{
			Console.WriteLine("Inside first space");
		}
	}
}

namespace SecondSpace
{
	class def
	{
		public void func()
		{
			Console.WriteLine("Inside second space");
		}
	}
}

class TestClass
{
	static void Main(string[] args)
	{
		//FirstSpace.namespace_cl fc = new FirstSpace.namespace_cl();
		//SecondSpace.namespace_cl sc = new SecondSpace.namespace_cl();
		abc fc = new abc();
		def sc = new def();
		fc.func();
		sc.func();
		Console.ReadKey();
	}
}