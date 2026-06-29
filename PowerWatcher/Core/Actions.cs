using System.Diagnostics;
using System.Windows.Forms;

namespace PowerWatcher.Core
{
    public class Actions
    {
        public static bool TryPutLaptopInHibernateMode()
        {
            return Application.SetSuspendState(PowerState.Hibernate, false, true);
        }

        public static bool TryPutLaptopInSleepMode()
        {
            return Application.SetSuspendState(PowerState.Suspend, false, true);
        }

        public static void ShutdownLaptop()
        {
            Process.Start("shutdown", "/s /f /t 0");
        }

    }
}
