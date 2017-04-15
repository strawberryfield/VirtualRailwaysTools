using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using System.Globalization;
using System.Text;
using Gnu.Getopt;
using NGettext;

namespace CasaSoft.vrt
{
    class Program
    {
        const string prgName = "kml2mkrc";
        const string prgVer = "2.0";
        const string prgYears = "2017";

        static ICatalog catalog;

        enum outMode { Text, Markers, Flyto }
        static bool nobanner;

        static void Main(string[] args)
        {
            catalog = new Catalog(prgName, "./locale");

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
                        Console.Error.WriteLine(catalog.GetString("Doh! You need an argument for option '{0}'", (char)options.getopt()));
                        Environment.Exit(1);
                        break;

                    case '?':
                        Console.Error.WriteLine(catalog.GetString("The option '{0}' is not valid", options.Argv[options.Optind - 1]));
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
                Console.Error.WriteLine(catalog.GetString("No input file specified."));
                Environment.Exit(2);
            }

            PrintBanner();

            // Scan for input files
            string ret;
            switch (mode)
            {
                case outMode.Text:
                    ret = string.Empty;
                    break;
                case outMode.Markers:
                    ret = "SIMISA@@@@@@@@@@JINX0I0t______\n\n";
                    break;
                case outMode.Flyto:
                    ret = "\"MSTSFlyTo 2.0\"\n";
                    break;
                default:
                    ret = string.Empty;
                    break;
            }

            for (int i = options.Optind; i < options.Argv.Length; i++)
            {
                string inputfile = options.Argv[i];
                if(File.Exists(inputfile))
                {
                    kmlLib kml = new kmlLib(inputfile);
                    switch (mode)
                    {
                        case outMode.Text:
                            ret += kml.TextPlacemarks();
                            ret += kml.TextPaths();
                            ret += kml.TextPolys();
                            break;
                        case outMode.Markers:
                            ret += kml.MkrPlacemarks();
                            ret += kml.MkrPaths();
                            ret += kml.MkrPolys();
                            break;
                        case outMode.Flyto:
                            ret += kml.FlyToPlacemarks();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.Error.WriteLine(catalog.GetString("File '{0}' not found: ignoring.", inputfile));
                }
            }

            if(string.IsNullOrEmpty(outputfile))
            {
                Console.WriteLine(ret);
            }
            else
            {
                if (mode == outMode.Markers)
                {
                    using (StreamWriter file = new StreamWriter(outputfile, false, Encoding.Unicode))
                    {
                        file.WriteLine(ret);
                    }
                }
                else
                {
                    using (StreamWriter file = new StreamWriter(outputfile))
                    {
                        file.WriteLine(ret);
                    }
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
            Console.Error.WriteLine(catalog.GetString("\nUsage:"));
            Console.Error.WriteLine(catalog.GetString("{0} [options] inputfile [-o | --output_file outputfile]", prgName));
            Console.Error.WriteLine(catalog.GetString("\nIf outputfile is omitted data are written to stdout"));
            Console.Error.WriteLine(catalog.GetString("\nOptions:"));
            Console.Error.WriteLine(catalog.GetString("--text      Prints tabular data (default)"));
            Console.Error.WriteLine(catalog.GetString("--markers   Write a MSTS .mkr file"));
            Console.Error.WriteLine(catalog.GetString("--flyto     Write data for FlyTo program"));
            Console.Error.WriteLine(catalog.GetString("\n--nobanner  Suppress banner"));
            Console.Error.WriteLine(catalog.GetString("\n{0} -h | --help", prgName));
            Console.Error.WriteLine(catalog.GetString("Prints this help."));
        }

    }
}

