using System;
using System.Collections.Generic;

namespace Inspect.Framework.Hypermedia
{
    public interface IHypermediaHandler
    {
        void ForAction(string actionName, string relation, Func<Link> link);

        void ForRepresentation<TRepresentation>(string relation, Func<TRepresentation, string> href) where TRepresentation : Representation;

        void ForRepresentation<TRepresentation>(string relation, Func<TRepresentation, Link> link) where TRepresentation : Representation;

        void ForRepresentation<TRepresentation>(Func<TRepresentation, string> href) where TRepresentation : Representation;

        void ForRepresentation<TRepresentation>(Func<TRepresentation, Link> link) where TRepresentation : Representation;

        void ProcessAction(string routeName, Representation representation);

        void ProcessRepresentation(Representation representation);

        void ProcessRepresentation(Representation representation, out OptionsRepresentation optionsRepresentation);

        void ProcessRepresentation(IEnumerable<Representation> collection);
    }
}