using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GridChallenge
{
	class Result
	{

		/*
		 * Complete the 'gridChallenge' function below.
		 *
		 * The function is expected to return a STRING.
		 * The function accepts STRING_ARRAY grid as parameter.
		 */

		public static string gridChallenge(List<string> grid)
		{
			var output = grid.Select(g => g.OrderBy(c => c));

			var length = grid[0].Length;

			var column = new List<char>();

			for(int i = 0; i < length; i++)
			{
				var collection = output.Select(g => g.ElementAt(i));
				if(!collection.OrderBy(x => x).SequenceEqual(collection))
				{
					return "NO";
				}
			}

			return "YES";
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			var s = new List<string> { "abc", "hjk", "mpq", "rtv" };
	
			Console.WriteLine(Result.gridChallenge(s));

			Console.ReadKey();
		}
	}
}
