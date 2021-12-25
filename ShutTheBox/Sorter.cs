namespace ShutTheBox
{
    internal static class Sorter
    {
        internal static Comparison<int[]> ExtremesFirst(int upperBound, int lowerBound) => 
            (int[] firstOperand, int[] secondOperand) =>
            {
                var arithmeticMean = (upperBound + lowerBound) / 2.0;

                var (firstExtreme, secondExtreme) = CalculateExtremes(firstOperand, secondOperand, arithmeticMean);

                return firstExtreme < secondExtreme ? -1 : 1;
            };

        internal static Comparison<int[]> ExtremesLast(int upperBound, int lowerBound) =>
            (int[] firstOperand, int[] secondOperand) =>
            {
                var arithmeticMean = (upperBound + lowerBound) / 2.0;

                var (firstExtreme, secondExtreme) = CalculateExtremes(firstOperand, secondOperand, arithmeticMean);

                return firstExtreme > secondExtreme ? -1 : 1;
            };

        internal static int MinimumFlipsFirst(int[] firstOperand, int[] secondOperand)
        {
            return firstOperand.Length < secondOperand.Length ? -1 : 1;
        }

        internal static int MaximumFlipsFirst(int[] firstOperand, int[] secondOperand)
        {
            return firstOperand.Length < secondOperand.Length ? 1 : -1;
        }

        private static (double firstExtreme, double secondExtreme) CalculateExtremes(
            int[] firstOperand, 
            int[] secondOperand, 
            double mean)
        {
            var firstExtremeScore = firstOperand.Aggregate(
                0,
                AggregateNormalizedExtremeScore(mean, firstOperand.Length));

            var secondExtremeScore = secondOperand.Aggregate(
                0,
                AggregateNormalizedExtremeScore(mean, secondOperand.Length));

            return (firstExtremeScore, secondExtremeScore);
        }

        private static Func<double, int, double> AggregateNormalizedExtremeScore(double arithmeticMean, int arrayLength) =>
            (double previousValue, int currentValue) =>
            {
                return (previousValue + (int)Math.Abs(currentValue - arithmeticMean)) / (double)arrayLength;
            };
    }
}
