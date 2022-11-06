using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using static System.Environment;

namespace DarkModeForm
{
    #region TITLE BAR DARK MODE
    public class DarkTitleBar
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int PRE_20H1  = 19;   // DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1
        private const int POST_20H1 = 20;   // DWMWA_USE_IMMERSIVE_DARK_MODE

        internal static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (OSVersion.Version.Major >= 10 && OSVersion.Version.Build >= 17763)
            {
                var     attribute = OSVersion.Version.Build >= 18985 ? POST_20H1 : PRE_20H1;
                int     useImmersiveDarkMode = enabled ? 1 : 0;
                return  DwmSetWindowAttribute(handle, attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }
            return false;
        }
    }
    #endregion
    //
    #region SYSTEM THEME STATUS
    public class SystemTheme
    {
        public static int Status()  //  0 : dark theme  / 1 : light theme / -1 : AppsUseLightTheme could not be found
        {
            string  keyName = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            try     {return (int)Registry.GetValue(keyName, "AppsUseLightTheme", -1);}
            catch   {return -1;}   
        }
    }
    #endregion
    //
}
