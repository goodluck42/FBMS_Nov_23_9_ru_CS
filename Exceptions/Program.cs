using System;

while (true)
{
    try
    {
        var result = int.Parse(Console.ReadLine()!); // <----

        Console.WriteLine(result * 2);
        
        // throw new PropertyNotInitializedException("Age is not initialized");
        break;
    }
    catch (Exception ex) when (ex is FormatException
                                   or OverflowException)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Finally!");
    }
    
    // catch (FormatException ex)
    // {
    //     Console.WriteLine(ex.Message);
    // }
    // catch (OverflowException ex)
    // {
    //     Console.WriteLine(ex.Message);
    // }
}

using var file = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.Read);


Console.Read();

class PropertyNotInitializedException : Exception
{
    public PropertyNotInitializedException(string message) : base(message)
    {
        
    }
}


// class PropertyNotInitializedException2(string message) : Exception(message);
