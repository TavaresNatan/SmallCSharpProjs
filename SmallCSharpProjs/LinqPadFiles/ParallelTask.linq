<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
/*
	The difference between them
*/
	Stopwatch stopwatch = new Stopwatch();

	//First test
	stopwatch.Start();
	Console.WriteLine("Not using ParallelTask:");
	Task1();Task2();
	stopwatch.Stop();
	Console.WriteLine($@"Time: {stopwatch.ElapsedMilliseconds / 1000.0}s

	");
	
	//Second test
	stopwatch.Reset();
	stopwatch.Start();
	Console.WriteLine("Using ParallelTask:");
	Parallel.Invoke(() => Task1(), () => Task2());
	stopwatch.Stop();
	Console.WriteLine($@"Time: {stopwatch.ElapsedMilliseconds / 1000.0}s");
}

//Creating new tasks for testing
void Task1()
{
	Console.WriteLine("Task1.1");
	Thread.Sleep(4000);
	Console.WriteLine("Task1.2");
}

void Task2()
{
	Console.WriteLine("Task2.1");
	Thread.Sleep(2000);
	Console.WriteLine("Task2.2");
}