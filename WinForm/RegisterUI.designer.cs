namespace WinForm
{
    partial class RegisterUI
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
            this.register_btn = new CCWin.SkinControl.SkinButton();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.gender_cb = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.address_txb = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.idcard_txb = new CCWin.SkinControl.SkinWaterTextBox();
            this.passwd_txb_1 = new CCWin.SkinControl.SkinWaterTextBox();
            this.name_txb = new CCWin.SkinControl.SkinWaterTextBox();
            this.passwd_txb_2 = new CCWin.SkinControl.SkinWaterTextBox();
            this.kebie_txb = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BackgroundImage = global::WinForm.Properties.Resources.p2;
            this.skinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel1.Controls.Add(this.back_btn);
            this.skinPanel1.Controls.Add(this.register_btn);
            this.skinPanel1.Controls.Add(this.skinLabel7);
            this.skinPanel1.Controls.Add(this.gender_cb);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Controls.Add(this.address_txb);
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.idcard_txb);
            this.skinPanel1.Controls.Add(this.passwd_txb_1);
            this.skinPanel1.Controls.Add(this.name_txb);
            this.skinPanel1.Controls.Add(this.passwd_txb_2);
            this.skinPanel1.Controls.Add(this.kebie_txb);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(64, 124);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(321, 343);
            this.skinPanel1.TabIndex = 0;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BaseColor = System.Drawing.Color.Silver;
            this.back_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.back_btn.DownBack = null;
            this.back_btn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.back_btn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(179, 273);
            this.back_btn.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.back_btn.Name = "back_btn";
            this.back_btn.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.back_btn.Size = new System.Drawing.Size(78, 36);
            this.back_btn.TabIndex = 15;
            this.back_btn.Text = "返回";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.Transparent;
            this.register_btn.BaseColor = System.Drawing.Color.Silver;
            this.register_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.register_btn.DownBack = null;
            this.register_btn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.register_btn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.register_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register_btn.Location = new System.Drawing.Point(69, 273);
            this.register_btn.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.register_btn.Name = "register_btn";
            this.register_btn.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.register_btn.Size = new System.Drawing.Size(78, 36);
            this.register_btn.TabIndex = 14;
            this.register_btn.Text = "注册";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.LightSlateGray;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel7.Location = new System.Drawing.Point(54, 223);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(94, 27);
            this.skinLabel7.TabIndex = 13;
            this.skinLabel7.Text = "     性别  ";
            // 
            // gender_cb
            // 
            this.gender_cb.BaseColor = System.Drawing.Color.Silver;
            this.gender_cb.BorderColor = System.Drawing.Color.Silver;
            this.gender_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gender_cb.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gender_cb.FormattingEnabled = true;
            this.gender_cb.ItemBorderColor = System.Drawing.Color.Silver;
            this.gender_cb.Items.AddRange(new object[] {
            "男",
            "女",
            "不详 "});
            this.gender_cb.Location = new System.Drawing.Point(145, 222);
            this.gender_cb.Name = "gender_cb";
            this.gender_cb.Size = new System.Drawing.Size(136, 28);
            this.gender_cb.TabIndex = 7;
            this.gender_cb.WaterText = "";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.LightSlateGray;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel6.Location = new System.Drawing.Point(54, 191);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(94, 27);
            this.skinLabel6.TabIndex = 11;
            this.skinLabel6.Text = "     地址  ";
            // 
            // address_txb
            // 
            this.address_txb.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.address_txb.Location = new System.Drawing.Point(146, 191);
            this.address_txb.Name = "address_txb";
            this.address_txb.Size = new System.Drawing.Size(135, 27);
            this.address_txb.TabIndex = 6;
            this.address_txb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.address_txb.WaterText = "";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel5.Location = new System.Drawing.Point(54, 160);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(96, 27);
            this.skinLabel5.TabIndex = 1;
            this.skinLabel5.Text = "   身份证 ";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.LightSlateGray;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel4.Location = new System.Drawing.Point(54, 129);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(94, 27);
            this.skinLabel4.TabIndex = 8;
            this.skinLabel4.Text = "     科别  ";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel3.Location = new System.Drawing.Point(54, 98);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(94, 27);
            this.skinLabel3.TabIndex = 7;
            this.skinLabel3.Text = "     密码  ";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel2.Location = new System.Drawing.Point(54, 67);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(94, 27);
            this.skinLabel2.TabIndex = 6;
            this.skinLabel2.Text = "     密码  ";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(54, 36);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(94, 27);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "     姓名  ";
            // 
            // idcard_txb
            // 
            this.idcard_txb.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idcard_txb.Location = new System.Drawing.Point(145, 160);
            this.idcard_txb.Name = "idcard_txb";
            this.idcard_txb.Size = new System.Drawing.Size(136, 27);
            this.idcard_txb.TabIndex = 5;
            this.idcard_txb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.idcard_txb.WaterText = "";
            // 
            // passwd_txb_1
            // 
            this.passwd_txb_1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwd_txb_1.Location = new System.Drawing.Point(146, 67);
            this.passwd_txb_1.Name = "passwd_txb_1";
            this.passwd_txb_1.Size = new System.Drawing.Size(136, 27);
            this.passwd_txb_1.TabIndex = 2;
            this.passwd_txb_1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwd_txb_1.WaterText = "";
            // 
            // name_txb
            // 
            this.name_txb.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.name_txb.Location = new System.Drawing.Point(146, 36);
            this.name_txb.Name = "name_txb";
            this.name_txb.Size = new System.Drawing.Size(136, 27);
            this.name_txb.TabIndex = 1;
            this.name_txb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.name_txb.WaterText = "";
            // 
            // passwd_txb_2
            // 
            this.passwd_txb_2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwd_txb_2.Location = new System.Drawing.Point(146, 98);
            this.passwd_txb_2.Name = "passwd_txb_2";
            this.passwd_txb_2.Size = new System.Drawing.Size(136, 27);
            this.passwd_txb_2.TabIndex = 3;
            this.passwd_txb_2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwd_txb_2.WaterText = "";
            // 
            // kebie_txb
            // 
            this.kebie_txb.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.kebie_txb.Location = new System.Drawing.Point(146, 129);
            this.kebie_txb.Name = "kebie_txb";
            this.kebie_txb.Size = new System.Drawing.Size(136, 27);
            this.kebie_txb.TabIndex = 4;
            this.kebie_txb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.kebie_txb.WaterText = "";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.skinLabel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skinLabel8.Location = new System.Drawing.Point(178, 66);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(106, 31);
            this.skinLabel8.TabIndex = 1;
            this.skinLabel8.Text = "用户注册";
            // 
            // RegisterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::WinForm.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 492);
            this.CloseDownBack = global::WinForm.Properties.Resources.CloseDownBack;
            this.CloseMouseBack = global::WinForm.Properties.Resources.CloseMouseBack;
            this.CloseNormlBack = global::WinForm.Properties.Resources.CloseNormlBack1;
            this.Controls.Add(this.skinLabel8);
            this.Controls.Add(this.skinPanel1);
            this.MaximizeBox = false;
            this.MiniDownBack = global::WinForm.Properties.Resources.MiniDownBack;
            this.MiniMouseBack = global::WinForm.Properties.Resources.MiniMouseBack;
            this.MiniNormlBack = global::WinForm.Properties.Resources.MiniNormlBack;
            this.Name = "RegisterUI";
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterUI_FormClosed);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinWaterTextBox passwd_txb_1;
        private CCWin.SkinControl.SkinWaterTextBox name_txb;
        private CCWin.SkinControl.SkinWaterTextBox passwd_txb_2;
        private CCWin.SkinControl.SkinWaterTextBox kebie_txb;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinWaterTextBox idcard_txb;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinWaterTextBox address_txb;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinComboBox gender_cb;
        private CCWin.SkinControl.SkinButton register_btn;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinButton back_btn;
    }
}