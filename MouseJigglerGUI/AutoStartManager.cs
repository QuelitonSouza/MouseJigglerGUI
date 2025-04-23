using Microsoft.Win32;

namespace MouseJigglerGUI
{
    public static class AutoStartManager
    {
        const string APP_NAME = "MouseJiggler";

        public static void SetAutoStart(bool enable)
        {
            string exePath = Application.ExecutablePath;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

            if (enable)
                key.SetValue(APP_NAME, "\"" + exePath + "\"");
            else
                key.DeleteValue(APP_NAME, false);
        }

        public static bool IsAutoStartEnabled()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", false);
            var value = key?.GetValue(APP_NAME) as string;
            return value == "\"" + Application.ExecutablePath + "\"";
        }
    }
}
