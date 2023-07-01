namespace NewFeatures.GenericAttributes
{
    public class ParametrizedClass
    {
        [OldTypeAttribute(typeof(int))]
        public int DoOldStyleJob() => default;

        [NewType<int>]
        public int DoNewStyleJob() => default;
    }
}
