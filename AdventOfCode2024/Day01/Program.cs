using System;

string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "puzzleInput.txt"));


Console.WriteLine("--- Day 1: Historian Hysteria ---");
Console.WriteLine($"Part 1 Solution: {Part1(input)}");
Console.WriteLine($"Part 2 Solution: {Part2(input)}");

int Part1(string[] input)
{
    List<int> firstList = new List<int>();
    List<int> secondList = new List<int>();
    int totalDistance = 0;

    foreach (string line in input)
    {
        var mySplit = line.Split("   ");
        firstList.Add(int.Parse(mySplit[0]));
        secondList.Add(int.Parse(mySplit[1]));
    }

    //Console.WriteLine("1: " + firstList.First());
    //Console.WriteLine("2: " + secondList.First());

    firstList.Sort();
    secondList.Sort();

    for (int i = 0; i < firstList.Count; i++)
    {
        var dif = Math.Abs(firstList[i] - secondList[i]);
        //Console.WriteLine($"{firstList[i]} - {secondList[i]} = {dif}");
        totalDistance += dif;
    }

    return totalDistance;
}

int Part2(string[] input)
{
    List<int> firstList = new List<int>();
    List<int> secondList = new List<int>();
    int totalSimilarityScore = 0;

    foreach (string line in input)
    {
        var mySplit = line.Split("   ");
        firstList.Add(int.Parse(mySplit[0]));
        secondList.Add(int.Parse(mySplit[1]));
    }

    foreach (int locationId in firstList)
    {
        int occurancesInSecondList = secondList.Count(n => n == locationId);

        var similarityScore = locationId * occurancesInSecondList;
        totalSimilarityScore += similarityScore;
    }


    return totalSimilarityScore;
}