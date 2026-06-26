using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerWatcher
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private enum ActionsToTake : byte
        {
            PutInSleepMode,
            PutInHibernateMode,
            Shutdown,
            ShowAlarmOverlayWithQuickActions
        }

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
    
    }
}
