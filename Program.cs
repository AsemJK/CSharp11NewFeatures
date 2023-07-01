// See https://aka.ms/new-console-template for more information
using NewFeatures.AutoDefaults;

Console.WriteLine("Hello, World!");

var testStruct = new StructExample();
System.Console.WriteLine($"""
Id: {testStruct.Id}
Name: {testStruct.Name}
Active: {testStruct.Active}

""");