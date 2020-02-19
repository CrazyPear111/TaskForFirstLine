using System;
using static System.Math;

namespace TriangleLib
{
	public static class Triangle
	{
		public static string Type(double a, double b, double c)
		{
			double[] arr = { a, b, c };
			Array.Sort(arr);

			if (arr[0] + arr[1] <= arr[2]) return "Impossible";

			for (int i = 0; i<arr.Length; i++)
				arr[i] = Pow(arr[i], 2);

			if (arr[0] + arr[1] == arr[2]) return "RightAngled";
			if (arr[0] + arr[1] < arr[2]) return "Obtuse";
			else return "Acute";
		}
	}
}