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
            this.sex_ttb = new CCWin.SkinControl.SkinTextBox();
            this.username_ttb = new CCWin.SkinControl.SkinTextBox();
            this.address_ttb = new CCWin.SkinControl.SkinTextBox();
            this.department_ttb = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.return_but = new CCWin.SkinControl.SkinButton();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.password_tb = new CCWin.SkinControl.SkinLabel();
            this.address_tb = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.ensure_btn = new CCWin.SkinControl.SkinButton();
            this.label3 = new System.Windows.Forms.Label();
            this.idcard_ttb = new CCWin.SkinControl.SkinTextBox();
            this.skinPanel1.SuspendLayout();
            this.sex_ttb.SuspendLayout();
            this.username_ttb.SuspendLayout();
            this.address_ttb.SuspendLayout();
            this.department_ttb.SuspendLayout();
            this.idcard_ttb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(168, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "基础设置";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BackgroundImage = global::WinForm.Properties.Resources.p2;
            this.skinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel1.Controls.Add(this.idcard_ttb);
            this.skinPanel1.Controls.Add(this.sex_ttb);
            this.skinPanel1.Controls.Add(this.username_ttb);
            this.skinPanel1.Controls.Add(this.address_ttb);
            this.skinPanel1.Controls.Add(this.department_ttb);
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
            this.skinPanel1.Location = new System.Drawing.Point(60, 131);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(283, 347);
            this.skinPanel1.TabIndex = 11;
            // 
            // sex_ttb
            // 
            this.sex_ttb.BackColor = System.Drawing.Color.Transparent;
            this.sex_ttb.Icon = null;
            this.sex_ttb.IconIsButton = false;
            this.sex_ttb.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.sex_ttb.Location = new System.Drawing.Point(120, 232);
            this.sex_ttb.Margin = new System.Windows.Forms.Padding(0);
            this.sex_ttb.MinimumSize = new System.Drawing.Size(28, 28);
            this.sex_ttb.MouseBack = null;
            this.sex_ttb.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.sex_ttb.Name = "sex_ttb";
            this.sex_ttb.NormlBack = null;
            this.sex_ttb.Padding = new System.Windows.Forms.Padding(5);
            this.sex_ttb.Size = new System.Drawing.Size(117, 28);
            // 
            // sex_ttb.BaseText
            // 
            this.sex_ttb.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sex_ttb.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sex_ttb.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.sex_ttb.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.sex_ttb.SkinTxt.Name = "BaseText";
            this.sex_ttb.SkinTxt.Size = new System.Drawing.Size(107, 18);
            this.sex_ttb.SkinTxt.TabIndex = 0;
            this.sex_ttb.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sex_ttb.SkinTxt.WaterText = "";
            this.sex_ttb.TabIndex = 23;
            // 
            // username_ttb
            // 
            this.username_ttb.BackColor = System.Drawing.Color.Transparent;
            this.username_ttb.Icon = null;
            this.username_ttb.IconIsButton = false;
            this.username_ttb.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.username_ttb.Location = new System.Drawing.Point(120, 198);
            this.username_ttb.Margin = new System.Windows.Forms.Padding(0);
            this.username_ttb.MinimumSize = new System.Drawing.Size(28, 28);
            this.username_ttb.MouseBack = null;
            this.username_ttb.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.username_ttb.Name = "username_ttb";
            this.username_ttb.NormlBack = null;
            this.username_ttb.Padding = new System.Windows.Forms.Padding(5);
            this.username_ttb.Size = new System.Drawing.Size(117, 28);
            // 
            // username_ttb.BaseText
            // 
            this.username_ttb.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_ttb.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username_ttb.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.username_ttb.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.username_ttb.SkinTxt.Name = "BaseText";
            this.username_ttb.SkinTxt.Size = new System.Drawing.Size(107, 18);
            this.username_ttb.SkinTxt.TabIndex = 0;
            this.username_ttb.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.username_ttb.SkinTxt.WaterText = "";
            this.username_ttb.TabIndex = 22;
            // 
            // address_ttb
            // 
            this.address_ttb.BackColor = System.Drawing.Color.Transparent;
            this.address_ttb.Icon = null;
            this.address_ttb.IconIsButton = false;
            this.address_ttb.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.address_ttb.Location = new System.Drawing.Point(120, 132);
            this.address_ttb.Margin = new System.Windows.Forms.Padding(0);
            this.address_ttb.MinimumSize = new System.Drawing.Size(28, 28);
            this.address_ttb.MouseBack = null;
            this.address_ttb.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.address_ttb.Name = "address_ttb";
            this.address_ttb.NormlBack = null;
            this.address_ttb.Padding = new System.Windows.Forms.Padding(5);
            this.address_ttb.Size = new System.Drawing.Size(117, 28);
            // 
            // address_ttb.BaseText
            // 
            this.address_ttb.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address_ttb.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address_ttb.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.address_ttb.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.address_ttb.SkinTxt.Name = "BaseText";
            this.address_ttb.SkinTxt.Size = new System.Drawing.Size(107, 18);
            this.address_ttb.SkinTxt.TabIndex = 0;
            this.address_ttb.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.address_ttb.SkinTxt.WaterText = "";
            this.address_ttb.TabIndex = 20;
            // 
            // department_ttb
            // 
            this.department_ttb.BackColor = System.Drawing.Color.Transparent;
            this.department_ttb.Icon = null;
            this.department_ttb.IconIsButton = false;
            this.department_ttb.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.department_ttb.Location = new System.Drawing.Point(119, 99);
            this.department_ttb.Margin = new System.Windows.Forms.Padding(0);
            this.department_ttb.MinimumSize = new System.Drawing.Size(28, 28);
            this.department_ttb.MouseBack = null;
            this.department_ttb.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.department_ttb.Name = "department_ttb";
            this.department_ttb.NormlBack = null;
            this.department_ttb.Padding = new System.Windows.Forms.Padding(5);
            this.department_ttb.Size = new System.Drawing.Size(117, 28);
            // 
            // department_ttb.BaseText
            // 
            this.department_ttb.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.department_ttb.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.department_ttb.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.department_ttb.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.department_ttb.SkinTxt.Name = "BaseText";
            this.department_ttb.SkinTxt.Size = new System.Drawing.Size(107, 18);
            this.department_ttb.SkinTxt.TabIndex = 0;
            this.department_ttb.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.department_ttb.SkinTxt.WaterText = "";
            this.department_ttb.TabIndex = 19;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(17, 104);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(92, 17);
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
            this.return_but.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
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
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(17, 237);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(44, 17);
            this.skinLabel5.TabIndex = 11;
            this.skinLabel5.Text = "性别：";
            // 
            // password_tb
            // 
            this.password_tb.AutoSize = true;
            this.password_tb.BackColor = System.Drawing.Color.Transparent;
            this.password_tb.BorderColor = System.Drawing.Color.White;
            this.password_tb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password_tb.Location = new System.Drawing.Point(17, 169);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(55, 17);
            this.password_tb.TabIndex = 10;
            this.password_tb.Text = "医师id：";
            // 
            // address_tb
            // 
            this.address_tb.AutoSize = true;
            this.address_tb.BackColor = System.Drawing.Color.Transparent;
            this.address_tb.BorderColor = System.Drawing.Color.White;
            this.address_tb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.address_tb.Location = new System.Drawing.Point(17, 136);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(68, 17);
            this.address_tb.TabIndex = 9;
            this.address_tb.Text = "单位地址：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(17, 203);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(68, 17);
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
            this.ensure_btn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
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
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(72, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "你好！";
            // 
            // idcard_ttb
            // 
            this.idcard_ttb.BackColor = System.Drawing.Color.Transparent;
            this.idcard_ttb.Icon = null;
            this.idcard_ttb.IconIsButton = false;
            this.idcard_ttb.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.idcard_ttb.Location = new System.Drawing.Point(120, 165);
            this.idcard_ttb.Margin = new System.Windows.Forms.Padding(0);
            this.idcard_ttb.MinimumSize = new System.Drawing.Size(28, 28);
            this.idcard_ttb.MouseBack = null;
            this.idcard_ttb.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.idcard_ttb.Name = "idcard_ttb";
            this.idcard_ttb.NormlBack = null;
            this.idcard_ttb.Padding = new System.Windows.Forms.Padding(5);
            this.idcard_ttb.Size = new System.Drawing.Size(117, 28);
            // 
            // idcard_ttb.BaseText
            // 
            this.idcard_ttb.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idcard_ttb.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idcard_ttb.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.idcard_ttb.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.idcard_ttb.SkinTxt.Name = "BaseText";
            this.idcard_ttb.SkinTxt.Size = new System.Drawing.Size(107, 18);
            this.idcard_ttb.SkinTxt.TabIndex = 0;
            this.idcard_ttb.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.idcard_ttb.SkinTxt.WaterText = "";
            this.idcard_ttb.TabIndex = 24;
            // 
            // usersetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(420, 485);
            this.CloseDownBack = global::WinForm.Properties.Resources.CloseDownBack;
            this.CloseMouseBack = global::WinForm.Properties.Resources.CloseMouseBack;
            this.CloseNormlBack = global::WinForm.Properties.Resources.CloseNormlBack1;
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.label1);
            this.MaxSize = new System.Drawing.Size(0, 0);
            this.MiniDownBack = global::WinForm.Properties.Resources.MiniDownBack;
            this.MiniMouseBack = global::WinForm.Properties.Resources.MiniMouseBack;
            this.MiniNormlBack = global::WinForm.Properties.Resources.MiniNormlBack;
            this.Name = "usersetting";
            this.Text = "usersetting";
            this.Load += new System.EventHandler(this.usersetting_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.sex_ttb.ResumeLayout(false);
            this.sex_ttb.PerformLayout();
            this.username_ttb.ResumeLayout(false);
            this.username_ttb.PerformLayout();
            this.address_ttb.ResumeLayout(false);
            this.address_ttb.PerformLayout();
            this.department_ttb.ResumeLayout(false);
            this.department_ttb.PerformLayout();
            this.idcard_ttb.ResumeLayout(false);
            this.idcard_ttb.PerformLayout();
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
        private CCWin.SkinControl.SkinTextBox sex_ttb;
        private CCWin.SkinControl.SkinTextBox username_ttb;
        private CCWin.SkinControl.SkinTextBox address_ttb;
        private CCWin.SkinControl.SkinTextBox department_ttb;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox idcard_ttb;
    }
}