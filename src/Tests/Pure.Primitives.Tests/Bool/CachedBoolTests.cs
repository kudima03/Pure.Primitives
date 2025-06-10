using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Bool;

namespace Pure.Primitives.Tests.Bool;

public sealed record CachedBoolTests
{
    [Fact]
    public void CacheCorrectly()
    {
        BoolWithEvaluationCount underlyingValue = new BoolWithEvaluationCount(true);
        IBool cachedValue = new CachedBool(underlyingValue);
        _ = Enumerable.Range(0, 100).All(_ => cachedValue.BoolValue);

        Assert.Equal(1, underlyingValue.EvaluationCount);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new CachedBool(new True()).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new CachedBool(new False()).ToString());
    }

    private sealed record BoolWithEvaluationCount : IBool
    {
        private readonly bool _boolValue;

        public BoolWithEvaluationCount(bool boolValue)
        {
            _boolValue = boolValue;
        }

        public int EvaluationCount { get; private set; }

        public bool BoolValue
        {
            get
            {
                EvaluationCount++;
                return _boolValue;
            }
        }
    }
}