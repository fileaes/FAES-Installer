using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAES_Installer
{
    public static class Program
    {
        private const string devAppendTag = "DEV210611-1";
        private const string betaAppendTag = "";

        private static bool _verbose = false;
        private static string _updaterPath = null;

        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            for (int i = 0; i < args.Length; i++)
            {
                string strippedArg = args[i].ToLower();
                strippedArg = strippedArg.TrimStart('-', '/', '\\');

                if (strippedArg == "verbose" || strippedArg == "v" || strippedArg == "developer" || strippedArg == "dev" || strippedArg == "debug") _verbose = true;
                else if ((strippedArg == "faesupdater" || strippedArg == "updater") && args.Length > i + 1 && !String.IsNullOrEmpty(args[i + 1])) _updaterPath = args[i + 1];
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Installer());
        }

        public static bool GetVerbose()
        {
            return _verbose;
        }

        public static string GetUpdaterPath()
        {
            return _updaterPath;
        }

        public static bool IsStableBuild()
        {
            return (!IsDevBuild() && !IsBetaBuild());
        }

        public static bool IsBetaBuild()
        {
            return !String.IsNullOrWhiteSpace(betaAppendTag);
        }

        public static bool IsDevBuild()
        {
            return !String.IsNullOrWhiteSpace(devAppendTag);
        }

        public static string GetVersion()
        {
            string[] ver = (typeof(FileAES_Installer.Program).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version).Split('.');
            if (IsDevBuild())
                return "v" + ver[0] + "." + ver[1] + "." + ver[2] + " (" + devAppendTag + ")";
            else if (IsBetaBuild())
                return "v" + ver[0] + "." + ver[1] + "." + ver[2] + " (" + betaAppendTag + ")";
            else
                return "v" + ver[0] + "." + ver[1] + "." + ver[2];
        }
    }
}
