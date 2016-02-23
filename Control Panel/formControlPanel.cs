using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Trexis.House
{
    public partial class formControlPanel : Form
    {
        OS os;
        Boolean ismute = false;

        public formControlPanel()
        {
            InitializeComponent();
        }

        private void formControlPanel_Load(object sender, EventArgs e)
        {
            try
            {
                os = new OS(textBoxPassPhrase.Text);
                LogStatus(StatusType.Info, "House listerning, but not activated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load House OS\n" + ex.Message, "House load failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }


        public void LogStatus(StatusType statusType, String statusMessage)
        {
            LogStatus(statusType, statusMessage, null);
        }
        public void LogStatus(StatusType statusType, String statusMessage, String statusDetail)
        {
            ListViewItem listviewitem = new ListViewItem();

            if (statusType == StatusType.Info) listviewitem.ImageIndex = 0;
            if (statusType == StatusType.Announcement) listviewitem.ImageIndex = 1;
            if (statusType == StatusType.Warning) listviewitem.ImageIndex = 2;
            if (statusType == StatusType.Error) listviewitem.ImageIndex = 3;
            
            
            listviewitem.SubItems.Add(statusMessage);
            listStatus.Items.Add(listviewitem);

            if (statusDetail != null)
            {
                ListViewItem listviewdetailitem = new ListViewItem();
                listviewdetailitem.ImageIndex = listviewitem.ImageIndex;
                listviewdetailitem.SubItems.Add(statusDetail);
                listStatus.Items.Add(listviewdetailitem);
                listviewdetailitem.Focused = true;

                if (statusType == StatusType.Error) listviewdetailitem.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                listviewitem.Focused = true;
            }
        }

        private void buttonActivate_Click(object sender, EventArgs e)
        {
            if (this.os.IsActive)
            {
                DeactivateHouse();
            }
            else
            {
                ActivateHouse();
            }
        }


        private void ActivateHouse()
        {
            try
            {
                os.Activate(textBoxPassPhrase.Text);
                buttonActivate.BackgroundImage = Trexis.House.Properties.Resources.onIcon;
                LogStatus(StatusType.Announcement, Phrases.IS_ACTIVATED);
            }
            catch (Exception ex)
            {
                LogStatus(StatusType.Error, "Unable to active house", ex.Message);
            }
        }

        private void DeactivateHouse()
        {
            try
            {
                os.Deactivate();
                buttonActivate.BackgroundImage = Trexis.House.Properties.Resources.offIcon;
                LogStatus(StatusType.Announcement, Phrases.IS_DEACTIVATED);
            }
            catch (Exception ex)
            {
                LogStatus(StatusType.Error, "Unable to deactive house", ex.Message);
            }
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            if (this.os.IsMute)
            {
                UnmuteHouse();
            }
            else
            {
                MuteHouse();
            }
        }

        private void MuteHouse()
        {
            try
            {
                os.Mute();
                buttonMute.BackgroundImage = Trexis.House.Properties.Resources.muteIcon;
                LogStatus(StatusType.Announcement, Phrases.IS_MUTE);
            }
            catch (Exception ex)
            {
                LogStatus(StatusType.Error, "Unable to mute house", ex.Message);
            }
        }

        private void UnmuteHouse()
        {
            try
            {
                os.UnMute();
                buttonMute.BackgroundImage = Trexis.House.Properties.Resources.unmuteIcon;
                LogStatus(StatusType.Announcement, Phrases.IS_UNMUTE);
            }
            catch (Exception ex)
            {
                LogStatus(StatusType.Error, "Unable to unmute house", ex.Message);
            }
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            if (this.os.IsListening)
            {
                StopListenHouse();
            }
            else
            {
                ListenHouse();
            }
        }


        private void ListenHouse()
        {
            try
            {
                os.Listen();
                buttonListen.BackgroundImage = Trexis.House.Properties.Resources.listenIcon;
                LogStatus(StatusType.Announcement, Phrases.IS_LISTEN);
            }
            catch (Exception ex)
            {
                LogStatus(StatusType.Error, "Unable to listen house", ex.Message);
            }
        }

        private void StopListenHouse()
        {
            try
            {
                os.StopListen();
                buttonListen.BackgroundImage = Trexis.House.Properties.Resources.notListenIcon;
                LogStatus(StatusType.Announcement, Phrases.IS_STOP_LISTEN);
            }
            catch (Exception ex)
            {
                LogStatus(StatusType.Error, "Unable to not listen house", ex.Message);
            }
        }

        private void textBoxPassPhrase_TextChanged(object sender, EventArgs e)
        {
            this.os.PassPhrase = textBoxPassPhrase.Text;
        }
    }
}
