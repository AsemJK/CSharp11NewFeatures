namespace NewFeatures.GenericAttributes
{
    public class ParametrizedClass
    {
        [OldTypeAttribute(typeof(int))]
        public int DoOldStyleJob { get; set; }

        [NewType<int>]
        public int DoNewStyleJob { get; set; }
    }
}
