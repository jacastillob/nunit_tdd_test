using System;

using System.Collections.Generic;

namespace algo.src.questions.Graph.AdjacencyList
{
    public class Graph
    {
        //List<List<int>> adjList;
        private List<List<int>> adjList;
        private int edges;
        public Graph(int edges)
        {
            this.edges = edges;
            adjList = new List<List<int>>();
            for (int i = 0; i < this.edges; i++)
            {
                adjList.Add(new List<int>());
            }
        }

        public void addEdge(int source,int destination)
        {

        }
        public void addVertex(int sourceEdge, int destinationEdge)
        {

        }

        public void printGraph()
        {
            adjList.ForEach(p =>
                {
                    p.ForEach(edge =>
                    {
                        Console.WriteLine(edge);
                    });
                });
        }
    }
}
