namespace Assignment03;

public class AdjListGraph : IAdjustListGraph
{
    private Dictionary<int, List<int>> adjList;

    public AdjListGraph()
    {
        adjList = new Dictionary<int, List<int>>();
    }
    
    public void AddEdge(int src, int dest)
    {
        if (!adjList.ContainsKey(src))
        {
            Console.WriteLine($"Node {src} does not exist.");
            return;
        }

        if (!adjList.ContainsKey(dest))
        {
            Console.WriteLine($"Node {dest} does not exist.");
            return;
        }
        adjList[src].Add(dest);
        adjList[dest].Add(src);
    }

    public void AddNode(AdjListNode node)
    {
        if (!adjList.ContainsKey(node.Data))
        {
            adjList[node.Data] = new List<int>();
        }
        else
        {
            Console.WriteLine($"Node {node.Data} already exists.");
        }
    }

    public void DisplayAdjlist()
    {
        foreach (var kvp in adjList)
        {
            Console.Write($"{kvp.Key}: ");
            foreach (var neighbor in kvp.Value)
            {
                Console.Write($"{neighbor} ");
            }
            Console.WriteLine();
        }
    }
}