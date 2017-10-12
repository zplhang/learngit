using System;
namespace RectangleApplication
{
	class Rectangle
	{
		//成员变量
		double length;
		double width;
		
		public void Acceptdatails()
		{
			length = 4.5;
			width = 3.5;
		}
		
		public double GetArea()
		{
			return length * width;
		}
		
		public void Display()
		{
			Console.WriteLine("Length: {0}", length);
			Console.WriteLine("Width: {0}", width);
			Console.WriteLine("Area: {0}", GetArea());
		}
	}
	
	class ExecuteRectangle
	{
		static void Main(string[] args)
		{
			Rectangle rect = new Rectangle();
			rect.Acceptdatails();
			rect.Display();
			Console.ReadLine();
		}
	}
}