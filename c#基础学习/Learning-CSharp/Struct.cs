using System;

namespace StructApplication
{
	struct Books
	{
		public string title;
		public string author;
		public string subject;
		public int book_id;
	};

	class TestStructure
	{
		static void Main(string[] args)
		{
			Books book1;
			Books book2;
			
			book1.title = "C Programming";
			book1.author = "Nuha Ali";
			book1.subject = "C Programming Tutorial";
			book1.book_id = 6495407;
			
			book2.title = "Telecom Billing";
			book2.author = "Zara Ali";
			book2.subject = "Telecom Billing Tutorial";
			book2.book_id = 6495700;
			
			Console.WriteLine("Book 1 title: {0}", book1.title);
			Console.WriteLine("Book 1 author: {0}", book1.author);
			Console.WriteLine("Book 1 subject: {0}", book1.subject);
			Console.WriteLine("Book 1 book_id: {0}", book1.book_id);
			
			Console.WriteLine("Book 2 title: {0}", book2.title);
			Console.WriteLine("Book 2 author: {0}", book2.author);
			Console.WriteLine("Book 2 subject: {0}", book2.subject);
			Console.WriteLine("Book 2 book_id: {0}", book2.book_id);
			
			Console.ReadLine();
		}
		
	}
}