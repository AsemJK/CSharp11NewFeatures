namespace NewFeatures.PatternMatching
{
    public class CollectionOperations
    {
        private List<int> items = new List<int>
        {
            2,5,6,7,8,9
        };

        public bool MatchExactSequence => items is [2, 5, 6, 7, 8, 9];
        public bool MatchWithDiscard => items is [2, _, _, 7, 8, _];
        public bool MatchWithRang => items is [2, ..];


    }
}
