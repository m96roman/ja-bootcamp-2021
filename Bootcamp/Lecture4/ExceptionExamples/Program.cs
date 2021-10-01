using ExceptionExamples.MultipleExceptions;
using ExceptionExamples.SimpleException;
using System;

//SimpleExceptionExample.ShowExample();
//MultipleExceptionExample.ShowExample();



try
{
    FirstLevelTest();
    TestCupExample();
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    Console.WriteLine(ex.GetType());
}


void FirstLevelTest()
{
    try
    {
        var test = 8;
        var hmmmm = 88;
    
        int.Parse(Console.ReadLine());
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex);
        throw; // throw ex;
    }
    finally
    {
        Console.WriteLine($"after catch in {nameof(FirstLevelTest)}");
    }


}


bool LogOnlyFormatMessge(FormatException ex)
{
    Console.WriteLine(ex);

    return true;
}

void TestCupExample()
{
    var cup = new Cup();

    while (true)
    {
        cup.FillTheCupBy(1);
    }
}

class Cup
{
    const int MaxAllowedVolume = 8;

    public int Volume { get; set; }

    public void FillTheCupBy(int someTeaLevel)
    {
        Volume += someTeaLevel;

        if (Volume > MaxAllowedVolume)
        {
            throw new CupOverflowException("Please stop filling tea")
            {
                WhySo = "Cup has a finite volume",
            };
        }
    }
}

class CupOverflowException : Exception
{
    public string WhySo { get; set; }

    public CupOverflowException(string message) : base(message)
    {
    }

    public CupOverflowException(string message, Exception innerException) : base(message, innerException)
    {
    }
}