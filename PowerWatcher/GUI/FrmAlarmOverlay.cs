using Microsoft.Win32;
using PowerWatcher.Properties;
using System.Media;
using System.Windows.Forms;
using PowerWatcher.Core;

namespace PowerWatcher.GUI
{
    public partial class FrmAlarmOverlay : Form
    {
        private readonly SoundPlayer AlarmSound = new SoundPlayer(Resources.ACUnplugedSoundEffect);

        public FrmAlarmOverlay()
        {
            InitializeComponent();
            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
        }

        private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            if (e.Mode == PowerModes.StatusChange)
            {
                if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online)
                    this.Close();
            }
        }

        private void FrmAlarmOverlay_Load(object sender, System.EventArgs e)
        {
            AlarmSound.PlayLooping();
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void FrmAlarmOverlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            AlarmSound.Stop();
        }

        private void BtnSleep_Click(object sender, System.EventArgs e)
        {
            if (!Actions.TryPutLaptopInSleepMode())
            {
                MessageBox.Show("Hmm...\nSeems like your system does not support Sleep Mode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
        }

        private void BtnHibernate_Click(object sender, System.EventArgs e)
        {
            if (!Actions.TryPutLaptopInHibernateMode())
            {
                MessageBox.Show("Hmm...\nSeems like your system does not support Hibernate Mode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
        }

        private void BtnShutdown_Click(object sender, System.EventArgs e)
        {
            Actions.ShutdownLaptop();
        }
    }
}
