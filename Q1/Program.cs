using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
		  bool result=100.IsOdd();
			Console.WriteLine(result);
		  bool result2=100.IsEven();
			Console.WriteLine(result2);
		}
	}
	public static class IntExtension
	{
		public static bool IsOdd(this int source)
		{
			return source%2 ==1;
		}
		public static bool IsEven(this int source)
		{
			return source %2 ==0;
		}
	}
}
