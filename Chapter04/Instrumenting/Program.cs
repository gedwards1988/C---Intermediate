using System.Diagnostics;
using Microsoft.Extensions.Configuration;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            // write to a text file in project folder
            Trace.Listeners.Add(new TextWriterTraceListener(
                File.CreateText(Path.Combine(Environment.GetFolderPath(
                    Environment.SpecialFolder.DesktopDirectory), "log.txt"))));

            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says I am watching!");
            Trace.WriteLine("Trace says I am watching!");

            ConfigurationBuilder builder = new();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",
                optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            TraceSwitch ts = new(
                displayName: "PacktSwitch",
                description: "This swith is set via a json config file");

            configuration.GetSection("PacktSwitch").Bind(ts);

            Trace.WriteLineIf(ts.TraceError, "Trace Error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace Warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace Info");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace Verbose");
        }
    }
}