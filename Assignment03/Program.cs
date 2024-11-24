// See https://aka.ms/new-console-template for more information

using Assignment03;

AdjListGraph graph = new AdjListGraph();

for (int i = 0; i < 5; i++)
{
    graph.AddNode(new AdjListNode(i));
}
graph.AddEdge(0,1);
graph.AddEdge(0,4);
graph.AddEdge(1,2);
graph.AddEdge(1,3);
graph.AddEdge(1,4);
graph.AddEdge(2,3);
graph.AddEdge(3,4);

graph.DisplayAdjlist();