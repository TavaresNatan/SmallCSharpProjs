<Query Kind="Program" />

void Main()
{
/*
	Get info about one or more files
*/
	FInfo.Single("File path goes here");
	//FInfo.StrArray("Files array goes here"); can use Directory.GetFiles if u want
}

class FInfo
{
	public static void Single(string file)
	{
		try
		{
			FileInfo fi = new FileInfo(file);
			
			Console.WriteLine("File name: " + fi.Name);
			Console.WriteLine("File full name: " + fi.FullName);
			Console.WriteLine("Last access: " + fi.LastAccessTime);
			Console.WriteLine("File used space: " + fi.Length + "bytes");
			Console.WriteLine("File attributes: " + fi.Attributes);
		}
		catch(Exception e)
		{
			Console.WriteLine(e.Message); throw;
		}
	}
	
	public static void StrArray(string[] files)
	{
		foreach(var file in files)
		{
			Single(file);
			Console.WriteLine("========================");
		}
	}
}

