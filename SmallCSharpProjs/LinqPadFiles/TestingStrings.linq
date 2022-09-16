<Query Kind="Program" />

void Main()
{
	//StringBuilder
	StringBuilder subjects = new StringBuilder();
	subjects.Append("portuguese");
	subjects.Append(", matematic");
	Console.WriteLine(subjects);
	
	//=========================================
	string ingredients = GetIngredientes();
	
	//StringWriter
	using (StringWriter writer = new StringWriter())
	{
		//StringReader
		using (StringReader reader = new StringReader(ingredients))
		{
			string line;
	
			while((line = reader.ReadLine()) != null)
			{
				writer.WriteLine(" - " + line);
			}
		}
		Console.WriteLine(writer);
	}
	//========================================
	
	string doc = GetDocument();
	
	Console.WriteLine(doc.ToUpper());
	
	foreach(var chr in doc)
	{
		if(char.IsUpper(chr))
		{
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Blue;
		}
		else
		{
			Console.ResetColor();
		}
		Console.Write(chr);
	}
	string doc2 = GetDoc();
	
	Console.WriteLine(doc2);
	
	//undefined variables
	var unvar = new
	{                       //it shoudnt be here, get that as a bonus :)
		Age = 8,
		Name = "Jeanne",
	};
	
	Console.WriteLine(unvar.Age);
	Console.WriteLine(unvar.Name);
	Console.Read();
}

//Items list:
public static string GetIngredientes()
{
return
@"The ingredients are:

-3 eggs
-1 apple
-4 chicken";
}

public static string GetDocument()
{
	return
	@"
	And for those who choose the freedom, i
	beg you to wear a cloth that haves a color
	of our nation on it, be it green, white or
	even red, the color of our enemies blood!";
}

//String concat
public static string GetDoc()
{
	 string Name = Console.ReadLine();
	 DateTime dt = DateTime.Today;
	 
	 string doc = string.Format(
	 @"
	 I want you here, {0} at the
	 day {1:dd/MM/yy}. 
	 ", Name, dt);
	 			  //'C' (Currency)
				  //'t' (time)
				  //'d' (date)
	 
	 return doc;
}