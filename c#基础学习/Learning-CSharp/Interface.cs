using System;
namespace InterfaceApplication
{
	interface IMyInterface
	{
		void MethodToImplement();
	}
	
	class InterfaceImplementer : IMyInterface
	{
		static void Main()
		{
			InterfaceImplementer iTmp = new InterfaceImplementer();
			iTmp.MethodToImplement();
		}
		
		public void MethodToImplement()
		{
			Console.WriteLine("MethodToImplement() is called");
		}
	}
}