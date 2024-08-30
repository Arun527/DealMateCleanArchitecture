using Common.PredicateBuilder;
using Core.Domain.Aggregates;
using Core.Domain.Filters;
using System.Linq.Expressions;

namespace Core.Domain.PredicateBuilder;

public class VehicleFilterPredicateBuilder : IPredicateBuilder<Vehicle, VehicleFilter>
{
    public Expression<Func<Vehicle, bool>> BuildPredicate(VehicleFilter filter)
    {
        if (filter.IsEmpty())
        {
            return v => true;
        }
        var predicate = FilterExtensions.CreateDefaultPredicate<Vehicle>();
        predicate = FilterExtensions.BuildCombinedPredicate(filter, () => predicate);
        return predicate;
    }
}