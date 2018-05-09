namespace Inspect.Framework.Hypermedia
{
    public class ConstantLinkCommand : IHypermediaCommand
    {
        public string Relation { get; private set; }

        public bool Replace { get; set; }

        public Link Link { get; private set; }

        public ConstantLinkCommand(string relation, Link link)
        {
            Relation = relation;
            Link = link;
        }

        public void Execute(Representation representaiton)
        {
            representaiton.Link(Relation, Link, Replace);
        }
    }
}