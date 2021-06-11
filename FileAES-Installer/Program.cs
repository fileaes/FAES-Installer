using System;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace FileAES_Installer
{
    public static class Program
    {
        private const string devAppendTag = "DEV210611-1";
        private const string betaAppendTag = "";

        private static bool _verbose;
        private static string _updaterPath;
        private static bool _useLegacyInstaller;
        private static string _updaterBranch = "stable";

        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            for (int i = 0; i < args.Length; i++)
            {
                string strippedArg = args[i].ToLower();
                strippedArg = strippedArg.TrimStart('-', '/', '\\');

                if (strippedArg == "verbose" || strippedArg == "v" ||strippedArg == "debug") _verbose = true;
                else if ((strippedArg == "faesupdater" || strippedArg == "updater") && args.Length > i + 1 && !String.IsNullOrEmpty(args[i + 1])) _updaterPath = args[i + 1];
                else if ((strippedArg == "updaterbranch" || strippedArg == "branch") && args.Length > i + 1 && !String.IsNullOrEmpty(args[i + 1])) _updaterBranch = args[i + 1];
                else if (strippedArg == "legacyinstaller" || strippedArg == "legacy") _useLegacyInstaller = true;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (_useLegacyInstaller)
                Application.Run(new LegacyInstaller());
            else
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

        public static string GetUpdaterBranch()
        {
            switch (_updaterBranch.ToUpper())
            {
                case "BETA":
                case "B":
                    return "beta";
                case "DEVELOPER":
                case "DEV":
                case "D":
                    return "dev";
                default:
                    return "stable";
            }
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
            string[] ver = (typeof(Program).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version).Split('.');
            if (IsDevBuild())
                return "v" + ver[0] + "." + ver[1] + "." + ver[2] + " (" + devAppendTag + ")";
            else if (IsBetaBuild())
                return "v" + ver[0] + "." + ver[1] + "." + ver[2] + " (" + betaAppendTag + ")";
            else
                return "v" + ver[0] + "." + ver[1] + "." + ver[2];
        }
    }
}
