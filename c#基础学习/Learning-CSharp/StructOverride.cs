using System;

namespace StructApplication
{
	struct Books
	{
		private string title;
		private string author;
		private string subject;
		private int book_id;
		
		public void getValues(string t, string a, string s, int id)
		{
			title = t;
			author = a;
			subject = s;
			book_id = id;
		}
		
		public void display()
		{
			Console.WriteLine("Title: {0}", title);
			Console.WriteLine("Author: {0}", author);
			Console.WriteLine("Subject: {0}", subject);
			Console.WriteLine("Book_id: {0}", book_id);
		}
	};

	class TestStructure
	{
		static void Main(string[] args)
		{
			Books book1 = new Books();
			Books book2 = new Books();
			
			book1.getValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);
			book2.getValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", 6495700);

			book1.display();
			book2.display();
			
			Console.ReadLine();
		}
		
	}
}