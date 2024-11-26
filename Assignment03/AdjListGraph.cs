namespace Assignment03;

using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

public class AdjListGraph : IAdjustListGraph
{
    private Dictionary<int, AdjListNode> adjList; 

    public AdjListGraph()
    {
        adjList = new Dictionary<int, AdjListNode>();
    }

    // Adds a node to the graph
    public void AddNode(AdjListNode node)
    {
        adjList[node.Id] = node;
    }

    // Adds an edge from src to dest
    public void AddEdge(int src, int dest)
    {
        if (!adjList.ContainsKey(src) || !adjList.ContainsKey(dest))
        {
            Console.WriteLine("Invalid edge: Either source or destination node does not exist.");
            return;
        }
        adjList[src].AddEdge(dest);
    }

    // Displays the adjacency list of the graph
    public void DisplayAdjlist()
    {
        foreach (var node in adjList)
        {
            Console.Write($"{node.Value.Name} -> ");
            for (int i = 0; i < node.Value.Edges.Count; i++)
            {
                Console.Write($"{node.Value.Name}-{adjList[node.Value.Edges[i]].Name}");
                if (i < node.Value.Edges.Count - 1)
                    Console.Write(" "); // Use space instead of tab between edges
            }
            Console.WriteLine();
        }
    }
}

