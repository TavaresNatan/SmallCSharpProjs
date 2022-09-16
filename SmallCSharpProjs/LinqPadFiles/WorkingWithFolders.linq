<Query Kind="Program" />

void Main()
{
	//set a folder 4 testing:
	string folder = "Ur folder goes here";
	

	//Creating folders

	//================Mode 1==========================
	
	string diretory = folder;
	
	if(Directory.Exists(diretory))
	{
		Console.WriteLine("the diretory exists");
	}
	else
	{
		Console.WriteLine("the diretory dont exists");
		Directory.CreateDirectory(diretory);
	}
	
	//deleting the folder
	Directory.Delete(diretory);
	
	//================Mode 2==========================
	Console.WriteLine(@"
	
	");
	DirectoryInfo dir_info = new DirectoryInfo(folder);
	Console.WriteLine(dir_info.Name);
	if(dir_info.Exists)
	{
		Console.WriteLine($"The directory {dir_info.Name} exists");
	}
	else 
	{
		Console.WriteLine($"The directory {dir_info.Name} dont exists");
	}
	
	Console.WriteLine($@"
	Folder attributes: 
	{dir_info.Attributes}"); 
	Console.WriteLine($@"
	Last time this fides has been accessed: 
	{dir_info.LastAccessTime}");
	
	//deleting the folder
	//Directory.Delete(folder);
	
	//================Mode 3==========================
	Console.WriteLine(@"
	
	");
	//show an specific folder
	var MyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
	
	Console.WriteLine($"My docs path: {MyDocs}");
	
	var NameDr = Path.GetDirectoryName(MyDocs);
}

private static void GetDocs(DirectoryInfo folder)
{
	foreach(var f in folder.GetDirectories())
	{
		Console.WriteLine($@"
		
		Folder:
		{f.FullName}
		
		Files:");
		foreach(var fo in f.GetFiles())
		{
			Console.WriteLine(fo.Name);
		}
		GetDocs(f);
	}
}