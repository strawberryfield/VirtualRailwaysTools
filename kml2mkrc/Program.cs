using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using System.Globalization;
using System.Text;
using Gnu.Getopt;

namespace CasaSoft.vrt
{
    class Program
    {
        const string prgName = "kml2mkrc";
        const string prgVer = "2.0";
        const string prgYears = "2017";

        enum outMode { Text, Markers, Flyto }
        static bool nobanner;

        static void Main(string[] args)
        {
            string outputfile = String.Empty;
            outMode mode = outMode.Text;
            nobanner = false;

            LongOpt[] longopts = new LongOpt[6];
            longopts[0] = new LongOpt("help", Argument.No, null, 'h');
            longopts[1] = new LongOpt("nobanner", Argument.No, null, 1000);
            longopts[2] = new LongOpt("output_file", Argument.Required, new StringBuilder(), 'o');
            longopts[3] = new LongOpt("text", Argument.No, null, 1001);
            longopts[4] = new LongOpt("markers", Argument.No, null, 1002);
            longopts[5] = new LongOpt("flyto", Argument.No, null, 1003);

            Getopt options = new Getopt("kml2mkrc", args, "ho:", longopts);

            int c;
            while ((c = options.getopt()) != -1)
            {
                switch (c)
                {
                    case 'h':
                        PrintHelp();
                        Environment.Exit(0);
                        break;

                    case ':':
                        Console.Error.WriteLine("Doh! You need an argument for option '{0}'", (char)options.getopt());
                        Environment.Exit(1);
                        break;

                    case '?':
                        Console.Error.WriteLine("The option '{0}' is not valid", options.Argv[options.Optind - 1]);
                        Environment.Exit(1);
                        break;

                    case 'o':
                        outputfile = options.Optarg;
                        break;

                    case 1000:
                        nobanner = true;
                        break;

                    case 1001:
                        mode = outMode.Text;
                        break;

                    case 1002:
                        mode = outMode.Markers;
                        break;

                    case 1003:
                        mode = outMode.Flyto;
                        break;
                }
            }

            // checks if inputfile is specified
            if(options.Argv.Length <= options.Optind)
            {
                Console.Error.WriteLine("No input file specified.");
                Environment.Exit(2);
            }

            PrintBanner();

            // Scan for input files
            string ret = string.Empty;
            for (int i = options.Optind; i < options.Argv.Length; i++)
            {
                string inputfile = options.Argv[i];
                if(File.Exists(inputfile))
                {
                    kmlLib kml = new kmlLib(inputfile);
                    ret += kml.DumpPlacemarks();
                }
                else
                {
                    Console.Error.WriteLine("File '{0}' not found: ignoring.", inputfile);
                }
            }

            if(string.IsNullOrEmpty(outputfile))
            {
                Console.WriteLine(ret);
            }
            else
            {
                using (StreamWriter file = new StreamWriter(outputfile))
                {
                        file.WriteLine(ret);
                }
            }
                
        }

        /// <summary>
        /// Prints program banner
        /// </summary>
        static void PrintBanner()
        {
            if (!nobanner)
            {
                Console.Error.WriteLine("CasaSoft {0} v.{1}", prgName, prgVer);
                Console.Error.WriteLine("copyright (c) {0} Roberto Ceccarelli - CasaSoft", prgYears);
            }
        }

        /// <summary>
        /// Prints program usage
        /// </summary>
        static void PrintHelp()
        {
            PrintBanner();
            Console.Error.WriteLine(@"
Usage:
{0} [options] inputfile [-o | --output_file outputfile]
If outputfile is omitted data are written to stdout

Options:
--text      Prints tabular data (default)
--markers   Write a MSTS .mkr file
--flyto     Write data for FlyTo program

--nobanner  Suppress banner

{0} -h | --help
Prints this help.
", prgName);
        }

    }
}

