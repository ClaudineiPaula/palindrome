
using System;
using System.Collections.Generic;
class GFG {

	/*
	* function to check whether characters
	of a string can form a palindrome
	*/
	static Boolean canFormPalindrome(String str)
	{

		// Create a list
		List<char> list = new List<char>();

		// For each character in input strings,
		// remove character if list contains
		// else add character to list
		for (int i = 0; i < str.Length; i++)
		{
			if (list.Contains(str[i]))
				list.Remove((char)str[i]);
			else
				list.Add(str[i]);
		}

		// if character length is even
		// list is expected to be empty
		// or if character length is odd
		// list size is expected to be 1
		
		// if string length is even
		if (str.Length % 2 == 0 && list.Count == 0
			||
			(str.Length % 2 == 1
			&& list.Count == 1))
			return true;
		
		
		// if string length is odd
		else
			return false;
	}

	// Driver Code
	public static void Main(String[] args)
	{
		if (canFormPalindrome("claudinei"))
			Console.WriteLine("Yes");
		else
			Console.WriteLine("No");

		if (canFormPalindrome("osso"))
			Console.WriteLine("Yes");
		else
			Console.WriteLine("No");
	}
}
