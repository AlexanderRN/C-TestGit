using System;
using Model;

namespace HelloWorld
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			Person p = new Person (7, "Test", "Testesen");
			Console.WriteLine ("ID: " + p.Id);
			Console.WriteLine ("Firstname: " + p.FirstName);
			Console.WriteLine ("Lastname: " + p.LastName);

			// p.Id = 8; Brokker sig over privat id
			 p.LastName = null;
			 Console.WriteLine ("Lastname: " + p.LastName);
			try {
				p.LastName = "F";
				Console.WriteLine ("Lastname: " + p.LastName);
			} catch (ArgumentOutOfRangeException){
				Console.WriteLine ("The Lastname you submitted was out of the accepted range, please try again.");
			} catch {
				Console.WriteLine ("Ukendt fejl, kontakt support");
			}
		

			//Person p1 = new Person (6, "Test", "T");
		}
	}
}