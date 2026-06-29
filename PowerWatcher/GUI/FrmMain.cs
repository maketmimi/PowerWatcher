using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;
using PowerWatcher.Core;
using System.Media;
using System.Resources;
using PowerWatcher.Properties;

namespace PowerWatcher.GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
        }

        private void ShowAlarmOverlay()
        {
            new FrmAlarmOverlay().ShowDialog();
        }

        private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            if (!ChkActivateStop.Checked || e.Mode != PowerModes.StatusChange)
                return;

            if (SystemInformation.PowerStatus.PowerLineStatus != PowerLineStatus.Offline)
                return;

            new SoundPlayer(Resources.ACUnplugedSoundEffect).Play();

            switch (_SelectedActionToTake)
            {
                case ActionToTake.ShowAlarmOverlayWithQuickActions:
                    ShowAlarmOverlay();
                    break;
                case ActionToTake.PutInHibernateMode:
                    if (!Actions.TryPutLaptopInHibernateMode())
                        ShowAlarmOverlay();
                    break;
                case ActionToTake.PutInSleepMode:
                    if (!Actions.TryPutLaptopInSleepMode())
                        ShowAlarmOverlay();
                    break;
                case ActionToTake.Shutdown:
                    Actions.ShutdownLaptop();
                    break;
                default:
                    ShowAlarmOverlay();
                    break;
            }
        }

        private enum ActionToTake : byte
        {
            ShowAlarmOverlayWithQuickActions,
            PutInHibernateMode,
            PutInSleepMode,
            Shutdown
        }

        private ActionToTake _SelectedActionToTake = ActionToTake.ShowAlarmOverlayWithQuickActions; 

        private void UpdateActivateStopCheckBox()
        {
            Color ColorToSet =
                ChkActivateStop.Checked ?
                Color.FromArgb(0, 192, 0) :
                Color.FromArgb(192, 0, 0);

            ChkActivateStop.BackColor = ColorToSet;
            ChkActivateStop.FlatAppearance.MouseDownBackColor = ColorToSet;
            ChkActivateStop.FlatAppearance.MouseOverBackColor = ColorToSet;

            ChkActivateStop.Text =
                ChkActivateStop.Checked ?
                "Active" : "Stopped";

        }

        private void LibMalekGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/maketmimi/PowerWatcher");
            LibMalekGithub.LinkVisited = true;
        }

        private void ChkActivateStop_CheckedChanged(object sender, EventArgs e)
        {
            UpdateActivateStopCheckBox();
        }

        private void NiMain_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void BtnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CbActionToTake_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedActionToTake = (ActionToTake)CbActionToTake.SelectedIndex;

            Settings.Default.ActionToTake = (byte) _SelectedActionToTake;
            Settings.Default.Save();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Enum.IsDefined(typeof(ActionToTake), Settings.Default.ActionToTake))
                CbActionToTake.SelectedIndex = Settings.Default.ActionToTake;
            else
                CbActionToTake.SelectedIndex = 0;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
