using Microsoft.Win32;
using System.Windows.Forms;

namespace PowerWatcher.Core
{
    public class WindowsHelpers
    {
        private static readonly string AppName = "PowerWatcher";
        private static readonly string AppPath = Application.ExecutablePath;

        public static bool ChangeAppStartupWhenUserLoggesIn(bool Enable)
        {
            RegistryKey RunKey = Registry.CurrentUser.OpenSubKey(
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",
                true);

            if (RunKey == null) return false;

            try
            {
                if (Enable)
                    RunKey.SetValue(AppName, $"\"{AppPath}\"");
                else
                    RunKey.DeleteValue(AppName, false);

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                RunKey.Close();
            }

        }

        public static bool IsAppStartupWhenUserLoggesInEnabled()
        {
            RegistryKey RunKey = Registry.CurrentUser.OpenSubKey(
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",
                false);

            if (RunKey == null) return false;

            try
            {
                object AppRecordValue = RunKey.GetValue(AppName);

                if (AppRecordValue == null || !AppRecordValue.Equals(AppPath))
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                RunKey.Close();
            }
        }
    }
}
