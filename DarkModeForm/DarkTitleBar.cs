using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;

namespace DarkModeForm
{
    // TITLE BAR DARK MODE
    public class DarkTitleBar
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        internal static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (IsWindows10OrGreater(17763))
            {
                var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;

                if (IsWindows10OrGreater(18985))
                    attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;

                int useImmersiveDarkMode = enabled ? 1 : 0;

                return DwmSetWindowAttribute(handle, attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }
            return false;
        }

        private static bool IsWindows10OrGreater(int build = -1)
        {
            return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
        }
    }

    // SYSTEM THEME CHECKER
    public class SystemTheme
    {
        public static int Status()
        {
            int stat = -1;

            try { stat = (int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1); }
            catch { return stat; }

            return stat; //  0 : dark theme  / 1 : light theme / -1 : AppsUseLightTheme could not be found
        }
    }
}
