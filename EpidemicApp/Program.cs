// coded with the help of chatgpt

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of laboratories (N): ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of underground roads (M): ");
        int M = int.Parse(Console.ReadLine());

        List<(int, int, int)> roads = new List<(int, int, int)>();
        Console.WriteLine("Enter lab1, lab2, and length separated by space for each road:");
        for (int i = 0; i < M; i++)
        {
            string[] input = Console.ReadLine().Split();
            int lab1 = int.Parse(input[0]);
            int lab2 = int.Parse(input[1]);
            int length = int.Parse(input[2]);
            roads.Add((lab1, lab2, length));
        }

        (List<int>, int) result = FindMostAdvancedLab(N, roads);
        Console.WriteLine("Most Advanced Lab: " + string.Join(", ", result.Item1));
        Console.WriteLine("Shortest Distance to Farthest Neighbor: " + result.Item2);
    }

    static (List<int>, int) FindMostAdvancedLab(int N, List<(int, int, int)> roads)
    {
        List<int> mostAdvancedLabs = new List<int>();
        int shortestDistance = int.MaxValue;

        for (int lab = 1; lab <= N; lab++)
        {
            int farthestNeighborDistance = GetFarthestNeighborDistance(lab, roads);
            if (farthestNeighborDistance <= shortestDistance)
            {
                shortestDistance = farthestNeighborDistance;
                mostAdvancedLabs.Add(lab);
            }
        }
        
        //temporarily fix for the first lab as it is not added every time 
        if (GetFarthestNeighborDistance(1, roads)>shortestDistance)
        {
            Console.WriteLine("removed "+mostAdvancedLabs[0]);
            mostAdvancedLabs.RemoveAt(0);
        }

        return (mostAdvancedLabs, shortestDistance);
    }

    static int GetFarthestNeighborDistance(int lab, List<(int, int, int)> roads)
    {
        int farthestDistance = 0;
        foreach (var road in roads)
        {
            if (road.Item1 == lab || road.Item2 == lab)
            {
                int neighbor = (road.Item1 == lab) ? road.Item2 : road.Item1;
                int distance = road.Item3;
                farthestDistance = Math.Max(farthestDistance, distance);
            }
        }
        return farthestDistance;
    }
}
