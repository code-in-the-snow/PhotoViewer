using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using Microsoft.Win32;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Viewer
{
    public partial class frmViewer : Form
    {
       const bool cPromptOnExit = false;
       string mUserName;
       bool mPromptOnExit;
       Color mPictureBackColor;

       private void OpenPicture()
        {
            try
            {
                // Show the open file dialog box.
                if (ofdSelectPicture.ShowDialog() == DialogResult.OK)
                {
                    // Load the picture.
                    picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName);
                    // Show the name of the file in form caption.
                    this.Text = string.Concat("Picture Viewer (" +
                         ofdSelectPicture.FileName + ")");

                    // Show the name of the file in the status bar.
                    sbrStatusStrip.Items[0].Text = ofdSelectPicture.FileName;

                    UpdateLog(ofdSelectPicture.FileName);
                }
            }
           catch (System.OutOfMemoryException)
            {
                MessageBox.Show("The file you selected is not an image file.",
                    "Invalid file", MessageBoxButtons.OK);
            }
        }

        private void GetFileAttributes()
       {
           // Make sure file is open.
           if ((ofdSelectPicture.FileName) == "")
           {
               MessageBox.Show("There is no file open.");
               return;
           }

           // Create the string builder object to concatenate strings.
           System.Text.StringBuilder stbProperties = new System.Text.StringBuilder("");
           System.IO.FileAttributes fileAttributes;

           // Get the dates.
           stbProperties.Append("Created: ");
           stbProperties.Append(System.IO.File.GetCreationTime(ofdSelectPicture.FileName));
           stbProperties.Append("\r\n");

           stbProperties.Append("Accessed: ");
           stbProperties.Append(System.IO.File.GetLastAccessTime(ofdSelectPicture.FileName));
           stbProperties.Append("\r\n");

           stbProperties.Append("Modified: ");
           stbProperties.Append(System.IO.File.GetLastWriteTime(ofdSelectPicture.FileName));

           // Get file attributes
           fileAttributes = System.IO.File.GetAttributes(ofdSelectPicture.FileName);
           stbProperties.Append("\r\n");

           // Use binary AND to extract specific attributes.
           stbProperties.Append("Normal: ");
           stbProperties.Append(
               Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.Normal)
               == System.IO.FileAttributes.Hidden));
           stbProperties.Append("\r\n");

           stbProperties.Append("Hidden:   ");
           stbProperties.Append(
               Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.Hidden)
               == System.IO.FileAttributes.Hidden));
           stbProperties.Append("\r\n");

           stbProperties.Append("ReadOnly: ");
           stbProperties.Append(
               Convert.ToBoolean((fileAttributes &
               System.IO.FileAttributes.ReadOnly)));
           stbProperties.Append("\r\n");

           stbProperties.Append("System: ");
           stbProperties.Append(
               Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.System)
               == System.IO.FileAttributes.System));
           stbProperties.Append("\r\n");

           stbProperties.Append("Temporary File: ");
           stbProperties.Append(
               Convert.ToBoolean((fileAttributes &
               System.IO.FileAttributes.Temporary)
               == System.IO.FileAttributes.Temporary));
           stbProperties.Append("\r\n");

           stbProperties.Append("Archive: ");
           stbProperties.Append(
               Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.Archive)
               == System.IO.FileAttributes.Archive));
           MessageBox.Show(stbProperties.ToString());

       }

        private void UpdateLog(string strFileName)
       {
           StreamWriter objFile = new StreamWriter(
               System.AppDomain.CurrentDomain.BaseDirectory +
           @"\PhotoLog.txt", true);

           objFile.WriteLine(DateTime.Now + " " + strFileName);
           objFile.Close();
           objFile.Dispose();
       }
        
        public frmViewer()
        {
            InitializeComponent();
        }

        private void DrawBorder(PictureBox objPictureBox)
        {
            Graphics objGraphics = null;
            objGraphics = this.CreateGraphics();
            objGraphics.Clear(SystemColors.Control);
            objGraphics.DrawRectangle(Pens.Blue,
                objPictureBox.Left - 1, objPictureBox.Top - 1,
                objPictureBox.Width + 1, objPictureBox.Height + 1);
            objGraphics.Dispose();
        }

        private void btnEnlarge_Click(object sender, EventArgs e)
        {
            this.Width = this.Width + 10;
            this.Height = this.Height + 10;
        }

        private void btnShrink_Click(object sender, EventArgs e)
        {
            this.Width = this.Width - 20;
            this.Height = this.Height - 20;

        }

        private void mnuOpenPicture_Click(object sender, EventArgs e)
        {
           this.OpenPicture();
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuDrawBorder_Click(object sender, EventArgs e)
        {
            this.DrawBorder(picShowPicture);
        }

        private void mnuOptions_Click(object sender, EventArgs e)
        {
            frmOptions frmOptionsDialog = new frmOptions();
            frmOptionsDialog.ShowDialog();
            LoadDefaults();
        }

        private void mnuConfirmOnExit_Click_1(object sender, EventArgs e)
        {
            mnuConfirmOnExit.Checked = !(mnuConfirmOnExit.Checked);
            mPromptOnExit = mnuConfirmOnExit.Checked;
        }

        private void mnuPictureContext_Opening(object sender, CancelEventArgs e)
        {
            Graphics objGraphics = null;
            objGraphics = this.CreateGraphics();
            objGraphics.Clear((SystemColors.Control));
            objGraphics.DrawRectangle(Pens.Blue,
                picShowPicture.Left - 1, picShowPicture.Top - 1,
                picShowPicture.Width + 1, picShowPicture.Height + 1);
            objGraphics.Dispose();
        }

        private void tbbOpenPicture_Click(object sender, EventArgs e)
        {
           this.OpenPicture();
        }

        private void tbbDrawBorder_Click(object sender, EventArgs e)
        {
            this.DrawBorder(picShowPicture);
        }

        private void tbbOptions_Click(object sender, EventArgs e)
        {
            frmOptions frmOptionsDialog = new frmOptions();
            frmOptionsDialog.ShowDialog();
            LoadDefaults();
        }

        private void picShowPicture_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = "X: " + e.X.ToString();
            lblY.Text = "Y: " + e.Y.ToString();
        }

        private void picShowPicture_MouseLeave(object sender, EventArgs e)
        {
            lblX.Text = "";
            lblY.Text = "";
        }

        private void frmViewer_Load(object sender, EventArgs e)
        {
            lblX.Text = "";
            lblY.Text = "";
            LoadDefaults();
        }

        private void LoadDefaults()
        {
            mPromptOnExit = Convert.ToBoolean(Registry.GetValue(
                @"HKEY_CURRENT_USER\Software\CleverSoftware\PhotoViewer",
                "PromptOnExit", "false"));

            if (Convert.ToString(Registry.GetValue(
                @"HKEY_CURRENT_USER\Software\CleverSoftware\Photoviewer",
                "BackColor", "Gray")) == "Gray")
            {
                mPictureBackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                mPictureBackColor = System.Drawing.Color.White;
            }


            picShowPicture.BackColor = mPictureBackColor;
            mnuConfirmOnExit.Checked = mPromptOnExit;
        }

        private void frmViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mPromptOnExit)
            {
                if (MessageBox.Show("Close the Picture Viewer program?", "Confirm Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void tbrMainToolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tbbGetFileAttributes_Click(object sender, EventArgs e)
        {
            this.GetFileAttributes();
        }

        private void tbbShowLog_Click(object sender, EventArgs e)
        {
            frmLogViewer objLog = new frmLogViewer();
            objLog.ShowDialog();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogViewer objLog = new frmLogViewer();
            objLog.ShowDialog();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GetFileAttributes();
        }
    }
}
