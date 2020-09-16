using DSAlgo.ArrayProblems;
using DSAlgo.Strings;
using System;
using System.Collections.Generic;
using System.Linq;

public class GFG
{
	static public void Main()
	{
		//	var res = TwoNumberSum.TwoNumberSumFn(new int[] { 3, 5, 6, 9, 10 }, 15);

		// Array
		//var arrProblem = new SumInArray();
		//arrProblem.Start();
		//Console.ReadLine();
		//SpiralTraversal st = new SpiralTraversal();
		//var array = new List<List<int>>{
		//	new List<int>(){ 1, 3, 4, 10},
		//	new List<int>(){ 2, 5, 9, 11},
		//	new List<int>(){ 6, 8, 12, 15},
		//	new List<int>(){ 7, 13, 14, 16}
		//};

		//var res = ZigZagTraverse.ZigzagTraverseAE(array);

		//var list = new List<Dictionary<string, bool>>()
		//{
		//	new Dictionary<string, bool>
		//			{
		//				{ "gym", false },
		//				{ "school", true },
		//				{ "store", false }
		//			},
		//	new Dictionary<string, bool>
		//			{
		//				{ "gym", true },
		//				{ "school", false },
		//				{ "store", false }
		//			},
		//	new Dictionary<string, bool>
		//			{
		//				{ "gym", true },
		//				{ "school", true },
		//				{ "store", false }
		//			},
		//	new Dictionary<string, bool>
		//			{
		//				{ "gym", false },
		//				{ "school", true },
		//				{ "store", false }
		//			},
		//	new Dictionary<string, bool>
		//			{
		//				{ "gym", false },
		//				{ "school", true },
		//				{ "store", true }
		//			}
		//};

		//var res = ApartmentHunting.ApartmentHuntingFn(list, new string[] { "gym", "school", "store" });

		// var res = PalindromeCheck.IsPalindrome("abba");
		//var res = CaeserCipherEncryptor.CaesarCypherEncryptor("xyz", 2);
		// var res = LongestSubstringWithoutDuplicates.LongestSubstringWithoutDuplication("clementisacap");

		// var res = UnderscorifySubstring.UnderscorifySubstringFn("testthis is a testtest to see if testestest it works", "test");

		// var res = PatternMatcher.PatternMatcherFn("yyyy", "testtesttesttest");

		var res = SmallestSubstringContaining.SmallestSubstringContainingFn("abcd$ef$axb$c$", "$$abf");
		Console.ReadLine();

	}

}