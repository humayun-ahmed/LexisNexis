using FileHandler.Core;
using NUnit.Framework;

namespace FileHandler.Tests
{
	[TestFixture]
	public class FileHandlerServiceTest
	{
		[Test]
		public void TestSplitDirectoryFile_ForwardSlashInPath_Success()
		{
			string directory, fileName;
			var filePath = @"C:/folder1/folder2/file.txt";
			FileHandlerService.SplitDirectoryFile(filePath, out directory, out fileName);
			Assert.IsTrue(directory.Equals("C:/folder1/folder2"),"Failed to get directory.");
			Assert.IsTrue(fileName.Equals("file.txt"), "Failed to get file name.");
		}

		[Test]
		public void TestSplitDirectoryFile_MultipleBackSlashInPath_Success()
		{
			string directory, fileName;
			var filePath = @"C:\\folder1\\folder2\\\\file.txt";
			FileHandlerService.SplitDirectoryFile(filePath, out directory, out fileName);
			Assert.IsTrue(directory.Equals(@"C:\\folder1\\folder2"), "Failed to get directory.");
			Assert.IsTrue(fileName.Equals("file.txt"), "Failed to get file name.");
		}

		[Test]
		public void TestSplitDirectoryFile_FileInRootCDirectory_Success()
		{
			string directory, fileName;
			var filePath = @"C:\file.txt";
			FileHandlerService.SplitDirectoryFile(filePath, out directory, out fileName);
			Assert.IsTrue(directory.Equals(@"C:\"), "Failed to get directory.");
			Assert.IsTrue(fileName.Equals("file.txt"), "Failed to get file name.");
		}

		[Test]
		public void TestSplitDirectoryFile_NetworkPath_Success()
		{
			string directory, fileName;
			var filePath = @"\\folder1\folder\file.txt";
			FileHandlerService.SplitDirectoryFile(filePath, out directory, out fileName);
			Assert.IsTrue(directory.Equals(@"\\folder1\folder"), "Failed to get directory.");
			Assert.IsTrue(fileName.Equals("file.txt"), "Failed to get file name.");
		}
	}
}
