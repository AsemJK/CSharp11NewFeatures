using NewFeatures.AutoDefaults;
using NewFeatures.GenericAttributes;
using NewFeatures.PatternMatching;
using NewFeatures.StringOperations;
using System.Reflection;


[assembly: AssemblyDescription("My Assembly Description")]

Console.WriteLine("Hello, World!");


/*String Interpolation*/

InterpolatedStrings interpolatedStrings = new InterpolatedStrings();
Console.WriteLine(interpolatedStrings.OldStyleOfInterpolation);


var testStruct = new StructExample();
System.Console.WriteLine($"""
Id: {testStruct.Id}
Name: {testStruct.Name}
Active: {testStruct.Active}

""");

/**/


Console.WriteLine("Testing Generic Attributes.");
var methods = typeof(ParametrizedClass).GetMethods();
foreach (var method in methods)
{
    var attribute = method?
    .GetCustomAttributes(false)
    .FirstOrDefault();
    if (attribute != null)
        Console.WriteLine($"""
            Method name: {method?.Name},
            Method attribute: {attribute.GetType()}
        """);
}




CollectionOperations collectionOperations = new CollectionOperations();
CollectionSpanOperations collectionSpanOperations = new CollectionSpanOperations();

Console.WriteLine(collectionOperations.MatchExactSequence);
Console.WriteLine(collectionSpanOperations.MatchWholeSpanWithRang);


/**/
Console.ReadLine();