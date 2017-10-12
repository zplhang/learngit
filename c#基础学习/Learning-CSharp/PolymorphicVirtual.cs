using System;

namespace PolymorphismApplication
{
	class Shape
	{
		protected int width;
		protected int length;
		public Shape(int len = 0, int wid = 0)
		{
			length = len;
			width = wid;
		}
		
		public virtual int area()
		{
			Console.WriteLine("父类的面积：");
			return 0;
		}
	}
	
	class Rectangle : Shape
	{
		public Rectangle(int len = 0, int wid = 0) : base(len, wid)
		{

		}
		
		public override int area()
		{
			Console.WriteLine("Rectangle类的面积为：");
			return (length * width);
		}
	}
	
	class Triangle : Shape
	{
		public Triangle(int a = 0, int b = 0) : base(a, b)
		{
			
		}
		
		public override int area()
		{
			Console.WriteLine("Triangle类的面积：");
			return (width * length / 2);
		}
	}
	
	class Caller
	{
		public void CallArea(Shape sh)
		{
			int a;
			a = sh.area();
			Console.WriteLine("面积：{0}", a);
		}
	}
	
	class Tester
	{
		static void Main(string[] args)
		{
			Caller c = new Caller();
			Rectangle r = new Rectangle(10,8);
			Triangle t = new Triangle(5, 20);
			c.CallArea(r);
			c.CallArea(t);
			Console.ReadKey();
		}
	}
	
}