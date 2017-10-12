using System;

namespace InheritanceApplication
{
	class Rectangle
	{
		protected double length;
		protected double width;
		
		public Rectangle(double len, double wid)
		{
			length = len;
			width = wid;
		}
		
		public double GetArea()
		{
			return length * width;
		}
		
		public void Display()
		{
			Console.WriteLine("长度：{0}", length);
			Console.WriteLine("宽度：{0}", width);
			Console.WriteLine("面积：{0}", GetArea());
		}
	}
	
	class Tabletop : Rectangle
	{
		private double cost;
		public Tabletop(double l, double w) : base(l, w)
		{
			
		}
		
		public double GetCost()
		{
			double cost;
			cost = GetArea() * 70;
			return cost;
		}
		
		public void Display()
		{
			base.Display();
			Console.WriteLine("成本：{0}", GetCost());
		}
	}
	
	class RectangelTester
	{
		static void Main(string[] args)
		{
			Tabletop t = new Tabletop(4.5, 6.4);
			t.Display();
			Console.ReadKey();
		}
	}
}