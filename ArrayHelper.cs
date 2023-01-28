using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivis_zrdadobit_dalageba
{
	public abstract class Comparable
	{
		public abstract int CompareTo(object obj);
	}

	static class ArrayHelper
	{
		public static void Sort(object[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length - i - 1; j++)
				{
					if ((array[j] as Comparable).CompareTo(array[j + 1]) == 1)
					{
						object temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
			}
		}

		public static void Sort(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length - i - 1; j++)
				{
					if (array[j] > array[j + 1])
					{
						int temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
			}
		}

		public static void Sort(string[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length - i - 1; j++)
				{
					if (array[j].Length > array[j + 1].Length)
					{
						string temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
			}
		}
	}
}
