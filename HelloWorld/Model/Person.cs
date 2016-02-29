using System;

namespace Model
{
	public class Person
	{
		public int Id { get; private set; }

		public string FirstName { get; set;}
		private string lastName;
		private long value;

		public string LastName {
			get { return lastName; }
			set {
				if (value == null)
					value = "Unknown";
				if(value.Length < 2) 
					throw new ArgumentOutOfRangeException();
				lastName = value; 
			}
		}

		public decimal Value {
			get { return value/100m; }
			set { this.value = (long)(100*value); }
		}

		public Person(int id, string firstName, string lastName) {
			Id = id;
			FirstName = firstName;
			//this.lastName = lastName; Bruger ikke LastName Check.
			LastName = lastName;
		}

		public string Name {
			get { return FirstName + " " + LastName; }
			set { 
				string[] parts = value.Split (" ");
				if (parts.Length < 2)
					return;
				FirstName = parts[0];
				LastName = parts [1];
			}
		}
	}
}

