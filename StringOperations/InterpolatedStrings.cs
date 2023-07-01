namespace NewFeatures.StringOperations
{
    public class InterpolatedStrings
    {
        List<(string, int)> employees = new List<(string, int)>
        {

            ("Asem",2036),
            ("Ali",2020),
            ("Hazem",1366),

        };//list of tuples
        public string OldStyleOfInterpolation => $"The No. of Asem Is: {employees.Where(a => a.Item1 == "Asem").Select(v => v.Item2).FirstOrDefault()}";
    }
}
