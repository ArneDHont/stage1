using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Linq.Expressions;

namespace Inspect.FireSafety.Business.Locations
{
    public class LocationIdArraySpecification : IEntitySpecification<Location>, IEntitySpecification<EquipmentLocation>, IEntitySpecification<Shared.Equipment>
    {
        public LocationIdArraySpecification(params int[] id)
        {
            LocationId = id ?? new int[] { };
        }

        public int[] LocationId { get; private set; }

        public Expression<Func<Location, bool>> ToExpression()
        {
            var specification = EntitySpecification.Default<Location>(LocationId.Length == 0);
            foreach (var locationId in LocationId)
            {
                specification = specification.Or(new LocationIdSpecification(locationId));
            }
            return specification.ToExpression();
        }

        Expression<Func<EquipmentLocation, bool>> IEntitySpecification<EquipmentLocation>.ToExpression()
        {
            var specification = EntitySpecification.Default<EquipmentLocation>(LocationId.Length == 0);
            foreach (var locationId in LocationId)
            {
                specification = specification.Or(new LocationIdSpecification(locationId));
            }
            return specification.ToExpression();
        }

        Expression<Func<Shared.Equipment, bool>> IEntitySpecification<Shared.Equipment>.ToExpression()
        {
            var specification = EntitySpecification.Default<Shared.Equipment>(LocationId.Length == 0);
            foreach (var locationId in LocationId)
            {
                specification = specification.Or(new LocationIdSpecification(locationId));
            }
            return specification.ToExpression();
        }
    }

    public class LocationIdSpecification : IEntitySpecification<Location>, IEntitySpecification<EquipmentLocation>, IEntitySpecification<Shared.Equipment>
    {
        public LocationIdSpecification(int id)
        {
            LocationId = id;
        }

        public int LocationId { get; private set; }

        public Expression<Func<Location, bool>> ToExpression()
        {
            return x => x.LocationId == LocationId;
        }

        Expression<Func<EquipmentLocation, bool>> IEntitySpecification<EquipmentLocation>.ToExpression()
        {
            return x => x.LocationId == LocationId;
        }

        Expression<Func<Shared.Equipment, bool>> IEntitySpecification<Shared.Equipment>.ToExpression()
        {
            return x => x.EquipmentLocation.LocationId == LocationId;
        }
    }
}