using Inspect.Framework.Hypermedia;
using System.Collections.Generic;

namespace AutoMapper
{
    public static class AutoMapperExtensions
    {
        public static IMappingExpression<TSource, TDestination> CreateHypermediaMap<TSource, TDestination>(this Profile profile)
        {
            return profile.CreateMap<TSource, TDestination>().SupportHypermedia();
        }

        public static TDestination MapWithHypermedia<TDestination>(this IMapper mapper, object source, IHypermediaHandler hypermediaHandler)
        {
            return mapper.Map<TDestination>(source, (o) => o.Items.Add(nameof(IHypermediaHandler), hypermediaHandler));
        }

        public static IMappingExpression<TSource, TDestination> SupportHypermedia<TSource, TDestination>(this IMappingExpression<TSource, TDestination> instance)
        {
            instance.AfterMap((src, dst, res) =>
            {
                if (res.Items.ContainsKey(nameof(IHypermediaHandler)))
                {
                    if (res.Items[nameof(IHypermediaHandler)] is IHypermediaHandler handler)
                    {
                        if (dst is Representation)
                        {
                            handler.ProcessRepresentation(dst as Representation);
                        }
                        else if (dst is IEnumerable<Representation>)
                        {
                            handler.ProcessRepresentation(dst as IEnumerable<Representation>);
                        }
                    }
                }
            });
            return instance;
        }
    }
}