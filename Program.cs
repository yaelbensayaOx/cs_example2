using System;
using System.Diagnostics;
using System.Web;

namespace CommandInjectionExample1
{
    class Program
    {
        static readonly string[] allowedCommands = { "notepad.exe", "calc.exe", "mspaint.exe" };

        static void Main(string[] args)
        {
            // Simulating web request input
            string userCommand = Request.QueryString["cmd"]; // Source: Request.QueryString

            if (Array.Exists(allowedCommands, element => element == userCommand))
            {
                Process.Start(userCommand); // Sink: Process.Start()
            }
        }
    }
}