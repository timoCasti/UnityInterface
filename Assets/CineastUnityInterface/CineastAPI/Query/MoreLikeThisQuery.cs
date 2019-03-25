using System;
// More like this 
namespace CineastUnityInterface.CineastAPI.Query
{
    public class MoreLikeThisQuery
    {
        public string[] types = new[] {"ID"};

        public TermContainer[] containers;

        public MoreLikeThisQuery(TermContainer[] containers)
        {
            this.containers = containers;
        }

}
}

