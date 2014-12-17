namespace WinForm
{
    partial class Patient
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chufang_bx = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bingshi_bx = new System.Windows.Forms.RichTextBox();
            this.patient_dwg = new System.Windows.Forms.DataGridView();
            this.data_box = new System.Windows.Forms.GroupBox();
            this.date_time = new System.Windows.Forms.DateTimePicker();
            this.pb_patient = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.save_btn = new CCWin.SkinControl.SkinButton();
            this.doc_tb = new System.Windows.Forms.TextBox();
            this.money_tb = new System.Windows.Forms.TextBox();
            this.name_find_tb = new System.Windows.Forms.TextBox();
            this.zhenduan_tb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.old_tb = new System.Windows.Forms.TextBox();
            this.gender_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.skinPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_dwg)).BeginInit();
            this.data_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.White;
            this.skinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel1.Controls.Add(this.label9);
            this.skinPanel1.Controls.Add(this.panel2);
            this.skinPanel1.Controls.Add(this.label8);
            this.skinPanel1.Controls.Add(this.panel1);
            this.skinPanel1.Controls.Add(this.patient_dwg);
            this.skinPanel1.Controls.Add(this.data_box);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(14, 32);
            this.skinPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(1029, 686);
            this.skinPanel1.TabIndex = 0;
            this.skinPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.skinPanel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.PowderBlue;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(522, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = " 处 方 药 物  ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chufang_bx);
            this.panel2.Location = new System.Drawing.Point(510, 436);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 246);
            this.panel2.TabIndex = 16;
            // 
            // chufang_bx
            // 
            this.chufang_bx.Enabled = false;
            this.chufang_bx.Location = new System.Drawing.Point(3, 4);
            this.chufang_bx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chufang_bx.Name = "chufang_bx";
            this.chufang_bx.Size = new System.Drawing.Size(490, 232);
            this.chufang_bx.TabIndex = 0;
            this.chufang_bx.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PowderBlue;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(27, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = " 病 史 记 录  ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bingshi_bx);
            this.panel1.Location = new System.Drawing.Point(20, 436);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 246);
            this.panel1.TabIndex = 2;
            // 
            // bingshi_bx
            // 
            this.bingshi_bx.BackColor = System.Drawing.Color.AliceBlue;
            this.bingshi_bx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bingshi_bx.Enabled = false;
            this.bingshi_bx.Location = new System.Drawing.Point(0, 4);
            this.bingshi_bx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bingshi_bx.Name = "bingshi_bx";
            this.bingshi_bx.Size = new System.Drawing.Size(479, 232);
            this.bingshi_bx.TabIndex = 0;
            this.bingshi_bx.Text = "";
            // 
            // patient_dwg
            // 
            this.patient_dwg.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.patient_dwg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patient_dwg.Location = new System.Drawing.Point(510, 29);
            this.patient_dwg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patient_dwg.Name = "patient_dwg";
            this.patient_dwg.RowHeadersVisible = false;
            this.patient_dwg.RowTemplate.Height = 23;
            this.patient_dwg.Size = new System.Drawing.Size(497, 352);
            this.patient_dwg.TabIndex = 1;
            this.patient_dwg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patient_dwg_CellClick);
            // 
            // data_box
            // 
            this.data_box.Controls.Add(this.date_time);
            this.data_box.Controls.Add(this.pb_patient);
            this.data_box.Controls.Add(this.comboBox1);
            this.data_box.Controls.Add(this.skinButton1);
            this.data_box.Controls.Add(this.save_btn);
            this.data_box.Controls.Add(this.doc_tb);
            this.data_box.Controls.Add(this.money_tb);
            this.data_box.Controls.Add(this.name_find_tb);
            this.data_box.Controls.Add(this.zhenduan_tb);
            this.data_box.Controls.Add(this.label14);
            this.data_box.Controls.Add(this.label13);
            this.data_box.Controls.Add(this.label12);
            this.data_box.Controls.Add(this.label10);
            this.data_box.Controls.Add(this.address_tb);
            this.data_box.Controls.Add(this.phone_tb);
            this.data_box.Controls.Add(this.id_tb);
            this.data_box.Controls.Add(this.old_tb);
            this.data_box.Controls.Add(this.gender_tb);
            this.data_box.Controls.Add(this.name_tb);
            this.data_box.Controls.Add(this.label6);
            this.data_box.Controls.Add(this.label5);
            this.data_box.Controls.Add(this.label4);
            this.data_box.Controls.Add(this.label2);
            this.data_box.Controls.Add(this.label1);
            this.data_box.Controls.Add(this.label3);
            this.data_box.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.data_box.Location = new System.Drawing.Point(20, 19);
            this.data_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_box.Name = "data_box";
            this.data_box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_box.Size = new System.Drawing.Size(483, 362);
            this.data_box.TabIndex = 0;
            this.data_box.TabStop = false;
            this.data_box.Text = "基本信息";
            this.data_box.Enter += new System.EventHandler(this.data_box_Enter);
            // 
            // date_time
            // 
            this.date_time.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.date_time.Location = new System.Drawing.Point(326, 266);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(85, 23);
            this.date_time.TabIndex = 42;
            this.date_time.Visible = false;
            // 
            // pb_patient
            // 
            this.pb_patient.Image = global::WinForm.Properties.Resources.add;
            this.pb_patient.Location = new System.Drawing.Point(52, 27);
            this.pb_patient.Name = "pb_patient";
            this.pb_patient.Size = new System.Drawing.Size(110, 128);
            this.pb_patient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_patient.TabIndex = 41;
            this.pb_patient.TabStop = false;
            this.pb_patient.Click += new System.EventHandler(this.pb_patient_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "姓名",
            "日期"});
            this.comboBox1.Location = new System.Drawing.Point(417, 266);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 25);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.Text = "姓名";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.PowderBlue;
            this.skinButton1.BaseColor = System.Drawing.Color.PowderBlue;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skinButton1.Location = new System.Drawing.Point(262, 311);
            this.skinButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinButton1.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.skinButton1.Size = new System.Drawing.Size(88, 32);
            this.skinButton1.TabIndex = 39;
            this.skinButton1.Text = "查询";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.PowderBlue;
            this.save_btn.BaseColor = System.Drawing.Color.PowderBlue;
            this.save_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.save_btn.DownBack = null;
            this.save_btn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.save_btn.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_btn.Location = new System.Drawing.Point(387, 311);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_btn.MouseBack = global::WinForm.Properties.Resources.blue_btn_normal;
            this.save_btn.Name = "save_btn";
            this.save_btn.NormlBack = global::WinForm.Properties.Resources.blue_btn_move;
            this.save_btn.Size = new System.Drawing.Size(88, 32);
            this.save_btn.TabIndex = 38;
            this.save_btn.Text = "保存";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // doc_tb
            // 
            this.doc_tb.Location = new System.Drawing.Point(326, 128);
            this.doc_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doc_tb.Name = "doc_tb";
            this.doc_tb.Size = new System.Drawing.Size(149, 23);
            this.doc_tb.TabIndex = 32;
            // 
            // money_tb
            // 
            this.money_tb.Location = new System.Drawing.Point(326, 174);
            this.money_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.money_tb.Name = "money_tb";
            this.money_tb.Size = new System.Drawing.Size(149, 23);
            this.money_tb.TabIndex = 31;
            // 
            // name_find_tb
            // 
            this.name_find_tb.Location = new System.Drawing.Point(326, 266);
            this.name_find_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_find_tb.Name = "name_find_tb";
            this.name_find_tb.Size = new System.Drawing.Size(85, 23);
            this.name_find_tb.TabIndex = 30;
            // 
            // zhenduan_tb
            // 
            this.zhenduan_tb.Location = new System.Drawing.Point(326, 36);
            this.zhenduan_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zhenduan_tb.Name = "zhenduan_tb";
            this.zhenduan_tb.Size = new System.Drawing.Size(149, 23);
            this.zhenduan_tb.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.PowderBlue;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(262, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 21);
            this.label14.TabIndex = 26;
            this.label14.Text = " 查 找 ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.PowderBlue;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(262, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = " 金 额 ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.PowderBlue;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(262, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 21);
            this.label12.TabIndex = 24;
            this.label12.Text = " 医 师 ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PowderBlue;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(262, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = " 诊 断 ";
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(326, 82);
            this.address_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(149, 23);
            this.address_tb.TabIndex = 20;
            // 
            // phone_tb
            // 
            this.phone_tb.Location = new System.Drawing.Point(326, 220);
            this.phone_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(149, 23);
            this.phone_tb.TabIndex = 19;
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(86, 270);
            this.id_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(105, 23);
            this.id_tb.TabIndex = 18;
            // 
            // old_tb
            // 
            this.old_tb.Location = new System.Drawing.Point(86, 220);
            this.old_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.old_tb.Name = "old_tb";
            this.old_tb.Size = new System.Drawing.Size(105, 23);
            this.old_tb.TabIndex = 17;
            // 
            // gender_tb
            // 
            this.gender_tb.Location = new System.Drawing.Point(86, 320);
            this.gender_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gender_tb.Name = "gender_tb";
            this.gender_tb.Size = new System.Drawing.Size(105, 23);
            this.gender_tb.TabIndex = 16;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(86, 170);
            this.name_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(105, 23);
            this.name_tb.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PowderBlue;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(262, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = " 住 址 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PowderBlue;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(262, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = " 电 话 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = " 编 号 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = " 年 龄 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = " 性 别 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = " 姓 名 ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1061, 727);
            this.Controls.Add(this.skinPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "病人管理";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patient_dwg)).EndInit();
            this.data_box.ResumeLayout(false);
            this.data_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_patient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private System.Windows.Forms.GroupBox data_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.TextBox phone_tb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox old_tb;
        private System.Windows.Forms.TextBox gender_tb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView patient_dwg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox doc_tb;
        private System.Windows.Forms.TextBox money_tb;
        private System.Windows.Forms.TextBox name_find_tb;
        private System.Windows.Forms.TextBox zhenduan_tb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton save_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox chufang_bx;
        private System.Windows.Forms.RichTextBox bingshi_bx;
        private System.Windows.Forms.PictureBox pb_patient;
        private System.Windows.Forms.DateTimePicker date_time;
    }
}