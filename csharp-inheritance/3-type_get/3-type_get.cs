using System;
using System.Reflection;

/// <summary>
/// Class for object reflection
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of available properties and methods of an object
    /// </summary>
    /// <param name="myObj">The object to inspect</param>
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();
        
        Console.WriteLine($"{type.Name} Properties:");
        foreach (PropertyInfo prop in type.GetProperties())
            Console.WriteLine(prop.Name);
        
        Console.WriteLine($"{type.Name} Methods:");
        foreach (MethodInfo method in type.GetMethods())
            Console.WriteLine(method.Name);
    }
}