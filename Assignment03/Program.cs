// See https://aka.ms/new-console-template for more information

using Assignment03;

AdjListGraph graph = new AdjListGraph();

// Create nodes (vertices)
AdjListNode A = new AdjListNode(0, "A");
AdjListNode B = new AdjListNode(1, "B");
AdjListNode C = new AdjListNode(2, "C");
AdjListNode D = new AdjListNode(3, "D");
AdjListNode E = new AdjListNode(4, "E");
AdjListNode F = new AdjListNode(5, "F");
AdjListNode G = new AdjListNode(6, "G");
AdjListNode H = new AdjListNode(7, "H");
AdjListNode I = new AdjListNode(8, "I");

// Add nodes to the graph
graph.AddNode(A);
graph.AddNode(B);
graph.AddNode(C);
graph.AddNode(D);
graph.AddNode(E);
graph.AddNode(F);
graph.AddNode(G);
graph.AddNode(H);
graph.AddNode(I);

// Add edges to the graph
graph.AddEdge(0, 3); // A -> D
graph.AddEdge(0, 4); // A -> E
graph.AddEdge(0, 1); // A -> B
graph.AddEdge(1, 4); // B -> E
graph.AddEdge(2, 1); // C -> B
graph.AddEdge(3, 6); // D -> G
graph.AddEdge(4, 5); // E -> F
graph.AddEdge(4, 7); // E -> H
graph.AddEdge(5, 2); // F -> C
graph.AddEdge(5, 7); // F -> H
graph.AddEdge(6, 7); // G -> H
graph.AddEdge(7, 8); // H -> I
graph.AddEdge(8, 5); // I -> F

// Display the adjacency list
graph.DisplayAdjlist();