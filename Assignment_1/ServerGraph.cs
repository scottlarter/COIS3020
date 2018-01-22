using System;
namespace COIS3020_Assignment_1
{
    public class ServerGraph
    {
        private WebServer[] S;
        private int[,] E; // Edges
        private int NumServers;
        private int MaxNumServers;

        public ServerGraph(int maxNumServers)
        {
                this.MaxNumServers = maxNumServers;
        }

        private int FindServer(string name) { return 0; }
        public void AddServer(string name){}
        public void RemoveServer(string name){}
        public void AddLink(string from, string to){}
        public void RemoveLink(string from, string to){}

        public string[] ArticulationPoints() { return null; } // Toughy

        public bool Connected() { return false; } // Depth-First search

        public int ShortestDistance(string from, string to) { return 0; } // Bredth-First Search
    }
}
