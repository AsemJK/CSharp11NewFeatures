namespace NewFeatures.PatternMatching
{
    public class CollectionSpanOperations
    {
        private char[] _chars = new char[3]
        {
            'a',
            'b',
            'c'
        };

        private Span<char> GetSpan()
        {
            Span<char> span = _chars;
            return span;
        }

        private ReadOnlySpan<char> GetReadOnlySpan()
        {
            ReadOnlySpan<char> span = _chars;
            return span;
        }

        public bool MatchWholeSpan => GetSpan() is ['a', 'b', 'c'];
        public bool MatchWholeReadOnlySpan => GetReadOnlySpan() is ['a', 'b', 'c'];

        public bool MatchWholeSpanWithRang => GetSpan() is ['a', ..];
    }
}
