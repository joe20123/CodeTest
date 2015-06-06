using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
	public class AllSubsetOfASet
	{
		public static List<List<int>> getSubSets(List<int> set)
		{
			List<List<int>> allsubset=new List<List<int>>();
			int max=1<<set.Count();

			for (int i = 0; i < max; i++)
			{
				List<int> subset=new List<int>();
				int k = i;
				int index = 0;
				while (k > 0)
				{
					if ((k & 1) > 0)
						subset.Add(set.ElementAt(index));
					k >>= 1;
					index++;
				}
				allsubset.Add(subset);
			}
			return allsubset;
		}
	}
}
