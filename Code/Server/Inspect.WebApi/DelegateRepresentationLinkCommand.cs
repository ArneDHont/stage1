using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.Framework.Hypermedia
{
    public class DelegateRepresentationLinkCommand : IHypermediaCommand
    {
        public string Relation { get; private set; }

        public bool Replace { get; set; }

        public Func<Representation, Link> LinkProvider { get; private set; }

        public DelegateRepresentationLinkCommand(string relation, Func<Representation, Link> linkProvider)
        {
            Relation = relation;
            LinkProvider = linkProvider;
        }

        public void Execute(Representation representaiton)
        {
            var link = LinkProvider(representaiton);
            representaiton.Link(Relation, link, Replace);
        }
    }
}
