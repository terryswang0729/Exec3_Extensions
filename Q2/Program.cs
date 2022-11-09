using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = "123456789";
			string answer = input.Left(3);
			Console.WriteLine(answer);

			 input = " ";
			 answer = input.Left(3);
			Console.WriteLine(answer);

			 input = "1234 ";
			answer = input.Left(5);
			Console.WriteLine(answer);


		}
	}
	public static class StringExtension
	{
		public static string Left(this string value,int length)
		{
		 if(string.IsNullOrEmpty(value))return string.Empty;
		 if(length<=0)return string.Empty;
		 if(value.Length<=length)return value;
		 return value.Substring(0,length);
		}
	} 
}

