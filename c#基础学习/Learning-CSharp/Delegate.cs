/*
using System;

delegate int NumberChanger(int n);

namespace DelegateApplication
{
	class TestDelegate
	{
		static int num = 10;
		
		public static int AddNum(int p)
		{
			num += p;
			return num;
		}
		
		public static int MultNum(int q)
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
			//创建委托实例
			NumberChanger nc;
			NumberChanger nc1 = new NumberChanger(AddNum);
			NumberChanger nc2 = new NumberChanger(MultNum);
			nc = nc1;
			nc += nc2;
			//使用委托对象调用方法
			//nc1(25);
			//Console.WriteLine("Value of Num: {0}", getNum());
			//nc2(5);
			//Console.WriteLine("Value of Num: {0}", getNum());
			
			//调用多播
			nc(5);
			Console.WriteLine("Value of Num: {0}", getNum());
			Console.ReadLine();
		}
	}
}
*/

using System;
using System.IO;

namespace DelegateApplication
{
	class PrintString
	{
		static FileStream fs;
		static StreamWriter sw;
		//声明委托
		public delegate void printString(string s);
		
		//该方法打印到控制台
		public static void WriteToScreen(string str)
		{
			Console.WriteLine("The String is: {0}", str);
		}
		
		//该方法打印到文件
		public static void WriteToFile(string s)
		{
			fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
			sw = new StreamWriter(fs);
			sw.WriteLine(s);
			sw.Flush();
			sw.Close();
			fs.Close();
		}
		
		//该方法把委托作为参数，并使用它调用方法
		public static void sendString(printString ps)
		{
			ps("Hello World");
		}
		
		static void Main(string[] args)
		{
			printString ps1 = new printString(WriteToScreen);
			printString ps2 = new printString(WriteToFile);
			sendString(ps1);
			sendString(ps2);
			Console.ReadKey();
		}
	}
}