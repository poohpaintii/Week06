using System;
using System.Net;  // for web client
using System.IO;   // for stream writer

class Program
{
    static void Main()
    {
        // Create web client.
        WebClient client = new WebClient();
        // Download string.
        string value = client.DownloadString("http://www.kmitl.ac.th");
        // Write values.
        Console.WriteLine("--- WebClient result ---");
        Console.WriteLine(value.Length);
        Console.WriteLine(value);
        StreamWriter outtxt = new StreamWriter("webload.html");
        outtxt.Write(value);
        outtxt.Dispose();
    }
}
