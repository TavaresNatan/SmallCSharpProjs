<Query Kind="Program" />

void Main()
{
	//Read("File to read");
	//Write("Where to write", "What to write");
}
public string Read(string file)
{
	using(StreamReader reader = new StreamReader(file))
	{
		string text = reader.ReadToEnd();
		return text;
	}
	
}
public void Write(string path, string text)
{
	using(StreamWriter writer = new StreamWriter(path))
		{
			writer.Write(text);
		}
}