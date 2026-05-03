using System;
using System.Diagnostics;
using System.Web;

namespace CommandInjectionExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulating web request input
            string userCommand = Request.QueryString["cmd"]; // Source: Request.QueryString

            // Vulnerable: Directly passing user input to Process.Start
            Process.Start(userCommand); // Sink: Process.Start()
        }
    }
}
