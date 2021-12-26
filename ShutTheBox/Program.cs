using ShutTheBox;

var lowerBound = 1;
var upperBound = 9;
var numberOfRuns = 10000000;

var boxes = Enumerable.Range(lowerBound, upperBound)
    .Select(i => new Box(i))
    .ToList();

var random = new Random();

var runs = Enumerable.Range(1, numberOfRuns)
    .AsParallel()
    .Select(i =>
    {
        var progress = ((i / (double)numberOfRuns) * 100);
        if (progress % 1 == 0)
        {
            Console.Write($"\r{progress}%");
        }

        if (progress == 100)
        {
            Console.Write('\n');
        }

        return Simulator.RunGame(boxes, random, i, Sorter.ExtremesLast(upperBound, lowerBound));
    })
    .ToList();

var successRatio = (float)runs.Where(r => r).Count() / (float)runs.Count;

Console.WriteLine($"Win percentage: {successRatio * 100}%");

Console.Read();


