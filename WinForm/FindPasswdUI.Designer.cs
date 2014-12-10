namespace WinForm
{
    partial class FindPasswdUI
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
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.back_btn = new CCWin.SkinControl.SkinButton();
            this.ok_btn = new CCWin.SkinControl.SkinButton();
            this.pass2_txb = new CCWin.SkinControl.SkinWaterTextBox();
            this.pass1_txb = new CCWin.SkinControl.SkinWaterTextBox();
            this.idcard_txb = new CCWin.SkinControl.SkinWaterTextBox();
            this.name_txb = new CCWin.SkinControl.SkinWaterTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BackgroundImage = global::WinForm.Properties.Resources.p2;
            this.skinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel1.Controls.Add(this.back_btn);
            this.skinPanel1.Controls.Add(this.ok_btn);
            this.skinPanel1.Controls.Add(this.pass2_txb);
            this.skinPanel1.Controls.Add(this.pass1_txb);
            this.skinPanel1.Controls.Add(this.idcard_txb);
            this.skinPanel1.Controls.Add(this.name_txb);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(61, 160);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(304, 339);
            this.skinPanel1.TabIndex = 0;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.back_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.back_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.back_btn.DownBack = null;
            this.back_btn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.back_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(168, 276);
            this.back_btn.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.back_btn.Name = "back_btn";
            this.back_btn.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.back_btn.Size = new System.Drawing.Size(78, 37);
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "返回";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ok_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ok_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ok_btn.DownBack = null;
            this.ok_btn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.ok_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ok_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ok_btn.Location = new System.Drawing.Point(65, 276);
            this.ok_btn.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.ok_btn.Size = new System.Drawing.Size(78, 37);
            this.ok_btn.TabIndex = 6;
            this.ok_btn.Text = "重置";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // pass2_txb
            // 
            this.pass2_txb.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pass2_txb.Location = new System.Drawing.Point(65, 219);
            this.pass2_txb.Name = "pass2_txb";
            this.pass2_txb.Size = new System.Drawing.Size(181, 29);
            this.pass2_txb.TabIndex = 3;
            this.pass2_txb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pass2_txb.WaterText = "再次确认密码";
            // 
            // pass1_txb
            // 
            this.pass1_txb.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pass1_txb.Location = new System.Drawing.Point(65, 158);
            this.pass1_txb.Name = "pass1_txb";
            this.pass1_txb.Size = new System.Drawing.Size(181, 29);
            this.pass1_txb.TabIndex = 2;
            this.pass1_txb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pass1_txb.WaterText = "请输入密码";
            // 
            // idcard_txb
            // 
            this.idcard_txb.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idcard_txb.Location = new System.Drawing.Point(65, 103);
            this.idcard_txb.Name = "idcard_txb";
            this.idcard_txb.Size = new System.Drawing.Size(181, 29);
            this.idcard_txb.TabIndex = 1;
            this.idcard_txb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.idcard_txb.WaterText = "请输入身份证号";
            // 
            // name_txb
            // 
            this.name_txb.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name_txb.Location = new System.Drawing.Point(65, 48);
            this.name_txb.Name = "name_txb";
            this.name_txb.Size = new System.Drawing.Size(181, 29);
            this.name_txb.TabIndex = 0;
            this.name_txb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.name_txb.WaterText = "请输入姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户安全中心";
            // 
            // FindPasswdUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(427, 542);
            this.CloseDownBack = global::WinForm.Properties.Resources.CloseDownBack;
            this.CloseMouseBack = global::WinForm.Properties.Resources.CloseMouseBack;
            this.CloseNormlBack = global::WinForm.Properties.Resources.CloseNormlBack1;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skinPanel1);
            this.MaximizeBox = false;
            this.MiniDownBack = global::WinForm.Properties.Resources.MiniDownBack;
            this.MiniMouseBack = global::WinForm.Properties.Resources.MiniMouseBack;
            this.MiniNormlBack = global::WinForm.Properties.Resources.MiniNormlBack;
            this.Name = "FindPasswdUI";
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindPasswdUI_FormClosed);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinWaterTextBox pass2_txb;
        private CCWin.SkinControl.SkinWaterTextBox pass1_txb;
        private CCWin.SkinControl.SkinWaterTextBox idcard_txb;
        private CCWin.SkinControl.SkinWaterTextBox name_txb;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinButton back_btn;
        private CCWin.SkinControl.SkinButton ok_btn;
    }
}