namespace WinForm
{
    partial class LoginUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            this.label1 = new System.Windows.Forms.Label();
            this.userName_txb = new CCWin.SkinControl.SkinWaterTextBox();
            this.passwd_txb = new CCWin.SkinControl.SkinWaterTextBox();
            this.remenber_ckb = new CCWin.SkinControl.SkinCheckBox();
            this.login_btn = new CCWin.SkinControl.SkinButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forget_lb = new CCWin.SkinControl.SkinLabel();
            this.register_btn = new CCWin.SkinControl.SkinButton();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(107, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "医疗处方管理系统";
            // 
            // userName_txb
            // 
            this.userName_txb.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.userName_txb.Location = new System.Drawing.Point(29, 99);
            this.userName_txb.Name = "userName_txb";
            this.userName_txb.Size = new System.Drawing.Size(202, 31);
            this.userName_txb.TabIndex = 1;
            this.userName_txb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userName_txb.WaterText = "用户名";
            // 
            // passwd_txb
            // 
            this.passwd_txb.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.passwd_txb.Location = new System.Drawing.Point(29, 136);
            this.passwd_txb.Name = "passwd_txb";
            this.passwd_txb.Size = new System.Drawing.Size(202, 31);
            this.passwd_txb.TabIndex = 2;
            this.passwd_txb.UseSystemPasswordChar = true;
            this.passwd_txb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwd_txb.WaterText = "密码";
            // 
            // remenber_ckb
            // 
            this.remenber_ckb.AutoSize = true;
            this.remenber_ckb.BackColor = System.Drawing.Color.Transparent;
            this.remenber_ckb.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.remenber_ckb.DownBack = null;
            this.remenber_ckb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.remenber_ckb.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.remenber_ckb.ForeColor = System.Drawing.Color.FloralWhite;
            this.remenber_ckb.Location = new System.Drawing.Point(29, 173);
            this.remenber_ckb.MouseBack = null;
            this.remenber_ckb.Name = "remenber_ckb";
            this.remenber_ckb.NormlBack = null;
            this.remenber_ckb.SelectedDownBack = null;
            this.remenber_ckb.SelectedMouseBack = null;
            this.remenber_ckb.SelectedNormlBack = null;
            this.remenber_ckb.Size = new System.Drawing.Size(90, 25);
            this.remenber_ckb.TabIndex = 3;
            this.remenber_ckb.Text = "记住密码";
            this.remenber_ckb.UseVisualStyleBackColor = false;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.login_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.login_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.login_btn.DownBack = null;
            this.login_btn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.login_btn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_btn.Location = new System.Drawing.Point(29, 205);
            this.login_btn.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.login_btn.Name = "login_btn";
            this.login_btn.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.login_btn.Size = new System.Drawing.Size(78, 37);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "登录";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Image = global::WinForm.Properties.Resources.user;
            this.label2.Location = new System.Drawing.Point(26, 43);
            this.label2.MaximumSize = new System.Drawing.Size(40, 40);
            this.label2.MinimumSize = new System.Drawing.Size(40, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 40);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(72, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "管理登录";
            // 
            // forget_lb
            // 
            this.forget_lb.AutoSize = true;
            this.forget_lb.BackColor = System.Drawing.Color.Transparent;
            this.forget_lb.BorderColor = System.Drawing.Color.White;
            this.forget_lb.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.forget_lb.ForeColor = System.Drawing.Color.DimGray;
            this.forget_lb.Location = new System.Drawing.Point(157, 175);
            this.forget_lb.Name = "forget_lb";
            this.forget_lb.Size = new System.Drawing.Size(72, 20);
            this.forget_lb.TabIndex = 8;
            this.forget_lb.Text = "忘记密码?";
            this.forget_lb.Click += new System.EventHandler(this.forget_lb_Click);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.register_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.register_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.register_btn.DownBack = null;
            this.register_btn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.register_btn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.register_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register_btn.Location = new System.Drawing.Point(153, 205);
            this.register_btn.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.register_btn.Name = "register_btn";
            this.register_btn.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.register_btn.Size = new System.Drawing.Size(78, 37);
            this.register_btn.TabIndex = 9;
            this.register_btn.Text = "注册";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BackgroundImage = global::WinForm.Properties.Resources.p2;
            this.skinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel1.Controls.Add(this.label2);
            this.skinPanel1.Controls.Add(this.login_btn);
            this.skinPanel1.Controls.Add(this.register_btn);
            this.skinPanel1.Controls.Add(this.label3);
            this.skinPanel1.Controls.Add(this.forget_lb);
            this.skinPanel1.Controls.Add(this.userName_txb);
            this.skinPanel1.Controls.Add(this.passwd_txb);
            this.skinPanel1.Controls.Add(this.remenber_ckb);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(83, 168);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(258, 264);
            this.skinPanel1.TabIndex = 10;
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 485);
            this.CloseDownBack = global::WinForm.Properties.Resources.CloseDownBack;
            this.CloseMouseBack = global::WinForm.Properties.Resources.CloseMouseBack;
            this.CloseNormlBack = global::WinForm.Properties.Resources.CloseNormlBack1;
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MiniDownBack = global::WinForm.Properties.Resources.MiniDownBack;
            this.MiniMouseBack = global::WinForm.Properties.Resources.MiniMouseBack;
            this.MiniNormlBack = global::WinForm.Properties.Resources.MiniNormlBack;
            this.Name = "LoginUI";
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.ShadowWidth = 6;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginUI_FormClosed);
            this.Load += new System.EventHandler(this.LoginUI_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinWaterTextBox userName_txb;
        private CCWin.SkinControl.SkinWaterTextBox passwd_txb;
        private CCWin.SkinControl.SkinCheckBox remenber_ckb;
        private CCWin.SkinControl.SkinButton login_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinLabel forget_lb;
        private CCWin.SkinControl.SkinButton register_btn;
        private CCWin.SkinControl.SkinPanel skinPanel1;
    }
}