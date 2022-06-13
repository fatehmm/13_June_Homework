using System;
namespace _13JuneHomework
{
	public class Human
	{
		public Human(int age, string name = null, string surname = null)
		{
			this.Age = age;
			this.Name = name;
			this.Surname = surname;
		}
		public string Name;
		public string Surname;
		public int Age;
		
	}
}

