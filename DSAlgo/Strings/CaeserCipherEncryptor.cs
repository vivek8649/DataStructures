using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Strings
{
	public class CaeserCipherEncryptor
	{
		public static string CaesarCypherEncryptorWithoutChar(string str, int key)
		{
			// Write your code here.
			var alphabet = "abcdefghijklmnopqrstuvwxyz";

			char[] result = new char[str.Length];

			for (int i = 0; i < str.Length; i++)
			{
				result[i] = alphabet[(alphabet.IndexOf(str[i]) + key) % 26];
			}

			return new string(result);
		}

		public static string CaesarCypherEncryptor(string str, int key)
		{
			// Write your code here.
			var res = string.Empty;

			foreach (var item in str)
			{
				res += getConvertedVal(item, key);
			}

			return res; ;
		}


		private static string getConvertedVal(char item, int key)
		{
			key = key % 26;
			var addedValue = item + key;
			if (addedValue > 122)
			{

				var extraValue = (char)(97 + (addedValue - 122) - 1);
				return extraValue.ToString();
			}
			else
			{
				var charVal = (char)addedValue;
				return charVal.ToString();
			}
		}
	}
}
