using System;
using System.Reflection;
using System.Diagnostics;
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
        static string prgName;
        const string prgVer = "2.0";
        static Assembly assembly;
        static ICatalog catalog;

        static bool nobanner;

        static void Main(string[] args)
        {
            // Get infos from assembly
            assembly = Assembly.GetExecutingAssembly();
            prgName = assembly.GetName().Name;

            // locales management
            string locale = ConfigurationManager.AppSettings["locale"];

            if(string.IsNullOrWhiteSpace(locale)) 
                catalog = new Catalog(prgName, "./locale");
            else
                catalog = new Catalog(prgName, "./locale", new CultureInfo(locale));

            // status vars
            string outputfile = String.Empty;
            outMode mode = outMode.Text;
            nobanner = false;

            // GNU Getopt options
            LongOpt[] longopts = new LongOpt[6];
            longopts[0] = new LongOpt("help", Argument.No, null, 'h');
            longopts[1] = new LongOpt("nobanner", Argument.No, null, 1000);
            longopts[2] = new LongOpt("output_file", Argument.Required, new StringBuilder(), 'o');
            longopts[3] = new LongOpt("text", Argument.No, null, 1001);
            longopts[4] = new LongOpt("markers", Argument.No, null, 1002);
            longopts[5] = new LongOpt("flyto", Argument.No, null, 1003);

            Getopt options = new Getopt(prgName, args, "ho:", longopts);

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
            Converter conv = new Converter(mode);
            string ret = conv.fileHead();            

            for (int i = options.Optind; i < options.Argv.Length; i++)
            {
                string inputfile = options.Argv[i];
                if(File.Exists(inputfile))
                {
                    ret += conv.fileBody(inputfile);
                }
                else
                {
                    Console.Error.WriteLine(catalog.GetString("File '{0}' not found: ignoring.", inputfile));
                }
            }

            conv.fileOut(ret, outputfile);
        }

        /// <summary>
        /// Prints program banner
        /// </summary>
        static void PrintBanner()
        {
            if (!nobanner)
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
                Console.Error.WriteLine("CasaSoft {0} v.{1}", prgName, prgVer);
                Console.Error.WriteLine(versionInfo.LegalCopyright);
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

