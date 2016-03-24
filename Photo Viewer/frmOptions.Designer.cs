namespace Photo_Viewer
{
    partial class frmOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabAppearance = new System.Windows.Forms.TabPage();
            this.grpDefaultBackcolor = new System.Windows.Forms.GroupBox();
            this.rbBackgroundWhite = new System.Windows.Forms.RadioButton();
            this.rbBackgroundDefault = new System.Windows.Forms.RadioButton();
            this.chkPromptOnExit = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tabOptions.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabAppearance.SuspendLayout();
            this.grpDefaultBackcolor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(305, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLeft.Location = new System.Drawing.Point(15, 225);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "Move Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRight.Location = new System.Drawing.Point(295, 225);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "Move Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(304, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tabGeneral);
            this.tabOptions.Controls.Add(this.tabAppearance);
            this.tabOptions.Location = new System.Drawing.Point(12, 12);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(287, 145);
            this.tabOptions.TabIndex = 9;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.chkPromptOnExit);
            this.tabGeneral.Controls.Add(this.txtUserName);
            this.tabGeneral.Controls.Add(this.lblUserName);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(279, 119);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabAppearance
            // 
            this.tabAppearance.Controls.Add(this.grpDefaultBackcolor);
            this.tabAppearance.Location = new System.Drawing.Point(4, 22);
            this.tabAppearance.Name = "tabAppearance";
            this.tabAppearance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppearance.Size = new System.Drawing.Size(279, 119);
            this.tabAppearance.TabIndex = 1;
            this.tabAppearance.Text = "Appearance";
            this.tabAppearance.UseVisualStyleBackColor = true;
            // 
            // grpDefaultBackcolor
            // 
            this.grpDefaultBackcolor.Controls.Add(this.rbBackgroundWhite);
            this.grpDefaultBackcolor.Controls.Add(this.rbBackgroundDefault);
            this.grpDefaultBackcolor.Location = new System.Drawing.Point(41, 24);
            this.grpDefaultBackcolor.Name = "grpDefaultBackcolor";
            this.grpDefaultBackcolor.Size = new System.Drawing.Size(200, 72);
            this.grpDefaultBackcolor.TabIndex = 9;
            this.grpDefaultBackcolor.TabStop = false;
            this.grpDefaultBackcolor.Text = "Default Picture Background Color";
            // 
            // rbBackgroundWhite
            // 
            this.rbBackgroundWhite.AutoSize = true;
            this.rbBackgroundWhite.Location = new System.Drawing.Point(6, 42);
            this.rbBackgroundWhite.Name = "rbBackgroundWhite";
            this.rbBackgroundWhite.Size = new System.Drawing.Size(53, 17);
            this.rbBackgroundWhite.TabIndex = 1;
            this.rbBackgroundWhite.TabStop = true;
            this.rbBackgroundWhite.Text = "White";
            this.rbBackgroundWhite.UseVisualStyleBackColor = true;
            // 
            // rbBackgroundDefault
            // 
            this.rbBackgroundDefault.AutoSize = true;
            this.rbBackgroundDefault.Checked = true;
            this.rbBackgroundDefault.Location = new System.Drawing.Point(9, 19);
            this.rbBackgroundDefault.Name = "rbBackgroundDefault";
            this.rbBackgroundDefault.Size = new System.Drawing.Size(84, 17);
            this.rbBackgroundDefault.TabIndex = 0;
            this.rbBackgroundDefault.TabStop = true;
            this.rbBackgroundDefault.Text = "Default Grey";
            this.rbBackgroundDefault.UseVisualStyleBackColor = true;
            // 
            // chkPromptOnExit
            // 
            this.chkPromptOnExit.AutoSize = true;
            this.chkPromptOnExit.Location = new System.Drawing.Point(115, 65);
            this.chkPromptOnExit.Name = "chkPromptOnExit";
            this.chkPromptOnExit.Size = new System.Drawing.Size(130, 17);
            this.chkPromptOnExit.TabIndex = 15;
            this.chkPromptOnExit.Text = "Prompt to confirm exit.";
            this.chkPromptOnExit.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(106, 36);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(139, 20);
            this.txtUserName.TabIndex = 14;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(34, 43);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(66, 13);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "User Name: ";
            // 
            // frmOptions
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.tabOptions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Viewer Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.tabOptions.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabAppearance.ResumeLayout(false);
            this.grpDefaultBackcolor.ResumeLayout(false);
            this.grpDefaultBackcolor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabAppearance;
        private System.Windows.Forms.GroupBox grpDefaultBackcolor;
        private System.Windows.Forms.RadioButton rbBackgroundWhite;
        private System.Windows.Forms.RadioButton rbBackgroundDefault;
        private System.Windows.Forms.CheckBox chkPromptOnExit;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
    }
}