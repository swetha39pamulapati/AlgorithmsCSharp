﻿using System;

namespace AllPairSortestFloydWarshall
{
    class Program
    {
		public const int INF = 99999;

		private static void Print(int[,] distance, int verticesCount)
		{
			Console.WriteLine("Shortest distances between every pair of vertices:");

			for (int i = 0; i < verticesCount; ++i)
			{
				for (int j = 0; j < verticesCount; ++j)
				{
					if (distance[i, j] == INF)
						Console.Write("INF".PadLeft(5));
					else
						Console.Write("The distance from {i}, {j}"+ distance[i, j].ToString().PadLeft(5));
				}

				Console.WriteLine();
			}
		}

		public static void FloydWarshall(int[,] graph, int verticesCount)
		{
			int[,] distance = new int[verticesCount, verticesCount];

			for (int i = 0; i < verticesCount; ++i)
				for (int j = 0; j < verticesCount; ++j)
					distance[i, j] = graph[i, j];

			for (int k = 0; k < verticesCount; ++k)
			{
				for (int i = 0; i < verticesCount; ++i)
				{
					for (int j = 0; j < verticesCount; ++j)
					{
						if (distance[i, k] + distance[k, j] < distance[i, j])
							distance[i, j] = distance[i, k] + distance[k, j];
					}
				}
			}

			Print(distance, verticesCount);
		}

		static void Main(string[] args)
		{
			int[,] graph = {
						  { 0,   9, -4 , INF },
						  { 6, 0,   INF, 2 },
						  { INF, 5, 0,   INF },
						  { INF, INF, 1, 0 }
						   };

			FloydWarshall(graph, 4);
		}
	}
}
