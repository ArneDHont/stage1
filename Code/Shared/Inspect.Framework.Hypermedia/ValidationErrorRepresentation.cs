namespace Inspect.Framework.Hypermedia
{
    public class ValidationErrorRepresentation : Representation
    {
        public string Path { get; set; }

        public string[] Messages { get; set; }
    }
}