using ShutTheBox;

var lowerBound = 1;
var upperBound = 9;

var boxes = Enumerable.Range(lowerBound, upperBound)
    .Select(i => new Box(i))
    .ToList();

var random = new Random();

var runs = Enumerable.Range(1, 10000)
    .Select(i => Simulator.RunGame(boxes, random, i, Sorter.ExtremesFirst(upperBound, lowerBound)))
    .ToList();

var successRatio = (float)runs.Where(r => r).Count() / (float)runs.Count;

Console.WriteLine($"Win percentage: {successRatio * 100}%");

Console.Read();


