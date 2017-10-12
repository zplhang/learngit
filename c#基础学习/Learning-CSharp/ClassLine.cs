using System;

namespace LineApplication
{
	class Line
	{
		private double length;
		/*
		public Line()
		{
			Console.WriteLine("对象已创建。");
		}
		*/
		public Line(double len)
		{
			Console.WriteLine("对象已创建。length = {0}", len);
			length = len;
		}
		~Line()
		{
			Console.WriteLine("对象已删除。");
		}
		
		public void setLength(double len)
		{
			length = len;
		}
		
		public double getLength()
		{
			return length;
		}
		
		static void Main(string[] args)
		{
			//Line line = new Line();
			Line line = new Line(6.4);
			Console.WriteLine("线条的长度：{0}", line.getLength());
			line.setLength(4.5);
			Console.WriteLine("线条的长度：{0}", line.getLength());
			Console.ReadKey();
		}
	}
}