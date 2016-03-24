using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.Win32;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Viewer
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Registry.SetValue(
               @"HKEY_CURRENT_USER\Software\CleverSoftware\PhotoViewer\",
               "UserName", txtUserName.Text);
            Registry.SetValue(
                @"HKEY_CURRENT_USER\Software\CleverSoftware\PhotoViewer\",
                "PromptOnExit", chkPromptOnExit.Checked);

            if (rbBackgroundDefault.Checked)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\CleverSofware\PhotoViewer",
                    "BackColor", "Gray");

            }
            else
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\CleverSoftware\PhotoViewer",
                    "BackColor", "White");
            }
            this.Close();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.Left -= 5;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            this.Left += 5;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Convert.ToString(Registry.GetValue(
                @"HKEY_CURRENT_USER\Software\CleverSoftware\PhotoViewer\",
                "UserName", ""));

            chkPromptOnExit.Checked = Convert.ToBoolean(Registry.GetValue(
                @"HKEY_CURRENT_USER\Software\CleverSoftware\PhotoViewer\",
            "PromptOnExit", "false"));

            if (Convert.ToString(Registry.GetValue(
                @"HKEY_CURRENT_USER\Software\CleverSoftware\PhotoViewer\",
                "BackColor", "Gray")) == "Gray")
                rbBackgroundDefault.Checked = true;
            else
                rbBackgroundWhite.Checked = true;
        }
    }
}
