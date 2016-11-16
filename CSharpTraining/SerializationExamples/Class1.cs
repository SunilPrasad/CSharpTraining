using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


internal static class QuickStart
{
    public static void Main()
    {
        // Create a graph of objects to serialize them to the stream
        var objectGraph = new List<String> { "Jeff", "Kristin", "Aidan", "Grant" };
        Stream stream = SerializeToMemory(objectGraph);
        // Reset everything for this demo
        stream.Position = 0;
        objectGraph = null;
        // Deserialize the objects and prove it worked
        objectGraph = (List<String>)DeserializeFromMemory(stream);
        foreach (var s in objectGraph) Console.WriteLine(s);
    }
    private static MemoryStream SerializeToMemory(Object objectGraph)
    {
        // Construct a stream that is to hold the serialized objects
        MemoryStream stream = new MemoryStream();
        // Construct a serialization formatter that does all the hard work
        BinaryFormatter formatter = new BinaryFormatter();
        // Tell the formatter to serialize the objects into the stream
        formatter.Serialize(stream, objectGraph);
        // Return the stream of serialized objects back to the caller
        return stream;
    }
    private static Object DeserializeFromMemory(Stream stream)
    {
        // Construct a serialization formatter that does all the hard work
        BinaryFormatter formatter = new BinaryFormatter();
        // Tell the formatter to deserialize the objects from the stream
        return formatter.Deserialize(stream);
    }
}
