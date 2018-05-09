using System;

namespace Inspect.Framework.Hypermedia
{
    public class DelegateLinkCommand : IHypermediaCommand
    {
        public DelegateLinkCommand(string relation, Func<Link> linkProvider)
        {
            Relation = relation;
            LinkProvider = linkProvider;
        }

        public Func<Link> LinkProvider { get; private set; }

        public string Relation { get; private set; }

        public bool Replace { get; set; }

        public void Execute(Representation representaiton)
        {
            var link = LinkProvider();
            representaiton.Link(Relation, link, Replace);
        }
    }
}