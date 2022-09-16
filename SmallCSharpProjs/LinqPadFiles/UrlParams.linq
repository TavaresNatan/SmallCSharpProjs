<Query Kind="Program" />

void Main()
{
/*
	Get only the params of an url (id=, page=, [...])
*/
	string url = "Url goes here";
	Console.WriteLine(url);
	
	Showurl(Extract(url));
	
	Console.ReadLine();
}

string Extract(string url)
{
	if(string.IsNullOrEmpty(url)){throw new Exception("Can't be null or empty.");}
		
	int index = url.IndexOf('?');
	return url.Substring(index + 1);
}

void Showurl(string urlCut)
{
	Console.WriteLine($@"
	The params of this url are :
	=
	
	{urlCut}
	
	=");
}