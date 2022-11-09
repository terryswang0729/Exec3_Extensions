using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = "123456";
			int answer = input.ToInt(0);
			Console.WriteLine(answer);
			input = "你好";
			answer = input.ToInt(0);
			Console.WriteLine(answer);
		}
	}
	public static class StringExtension
	{
		public static int ToInt(this string value, int defaultValue)
		{
			bool isInt = int.TryParse(value, out int number);
			if(isInt)
			{

				return number;
			}
			else
			{
				return defaultValue;
			}
		}
	}
}
