using System;
namespace COIS3020_Assignment_1
{
    public class WebPage
    {
        private string Name;
        private string Server;
        private List<WebPage> E; // edges
        private bool visited;

        public WebPage(string name, string host){
            this.Name = name;
            this.Server = host;
        }

        public int FindLink(string name) { return 0; }
    }
}
