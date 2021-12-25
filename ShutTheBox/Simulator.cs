namespace ShutTheBox
{
    internal static class Simulator
    {
        public static bool RunGame(IEnumerable<Box> boxes, Random random, int index, Comparison<int[]> comparer)
        {
            var complete = false;

            while (!complete)
            {
                var roll = random.Next(1, 6) + random.Next(1, 6);
                var openBoxes = boxes.Where(box => !box.IsShut);

                var solutions = Constants.Solutions[roll].ToList();

                solutions.Sort(comparer);

                var boxesToShut = solutions
                    .FirstOrDefault(soln => soln.All(val => openBoxes.Select(box => box.Value).Contains(val)), Array.Empty<int>());

                boxes = boxes.Select(box => new Box(box.Value, boxesToShut.Contains(box.Value) || box.IsShut));

                complete = !boxesToShut.Any();
            }

            var result = boxes.All(box => box.IsShut);

            return result;
        }
    }
}
