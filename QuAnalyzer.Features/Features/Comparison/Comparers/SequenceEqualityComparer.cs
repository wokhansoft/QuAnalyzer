﻿namespace QuAnalyzer.Features.Comparison.Comparers;

public class SequenceEqualityComparer<T> : IEqualityComparer<IEnumerable<T>>
{
    private static readonly IEqualityComparer<T> cmp = new DBNullAwareEqualityComparer<T>();// EqualityComparer<object>.Default;

    private readonly int startFrom;
    private readonly int maxCount;

    public SequenceEqualityComparer(int startFrom = 0, int maxCount = int.MaxValue)
    {
        this.startFrom = startFrom;
        this.maxCount = maxCount;
    }

    public bool Equals(IEnumerable<T>? x, IEnumerable<T>? y)
    {
        if (x is null)
        {
            return y is null;
        }

        if (y is null)
        {
            return x is null;
        }

        if (startFrom != 0 || maxCount != int.MaxValue)
        {
            return x.Skip(startFrom).Take(maxCount).SequenceEqual(y.Skip(startFrom).Take(maxCount), cmp);
        }

        return x.SequenceEqual(y, cmp);
    }

    // Computes an aggregated Hash Code to speed up comparison process.
    // If two hashcodes are different, then it means that the object are different. Calling Equals is only required
    // if two hashcodes are equal (meaning that equality will be checked at a deeper level).
    // To ensure that Equals is always called, you can return 0.
    public int GetHashCode(IEnumerable<T> obj)
    {
        return obj.Skip(startFrom).Take(maxCount).Aggregate(17, (a, i) => a * 23 + (i is null || i is DBNull ? 0 : i.GetHashCode()));
    }
}
