namespace Assignment03;

public class AdjListNode
{
    public int Id { get; set; }       // Unique identifier for the vertex
    public string Name { get; set; }  // Name of the vertex (e.g., "A", "B", etc.)
    public List<int> Edges { get; set; } // List of adjacent nodes (edges)

    public AdjListNode(int id, string name)
    {
        Id = id;
        Name = name;
        Edges = new List<int>();
    }

    public void AddEdge(int dest)
    {
        Edges.Add(dest);
    }
}



