using System;

namespace FileHandler.Client
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			string directory, fileName;
			var filePath = @"C:/folder1/folder2/file.txt";
			FileHandler.SplitDirectoryFile(filePath, out directory, out fileName);
			Console.WriteLine($"Path:{filePath}, Directory: {directory}, FileName: {fileName}");

			string directory2, fileName2;
			var filePath2 = @"C:\\folder1\\folder2\\\\file.txt";
			FileHandler.SplitDirectoryFile(filePath2, out directory2, out fileName2);
			Console.WriteLine($"Path:{filePath2}, Directory: {directory2}, FileName: {fileName2}");

			string directory3, fileName3;
			var filePath3 = @"C:\file.txt"; 
			FileHandler.SplitDirectoryFile(filePath3, out directory3, out fileName3);
			Console.WriteLine($"Path:{filePath3}, Directory: {directory3}, FileName: {fileName3}");

			string directory4, fileName4;
			var filePath4 = @"\\NL065EOLDemo\DevelopmentMasters\TemplateDatabases\file.txt"; //Network path
			FileHandler.SplitDirectoryFile(filePath4, out directory4, out fileName4);
			Console.WriteLine($"Path:{filePath4}, Directory: {directory4}, FileName: {fileName4}");
			
			Console.ReadKey();
		}
	}
}