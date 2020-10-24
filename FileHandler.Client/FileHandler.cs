using System.IO;

namespace FileHandler.Client
{
	public static class FileHandler
	{
		/// <summary>
		///     Though it is better to write individual method GetDirectoryName and GetFileName instead of one method, but still
		///     here done in one method due to requirement and performance
		/// </summary>
		/// <param name="path">file path</param>
		/// <param name="directory">directory path</param>
		/// <param name="file">file name</param>
		public static void SplitDirectoryFile(string path, out string directory, out string file)
		{
			directory = null;
			file = null;

			// assumes a validated full path
			if (path != null)
			{
				var length = path.Length;
				int rootLength = GetRootLength(path.ToCharArray());
				// find the pivot index between end of string and root
				for (var pivot = length - 1; pivot >= rootLength; pivot--)
					if (IsDirectorySeparator(path[pivot]))
					{						
						var endDirectorySeparatorBeforeIndex = EndDirectorySeparatorBeforeIndex(path, pivot);
						directory = path.Substring(0, endDirectorySeparatorBeforeIndex);
						file = path.Substring(pivot + 1, length - pivot - 1);
						return;
					}

				if (directory == null)
				{
					directory = path.Substring(0, rootLength);
					file = path.Substring(rootLength, path.Length - rootLength);
				}
			}
		}

		private static int EndDirectorySeparatorBeforeIndex(string path, int lastSeparatorEndIndex)
		{
			for (var index = lastSeparatorEndIndex - 1; index >= 0; index--)
				if (!IsDirectorySeparator(path[index]))
					return index;
			return 0;
		}

		private static bool IsDirectorySeparator(char ch)
		{
			return ch == Path.DirectorySeparatorChar || ch == Path.AltDirectorySeparatorChar ||
			       ch == Path.VolumeSeparatorChar;
		}

		private static int GetRootLength(char[] path)
		{
			int i = 0;
			int volumeSeparatorLength = 2;  // Length to the colon "C:"
			int pathLength = path.Length;


			if (pathLength >= volumeSeparatorLength && path[volumeSeparatorLength - 1] == Path.VolumeSeparatorChar)
			{
				// If the colon is followed by a directory separator, move past it
				i = volumeSeparatorLength;
				if (pathLength >= volumeSeparatorLength + 1 && IsDirectorySeparator(path[volumeSeparatorLength])) i++;
			}
			return i;
		}
	}
}