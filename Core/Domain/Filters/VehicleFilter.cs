using Common.Pagination;
using Common.Query.Matchers;

namespace Core.Domain.Filters;

public class VehicleFilter
{
    public IEnumerable<IntMatch> LoadNo { get; set; } = Enumerable.Empty<IntMatch>();
    public IEnumerable<StringMatch> FrameNo { get; set; } = Enumerable.Empty<StringMatch>();
    public BoolMatch SG { get; set; } = new BoolMatch(BoolMatch.MatchType.Unspecified);
    public BoolMatch Mirror { get; set; } = new BoolMatch(BoolMatch.MatchType.Unspecified);
    public BoolMatch Tools { get; set; } = new BoolMatch(BoolMatch.MatchType.Unspecified);
    public BoolMatch ManualBook { get; set; } = new BoolMatch(BoolMatch.MatchType.Unspecified);
    public IEnumerable<IntMatch> Key { get; set; } = Enumerable.Empty<IntMatch>();
    public IEnumerable<DoubleMatch> Mileage { get; set; } = Enumerable.Empty<DoubleMatch>();
    public IEnumerable<StringMatch> FuelType { get; set; } = Enumerable.Empty<StringMatch>();
    public IEnumerable<DateTimeMatch> ManufactureDate { get; set; } = Enumerable.Empty<DateTimeMatch>();
    public IEnumerable<TimeSpanMatch> Active { get; set; } = Enumerable.Empty<TimeSpanMatch>();
    public Pagination? Pagination { get; set; } = new();
}
