namespace WinForm
{
    partial class FormDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDB));
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.btnBackup = new CCWin.SkinControl.SkinButton();
            this.btnBackupPath = new CCWin.SkinControl.SkinButton();
            this.lblBackup = new System.Windows.Forms.Label();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.btnRestore = new CCWin.SkinControl.SkinButton();
            this.btnRestroePath = new CCWin.SkinControl.SkinButton();
            this.lblRestore = new System.Windows.Forms.Label();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.sfdlgBackup = new System.Windows.Forms.SaveFileDialog();
            this.ofdlgRestore = new System.Windows.Forms.OpenFileDialog();
            this.grpBackup.SuspendLayout();
            this.grpRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.btnBackup);
            this.grpBackup.Controls.Add(this.btnBackupPath);
            this.grpBackup.Controls.Add(this.lblBackup);
            this.grpBackup.Controls.Add(this.txtBackup);
            this.grpBackup.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grpBackup.Location = new System.Drawing.Point(12, 35);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(508, 107);
            this.grpBackup.TabIndex = 0;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "备份数据库";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBackup.BaseColor = System.Drawing.Color.AliceBlue;
            this.btnBackup.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnBackup.DownBack = null;
            this.btnBackup.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnBackup.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnBackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackup.Location = new System.Drawing.Point(74, 68);
            this.btnBackup.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.btnBackup.Size = new System.Drawing.Size(375, 22);
            this.btnBackup.TabIndex = 8;
            this.btnBackup.Text = "备份数据库";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBackupPath
            // 
            this.btnBackupPath.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBackupPath.BaseColor = System.Drawing.Color.AliceBlue;
            this.btnBackupPath.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnBackupPath.DownBack = null;
            this.btnBackupPath.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnBackupPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnBackupPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackupPath.Location = new System.Drawing.Point(427, 33);
            this.btnBackupPath.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.btnBackupPath.Name = "btnBackupPath";
            this.btnBackupPath.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.btnBackupPath.Size = new System.Drawing.Size(70, 22);
            this.btnBackupPath.TabIndex = 5;
            this.btnBackupPath.Text = "选择";
            this.btnBackupPath.UseVisualStyleBackColor = false;
            this.btnBackupPath.Click += new System.EventHandler(this.btnBackupPath_Click_1);
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.lblBackup.Location = new System.Drawing.Point(27, 34);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(61, 19);
            this.lblBackup.TabIndex = 2;
            this.lblBackup.Text = "备份路径";
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(94, 32);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.ReadOnly = true;
            this.txtBackup.Size = new System.Drawing.Size(327, 23);
            this.txtBackup.TabIndex = 0;
            // 
            // grpRestore
            // 
            this.grpRestore.Controls.Add(this.btnRestore);
            this.grpRestore.Controls.Add(this.btnRestroePath);
            this.grpRestore.Controls.Add(this.lblRestore);
            this.grpRestore.Controls.Add(this.txtRestore);
            this.grpRestore.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grpRestore.Location = new System.Drawing.Point(12, 154);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(508, 107);
            this.grpRestore.TabIndex = 0;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "恢复数据库";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRestore.BaseColor = System.Drawing.Color.AliceBlue;
            this.btnRestore.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRestore.DownBack = null;
            this.btnRestore.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnRestore.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnRestore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestore.Location = new System.Drawing.Point(74, 69);
            this.btnRestore.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.btnRestore.Size = new System.Drawing.Size(375, 22);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "恢复数据库";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click_1);
            // 
            // btnRestroePath
            // 
            this.btnRestroePath.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRestroePath.BaseColor = System.Drawing.Color.AliceBlue;
            this.btnRestroePath.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRestroePath.DownBack = null;
            this.btnRestroePath.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnRestroePath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btnRestroePath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestroePath.Location = new System.Drawing.Point(427, 37);
            this.btnRestroePath.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.btnRestroePath.Name = "btnRestroePath";
            this.btnRestroePath.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.btnRestroePath.Size = new System.Drawing.Size(70, 22);
            this.btnRestroePath.TabIndex = 6;
            this.btnRestroePath.Text = "选择";
            this.btnRestroePath.UseVisualStyleBackColor = false;
            this.btnRestroePath.Click += new System.EventHandler(this.btnRestroePath_Click_1);
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRestore.Location = new System.Drawing.Point(27, 41);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(61, 19);
            this.lblRestore.TabIndex = 3;
            this.lblRestore.Text = "恢复路径";
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(94, 37);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.ReadOnly = true;
            this.txtRestore.Size = new System.Drawing.Size(327, 23);
            this.txtRestore.TabIndex = 1;
            // 
            // ofdlgRestore
            // 
            this.ofdlgRestore.FileName = "openFileDialog1";
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(544, 289);
            this.CloseDownBack = global::WinForm.Properties.Resources.CloseDownBack;
            this.CloseMouseBack = global::WinForm.Properties.Resources.CloseMouseBack;
            this.CloseNormlBack = global::WinForm.Properties.Resources.CloseNormlBack1;
            this.Controls.Add(this.grpRestore);
            this.Controls.Add(this.grpBackup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MiniDownBack = global::WinForm.Properties.Resources.MiniDownBack;
            this.MiniMouseBack = global::WinForm.Properties.Resources.MiniMouseBack;
            this.MiniNormlBack = global::WinForm.Properties.Resources.MiniNormlBack;
            this.Name = "FormDB";
            this.ShowBorder = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库备份与恢复";
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.Label lblRestore;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.SaveFileDialog sfdlgBackup;
        private System.Windows.Forms.OpenFileDialog ofdlgRestore;
        private CCWin.SkinControl.SkinButton btnBackupPath;
        private CCWin.SkinControl.SkinButton btnBackup;
        private CCWin.SkinControl.SkinButton btnRestore;
        private CCWin.SkinControl.SkinButton btnRestroePath;
    }
}