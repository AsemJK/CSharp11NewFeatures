namespace NewFeatures.GenericAttributes
{
    public class OldTypeAttribute
    {
        public OldTypeAttribute(Type attributeType)
        {
            AttributeType = attributeType;
        }
        public Type AttributeType { get; set; }
    }
}