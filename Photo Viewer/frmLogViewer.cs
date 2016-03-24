using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Viewer
{
    public partial class frmLogViewer : Form
    {
        public frmLogViewer()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogViewer_Load(object sender, EventArgs e)
        {

            try
            {
                StreamReader objFile = new StreamReader(
                    System.AppDomain.CurrentDomain.BaseDirectory +
                    @"\PhotoLog.txt");
                txtLog.Text = objFile.ReadToEnd();
                objFile.Close();
                objFile.Dispose();
            }
            catch
            {
                txtLog.Text = "The log file could not be found.";
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            // Overwrite current log file.
            StreamWriter objFile = new StreamWriter(
                System.AppDomain.CurrentDomain.BaseDirectory +
            @"\PhotoLog.txt");
            // Close new, empty log file.
            objFile.Close();
            objFile.Dispose();

            this.Close();
        }
    }
}
