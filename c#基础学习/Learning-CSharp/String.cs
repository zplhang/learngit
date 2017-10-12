using System;
namespace StringApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			//字符串连接
			string fname, lname;
			fname = "Rowan";
			lname = "Atkinson";
			
			string fullname = fname + lname;
			Console.WriteLine("Full name: {0}", fullname);
			
			//通过使用string构造函数
			char[] letters = {'H', 'e', 'l', 'l', 'o'};
			string greetings = new string(letters);
			Console.WriteLine("Greeting: {0}", greetings);
			
			
			//方法返回字符串
			string[] sarray = {"Hello", "From", "Tutorials", "Point"};
			string message = String.Join(" ", sarray);
			Console.WriteLine("Message: {0}", message);
			
			//用于转化值得格式化方法
			DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
			string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
			Console.WriteLine("Message: {0}", chat);
			
			//比较字符串
			string str1 = "This is test";
			string str2 = "This is text";
			if(String.Compare(str1, str2) == 0)
			{
				Console.WriteLine(str1 + " and " + str2 + " are equal.");
			}
			else
			{
				Console.WriteLine(str1 + " and " + str2 + " are not equal.");
			}
			
			//字符串包含字符串
			string str = "This is test";
			if(str.Contains("test"))
			{
				Console.WriteLine("The sequence 'test' was found.");
			}
			
			//获取子字符串
			str = "Last night I dreamt of San Pedro";
			Console.WriteLine(str);
			string substr = str.Substring(23);
			Console.WriteLine(substr);
			
			//连接字符串
			string[] strarray = new string[]{"Down the way nights are dark", 
			"And the sun shines daily on the mountain top",
			"I took a trip on a sailing ship", 
			"And when I reached Jamaica", "I made a stop"};
			str = String.Join("\n", strarray);
			Console.WriteLine(str);
			
			Console.ReadLine();
		}
		
	}
}