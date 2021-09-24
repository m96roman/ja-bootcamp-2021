using System;

ValueVsReferenceTypeExamples.ShowExample();
StructureExamples.ShowExample();
NullableExamples.ShowExample();



throw new ArgumentException("Invalid number");

try
{
    Int32.Parse("hmmm");
}
catch (FormatException fe)
{
    Console.WriteLine("Parse failed!");
    throw fe; // Re-throw the caught exception - BAD!!!
}
catch (Exception ex)
{
    Console.WriteLine("Parse failed");
    throw; // Re-throw the caught exception - GOOD!!!
}

