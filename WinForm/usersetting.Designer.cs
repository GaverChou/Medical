namespace WinForm
{
    partial class usersetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.return_but = new CCWin.SkinControl.SkinButton();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.password_tb = new CCWin.SkinControl.SkinLabel();
            this.address_tb = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.ensure_btn = new CCWin.SkinControl.SkinButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_department = new CCWin.SkinControl.SkinWaterTextBox();
            this.tb_address = new CCWin.SkinControl.SkinWaterTextBox();
            this.tb_idcard = new CCWin.SkinControl.SkinWaterTextBox();
            this.tb_name = new CCWin.SkinControl.SkinWaterTextBox();
            this.tb_gender = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(148, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "基础设置";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BackgroundImage = global::WinForm.Properties.Resources.p2;
            this.skinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel1.Controls.Add(this.tb_gender);
            this.skinPanel1.Controls.Add(this.tb_name);
            this.skinPanel1.Controls.Add(this.tb_idcard);
            this.skinPanel1.Controls.Add(this.tb_address);
            this.skinPanel1.Controls.Add(this.tb_department);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.return_but);
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.password_tb);
            this.skinPanel1.Controls.Add(this.address_tb);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.label2);
            this.skinPanel1.Controls.Add(this.ensure_btn);
            this.skinPanel1.Controls.Add(this.label3);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(67, 131);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(283, 347);
            this.skinPanel1.TabIndex = 11;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(17, 104);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(114, 20);
            this.skinLabel1.TabIndex = 18;
            this.skinLabel1.Text = "医疗机构名称：";
            // 
            // return_but
            // 
            this.return_but.BackColor = System.Drawing.SystemColors.Highlight;
            this.return_but.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.return_but.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.return_but.DownBack = null;
            this.return_but.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.return_but.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.return_but.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.return_but.Location = new System.Drawing.Point(45, 291);
            this.return_but.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.return_but.Name = "return_but";
            this.return_but.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.return_but.Size = new System.Drawing.Size(78, 37);
            this.return_but.TabIndex = 17;
            this.return_but.Text = "返回";
            this.return_but.UseVisualStyleBackColor = false;
            this.return_but.Click += new System.EventHandler(this.return_but_Click);
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel5.Location = new System.Drawing.Point(17, 237);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(54, 20);
            this.skinLabel5.TabIndex = 11;
            this.skinLabel5.Text = "性别：";
            // 
            // password_tb
            // 
            this.password_tb.AutoSize = true;
            this.password_tb.BackColor = System.Drawing.Color.Transparent;
            this.password_tb.BorderColor = System.Drawing.Color.White;
            this.password_tb.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.password_tb.Location = new System.Drawing.Point(17, 169);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(68, 20);
            this.password_tb.TabIndex = 10;
            this.password_tb.Text = "医师id：";
            // 
            // address_tb
            // 
            this.address_tb.AutoSize = true;
            this.address_tb.BackColor = System.Drawing.Color.Transparent;
            this.address_tb.BorderColor = System.Drawing.Color.White;
            this.address_tb.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.address_tb.Location = new System.Drawing.Point(17, 136);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(84, 20);
            this.address_tb.TabIndex = 9;
            this.address_tb.Text = "单位地址：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel2.Location = new System.Drawing.Point(17, 203);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(84, 20);
            this.skinLabel2.TabIndex = 8;
            this.skinLabel2.Text = "医师名称：";
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
            // ensure_btn
            // 
            this.ensure_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ensure_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ensure_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ensure_btn.DownBack = null;
            this.ensure_btn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.ensure_btn.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ensure_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ensure_btn.Location = new System.Drawing.Point(159, 291);
            this.ensure_btn.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.ensure_btn.Name = "ensure_btn";
            this.ensure_btn.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.ensure_btn.Size = new System.Drawing.Size(78, 37);
            this.ensure_btn.TabIndex = 4;
            this.ensure_btn.Text = "确定";
            this.ensure_btn.UseVisualStyleBackColor = false;
            this.ensure_btn.Click += new System.EventHandler(this.ensure_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(72, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "你好！";
            // 
            // tb_department
            // 
            this.tb_department.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.tb_department.Location = new System.Drawing.Point(159, 104);
            this.tb_department.Name = "tb_department";
            this.tb_department.Size = new System.Drawing.Size(100, 27);
            this.tb_department.TabIndex = 19;
            this.tb_department.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_department.WaterText = "";
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_address.Location = new System.Drawing.Point(159, 136);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(100, 27);
            this.tb_address.TabIndex = 20;
            this.tb_address.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_address.WaterText = "";
            // 
            // tb_idcard
            // 
            this.tb_idcard.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_idcard.Location = new System.Drawing.Point(159, 164);
            this.tb_idcard.Name = "tb_idcard";
            this.tb_idcard.Size = new System.Drawing.Size(100, 27);
            this.tb_idcard.TabIndex = 21;
            this.tb_idcard.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_idcard.WaterText = "";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_name.Location = new System.Drawing.Point(159, 198);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 27);
            this.tb_name.TabIndex = 22;
            this.tb_name.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_name.WaterText = "";
            // 
            // tb_gender
            // 
            this.tb_gender.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_gender.Location = new System.Drawing.Point(159, 232);
            this.tb_gender.Name = "tb_gender";
            this.tb_gender.Size = new System.Drawing.Size(100, 27);
            this.tb_gender.TabIndex = 23;
            this.tb_gender.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_gender.WaterText = "";
            // 
            // usersetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources.bg;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ClientSize = new System.Drawing.Size(420, 485);
            this.CloseDownBack = global::WinForm.Properties.Resources.CloseDownBack;
            this.CloseMouseBack = global::WinForm.Properties.Resources.CloseMouseBack;
            this.CloseNormlBack = global::WinForm.Properties.Resources.CloseNormlBack1;
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(0, 0);
            this.MiniDownBack = global::WinForm.Properties.Resources.MiniDownBack;
            this.MiniMouseBack = global::WinForm.Properties.Resources.MiniMouseBack;
            this.MiniNormlBack = global::WinForm.Properties.Resources.MiniNormlBack;
            this.Name = "usersetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户设置";
            this.Load += new System.EventHandler(this.usersetting_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinButton ensure_btn;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel password_tb;
        private CCWin.SkinControl.SkinLabel address_tb;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButton return_but;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinWaterTextBox tb_gender;
        private CCWin.SkinControl.SkinWaterTextBox tb_name;
        private CCWin.SkinControl.SkinWaterTextBox tb_idcard;
        private CCWin.SkinControl.SkinWaterTextBox tb_address;
        private CCWin.SkinControl.SkinWaterTextBox tb_department;
    }
}