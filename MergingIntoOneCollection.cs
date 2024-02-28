using System;
using System.Collections.Generic;

namespace MergingIntoOneCollection
{
	internal class MergingIntoOneCollection
	{
		static void Main(string[] args)
		{
			List<string> collections = new List<string>();

			string[] arrayString1 = { "1", "2", "1" };
			string[] arrayString2 = { "3", "2" };

			FillCollectionUniqueValues(collections, arrayString1);
			FillCollectionUniqueValues(collections, arrayString2);

			OutputCollection(collections);
		}

		static void FillCollectionUniqueValues(List<string> collections, string[] arrayString)
		{
			for (int i = 0; i < arrayString.Length; i++)
			{
				if (collections.Contains(arrayString[i]) == false)
					collections.Add(arrayString[i]);
			}
		}

		static void OutputCollection(List<string> collections)
		{
			for (int i = 0; i < collections.Count; i++)
				Console.Write(collections[i] + " ");

			Console.WriteLine();
		}
	}
}
