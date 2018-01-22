using System;
namespace COIS3020_Assignment_1
{
    public class Internet
    {
        private WebGraph W;
        private ServerGraph S;

        public Internet(){}

        public void AddServer(string name){}
        public void RemoveServer(string name){}
        public void AddServerLink(string from, string to){}
        public void AddWebPage(string name, string host){}
        public void RemoveWebPage(string name){}
        public void AddWebLink(string from, string to){}
        public string[] ArticulationPoints() { return null; }
        public bool Connected() { return false; }
        public float AvgShortestDistance(string name) { return 0.0f; }
    }
}
