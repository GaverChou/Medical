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
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.lblBackup = new System.Windows.Forms.Label();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.lblRestore = new System.Windows.Forms.Label();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnRestroePath = new System.Windows.Forms.Button();
            this.sfdlgBackup = new System.Windows.Forms.SaveFileDialog();
            this.ofdlgRestore = new System.Windows.Forms.OpenFileDialog();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBackupPath = new System.Windows.Forms.Button();
            this.grpBackup.SuspendLayout();
            this.grpRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.btnBackupPath);
            this.grpBackup.Controls.Add(this.btnBackup);
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
            this.txtBackup.Size = new System.Drawing.Size(327, 23);
            this.txtBackup.TabIndex = 0;
            // 
            // grpRestore
            // 
            this.grpRestore.Controls.Add(this.lblRestore);
            this.grpRestore.Controls.Add(this.txtRestore);
            this.grpRestore.Controls.Add(this.btnRestore);
            this.grpRestore.Controls.Add(this.btnRestroePath);
            this.grpRestore.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grpRestore.Location = new System.Drawing.Point(12, 154);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(508, 107);
            this.grpRestore.TabIndex = 0;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "恢复数据库";
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
            this.txtRestore.Size = new System.Drawing.Size(327, 23);
            this.txtRestore.TabIndex = 1;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(74, 73);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(392, 27);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Text = "恢复数据库";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnRestroePath
            // 
            this.btnRestroePath.Location = new System.Drawing.Point(427, 37);
            this.btnRestroePath.Name = "btnRestroePath";
            this.btnRestroePath.Size = new System.Drawing.Size(75, 25);
            this.btnRestroePath.TabIndex = 6;
            this.btnRestroePath.Text = "选择";
            this.btnRestroePath.UseVisualStyleBackColor = true;
            this.btnRestroePath.Click += new System.EventHandler(this.btnRestroePath_Click);
            // 
            // ofdlgRestore
            // 
            this.ofdlgRestore.FileName = "openFileDialog1";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(74, 65);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(392, 27);
            this.btnBackup.TabIndex = 5;
            this.btnBackup.Text = "备份数据库";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBackupPath
            // 
            this.btnBackupPath.Location = new System.Drawing.Point(427, 31);
            this.btnBackupPath.Name = "btnBackupPath";
            this.btnBackupPath.Size = new System.Drawing.Size(75, 25);
            this.btnBackupPath.TabIndex = 4;
            this.btnBackupPath.Text = "选择";
            this.btnBackupPath.UseVisualStyleBackColor = true;
            this.btnBackupPath.Click += new System.EventHandler(this.btnBackupPath_Click);
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 289);
            this.CloseDownBack = global::WinForm.Properties.Resources.CloseDownBack;
            this.CloseMouseBack = global::WinForm.Properties.Resources.CloseMouseBack;
            this.CloseNormlBack = global::WinForm.Properties.Resources.CloseNormlBack1;
            this.Controls.Add(this.grpRestore);
            this.Controls.Add(this.grpBackup);
            this.MaximizeBox = false;
            this.MiniDownBack = global::WinForm.Properties.Resources.MiniDownBack;
            this.MiniMouseBack = global::WinForm.Properties.Resources.MiniMouseBack;
            this.MiniNormlBack = global::WinForm.Properties.Resources.MiniNormlBack;
            this.Name = "FormDB";
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
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnRestroePath;
        private System.Windows.Forms.SaveFileDialog sfdlgBackup;
        private System.Windows.Forms.OpenFileDialog ofdlgRestore;
        private System.Windows.Forms.Button btnBackupPath;
        private System.Windows.Forms.Button btnBackup;
    }
}