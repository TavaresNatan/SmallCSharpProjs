<Query Kind="Program" />

void Main()
{
/*
	Shows some specs of your drives
*/
	var drives = DriveInfo.GetDrives();
	
	foreach(var dv in drives)
	{
	Console.WriteLine("====================================");
		Console.WriteLine("Drive Name: " + dv.Name);
		if(!dv.IsReady)
		{
			Console.WriteLine($"The drive: {dv.Name} isn't ready.");
			continue; //para ignorar o resto do bloco em Void
		} else{Console.WriteLine($"The drive: {dv.Name} is ready.");}
		
		Console.WriteLine($"Drive Format: {dv.DriveFormat}");
		Console.WriteLine($"Drive Type: {dv.DriveType}");
		
		Console.WriteLine("Free space in MB and GB:");
		Console.WriteLine($"{dv.TotalFreeSpace / 1024 / 1024} MB");
		Console.WriteLine($"{dv.TotalFreeSpace / 1024 / 1024 / 1024} GB");
	}
}