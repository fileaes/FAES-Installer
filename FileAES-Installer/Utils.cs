using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using Microsoft.Win32;

namespace FileAES_Installer
{
    public class Utils
    {
        public static bool DoInternetCheck()
        {
            try
            {
                Ping myPing = new Ping();
                string host = "api.mullak99.co.uk";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return reply != null && reply.Status == IPStatus.Success;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string[] GetSoftwareFilePaths(out List<string> toolNames)
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\FileAES");

            if (registry != null)
            {
                toolNames = registry.GetSubKeyNames().ToList();
                string[] filePaths = new string[toolNames.Count];

                for (int i = 0; i < toolNames.Count; i++)
                {
                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey($"{"Software\\FileAES"}\\{toolNames[i]}"))
                    {
                        filePaths[i] = key.GetValue("Path").ToString();
                    }
                }
                return filePaths;
            }
            toolNames = null;
            return null;
        }

        public static string ConvertSoftwareNameToFormatted(string toolName)
        {
            switch (toolName.ToUpper())
            {
                case "FAES_GUI":
                    return "FileAES";
                case "FAES_LEGACY":
                    return "FileAES: Legacy";
                case "FAES_CLI":
                    return "FileAES: CLI";
                default:
                    return toolName;
            }
        }

        public static string[] ConvertSoftwareNamesToFormatted(string[] toolNames)
        {
            string[] ret = new string[toolNames.Length];
            for (int i = 0; i < toolNames.Length; i++)
            {
                ret[i] = ConvertSoftwareNameToFormatted(toolNames[i]);
            }
            return ret;
        }
    }
}
