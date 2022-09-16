<Query Kind="Program" />

void Main()
{
/*
	A simple linq search by name
*/
	List<Person> list_people = new List<Person>();
	
	#region Creating test users
	var test1 =
		new Person(){
			Name = "Natan",
			age = 18};
			list_people.Add(test1);
			
	var test2 =
		new Person(){
			Name = "Jason",
			age = 23};
		list_people.Add(test2);
	#endregion
	
	//Search for a specific person 
	var search = from person in list_people 
					where person.Name == "Natan"
					select person;
	
	Console.WriteLine(search.ToList()[0].Name);
	Console.ReadLine();
}

//Defines a person for the test
class Person
{
	public string Name{get;set;}
	public int age{get;set;}
}