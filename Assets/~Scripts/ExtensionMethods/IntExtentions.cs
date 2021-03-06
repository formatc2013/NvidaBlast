﻿using UnityEngine;

public static class IntExtentions
{
	public static string ToOrdinal(this int number)
	{
		if (number <= 0)
			return number.ToString();

		return number + GetOrdinal(number);
	}

	private static string GetOrdinal(int number)
	{
		switch (number % 100)
		{
			case 11:
			case 12:
			case 13:
				return "th";
		}
		
		switch (number % 10)
		{
			case 1:
				return "st";
			case 2:
				return "nd";
			case 3:
				return "rd";
			default:
				return "th";
		}
	}
}