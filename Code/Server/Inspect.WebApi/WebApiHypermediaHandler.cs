using System;
using System.Collections.Generic;

namespace Inspect.Framework.Hypermedia
{
    public class WebApiHypermediaHandler : IHypermediaHandler
    {
        private IDictionary<string, IList<IHypermediaCommand>> mActionCommands = new Dictionary<string, IList<IHypermediaCommand>>();

        private IDictionary<Type, IList<IHypermediaCommand>> mRepresentationCommands = new Dictionary<Type, IList<IHypermediaCommand>>();

        public void ForAction(string actionName, string relation, Func<Link> link)
        {
            if (!mActionCommands.ContainsKey(actionName))
            {
                mActionCommands[actionName] = new List<IHypermediaCommand>();
            }
            mActionCommands[actionName].Add(new DelegateLinkCommand(relation, link));
        }

        public void ForAction(string actionName, string relation, Func<string> href)
        {
            if (!mActionCommands.ContainsKey(actionName))
            {
                mActionCommands[actionName] = new List<IHypermediaCommand>();
            }
            mActionCommands[actionName].Add(new DelegateLinkCommand(relation, () => new Link(href())));
        }

        public void ForRepresentation<TRepresentation>(string relation, Func<TRepresentation, string> href) where TRepresentation : Representation
        {
            this.ForRepresentation<TRepresentation>(relation, x => new Link(href(x)));
        }

        public void ForRepresentation<TRepresentation>(string relation, Func<TRepresentation, Link> link) where TRepresentation : Representation
        {
            var representationType = typeof(TRepresentation);
            if (!mRepresentationCommands.ContainsKey(representationType))
            {
                mRepresentationCommands[representationType] = new List<IHypermediaCommand>();
            }
            mRepresentationCommands[representationType].Add(new DelegateRepresentationLinkCommand(relation, x => link((TRepresentation)x)));
        }

        public void ForRepresentation<TRepresentation>(Func<TRepresentation, Link> link) where TRepresentation : Representation
        {
            ForRepresentation(nameof(LinkCollection.Self), link);
        }

        public void ForRepresentation<TRepresentation>(Func<TRepresentation, string> href) where TRepresentation : Representation
        {
            ForRepresentation(nameof(LinkCollection.Self), href);
        }

        public void ProcessAction(string actionName, Representation representation)
        {
            if (mActionCommands.ContainsKey(actionName))
            {
                IList<IHypermediaCommand> commandsForType = mActionCommands[actionName];
                foreach (var command in commandsForType)
                {
                    command.Execute(representation);
                }
            }
        }

        public void ProcessRepresentation(Representation representation)
        {
            Type representationType = representation.GetType();
            if (mRepresentationCommands.ContainsKey(representationType))
            {
                IList<IHypermediaCommand> commandsForType = mRepresentationCommands[representation.GetType()];
                foreach (var command in commandsForType)
                {
                    command.Execute(representation);
                }
            }
        }

        public void ProcessRepresentation(Representation representation, out OptionsRepresentation optionsRepresentation)
        {
            ProcessRepresentation(representation);
            optionsRepresentation = new OptionsRepresentation(representation);
        }

        public void ProcessRepresentation(IEnumerable<Representation> collection)
        {
            foreach (var representation in collection)
            {
                ProcessRepresentation(representation);
            }
        }
    }
}