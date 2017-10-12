using System;
using System.Collections.Generic;

delegate T NumberChanger<T>(T n);

namespace GenericApplication
{
	public class MyGenericArray<T>
	{
		private T[] array;
		
		public MyGenericArray(int size)
		{
			array = new T[size + 1];
		}
		
		public T getItem(int index)
		{
			return array[index];
		}
		
		public void setItem(int index, T value)
		{
			array[index] = value;
		}
	}
	
	class Tester
	{
		//泛型方法
		static void swap<T>(ref T lhs, ref T rhs)
		{
			T temp;
			temp = lhs;
			lhs = rhs;
			rhs = temp;
		}
		
		//泛型委托
		static int num = 10;
		public static int AddNum(int p)
		{
			num += p;
			return num;
		}
		
		public static int MultiNum(int q)
		{
			num *= q;
			return num;
		}
		
		public static int getNum()
		{
			return num;
		}
		
		static void Main(string[] args)
		{
			//声明一个整型数组
			MyGenericArray<int> intArray = new MyGenericArray<int>(5);
			
			//设置值
			for(int i = 0; i < 5; i++)
			{
				intArray.setItem(i, i * 5);
			}
			
			//获取值
			for(int i = 0; i < 5; i++)
			{
				Console.Write(intArray.getItem(i) + " ");
			}
			
			Console.WriteLine();
			
			MyGenericArray<char> charArray = new MyGenericArray<char>(5);
			for(int i = 0; i < 5; i++)
			{
				charArray.setItem(i, (char)(i + 97));
			}
			for(int i = 0; i < 5; i++)
			{
				Console.Write(charArray.getItem(i) + " ");
			}
			Console.WriteLine();
			
			int a, b;
			char c, d;
			a = 10;
			b = 20;
			c = 'I';
			d = 'V';
			
			//交换之前
			Console.WriteLine("Int values before calling swap: ");
			Console.WriteLine("a = {0}, b = {1}", a, b);
			Console.WriteLine("Char values before calling swap: ");
			Console.WriteLine("c = {0}, d = {1}", c, d);
			//交换
			swap<int>(ref a, ref b);
			swap<char>(ref c, ref d);
			
			//交换之后
			Console.WriteLine("Int values after calling swap: ");
			Console.WriteLine("a = {0}, b = {1}", a, b);
			Console.WriteLine("Char values after calling swap: ");
			Console.WriteLine("c = {0}, d = {1}", c, d);
			
			//创建委托实例
			NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
			NumberChanger<int> nc2 = new NumberChanger<int>(MultiNum);
			//使用委托对象调用方法
			nc1(35);
			Console.WriteLine("Value of Num: {0}", getNum());
			nc2(5);
			Console.WriteLine("Value of Num: {0}", getNum());
			Console.ReadKey();
		}
	}
}