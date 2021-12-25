namespace ShutTheBox
{
    internal static class Constants
    {
        internal static readonly Dictionary<int, int[][]> Solutions = new()
        {
            { 2, new[] { new[] { 2 } } },
            { 3, new[] { new[] { 3 }, new[] { 1, 2 } } },
            { 4, new[] { new[] { 4 }, new[] { 1, 3 } } },
            { 5, new[] { new[] { 5 }, new[] { 1, 4 }, new[] { 2, 3 } } },
            { 6, new[] { new[] { 6 }, new[] { 1, 5 }, new[] { 2, 4 }, new[] { 1, 2, 3 } } },
            { 7, new[] { new[] { 7 }, new[] { 1, 6 }, new[] { 2, 5 }, new[] { 3, 4 }, new[] { 1, 2, 4 } } },
            { 8, new[] { new[] { 8 }, new[] { 1, 7 }, new[] { 2, 6 }, new[] { 3, 5 }, new[] { 1, 2, 5 } } },
            { 9, new[] { new[] { 9 }, new[] { 1, 8 }, new[] { 2, 7 }, new[] { 3, 6 }, new[] { 4, 5 }, new[] { 1, 2, 6 }, new[] { 2, 3, 4 } } },
            { 10, new[] { new[] { 1, 9 }, new[] { 2, 8 }, new[] { 3, 7 }, new[] { 4, 6 }, new[] { 1, 2, 7 }, new[] { 2, 3, 5 }, new[] { 1, 2, 3, 4 } } },
            { 11, new[] { new[] { 2, 9 }, new[] { 3, 8 }, new[] { 4, 7 }, new[] { 5, 6 }, new[] { 1, 2, 8 }, new[] { 2, 3, 6 }, new[] { 1, 2, 3, 5 } } },
            { 12, new[] { new[] { 3, 9 }, new[] { 4, 8 }, new[] { 5, 7 }, new[] { 1, 2, 9 }, new[] { 2, 3, 7 }, new[] { 3, 4, 5 }, new[] { 1, 2, 3, 6 } } }
        };
    }
}
