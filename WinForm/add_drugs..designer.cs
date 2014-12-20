namespace WinForm
{
    partial class add_drugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_drugs));
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skinTextBox2 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.bt_save = new CCWin.SkinControl.SkinButton();
            this.bt_cancel = new CCWin.SkinControl.SkinButton();
            this.btn_import = new CCWin.SkinControl.SkinButton();
            this.sfdlgBackup = new System.Windows.Forms.OpenFileDialog();
            this.药物 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.简码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.味经 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.注意 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.功效 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上限 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.下限 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产地 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.skinTextBox2.SuspendLayout();
            this.skinTextBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(141, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 108);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(26, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 108);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.White;
            this.skinPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinPanel1.Controls.Add(this.dataGridView1);
            this.skinPanel1.Controls.Add(this.skinTextBox2);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Controls.Add(this.dateTimePicker1);
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.skinTextBox1);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skinPanel1.Location = new System.Drawing.Point(26, 162);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(740, 404);
            this.skinPanel1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.药物,
            this.简码,
            this.味经,
            this.注意,
            this.功效,
            this.上限,
            this.下限,
            this.单位,
            this.数量,
            this.进价,
            this.单价,
            this.产地});
            this.dataGridView1.Location = new System.Drawing.Point(38, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 48;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.Size = new System.Drawing.Size(671, 301);
            this.dataGridView1.TabIndex = 13;
            // 
            // skinTextBox2
            // 
            this.skinTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox2.Icon = null;
            this.skinTextBox2.IconIsButton = false;
            this.skinTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Location = new System.Drawing.Point(576, 12);
            this.skinTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox2.MouseBack = null;
            this.skinTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Name = "skinTextBox2";
            this.skinTextBox2.NormlBack = null;
            this.skinTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox2.Size = new System.Drawing.Size(92, 28);
            // 
            // skinTextBox2.BaseText
            // 
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(82, 22);
            this.skinTextBox2.SkinTxt.TabIndex = 0;
            this.skinTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.SkinTxt.WaterText = "";
            this.skinTextBox2.TabIndex = 12;
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.PowderBlue;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel6.Location = new System.Drawing.Point(521, 16);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(54, 20);
            this.skinLabel6.TabIndex = 11;
            this.skinLabel6.Text = "经手人";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(376, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 25);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.PowderBlue;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel5.Location = new System.Drawing.Point(301, 15);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(69, 20);
            this.skinLabel5.TabIndex = 9;
            this.skinLabel5.Text = "录单日期";
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Location = new System.Drawing.Point(146, 11);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.Size = new System.Drawing.Size(111, 28);
            // 
            // skinTextBox1.BaseText
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(101, 22);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 8;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.PowderBlue;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel3.Location = new System.Drawing.Point(80, 15);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(69, 20);
            this.skinLabel3.TabIndex = 7;
            this.skinLabel3.Text = "单据编号";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(-13, 35);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(1059, 20);
            this.skinLabel2.TabIndex = 6;
            this.skinLabel2.Text = "_________________________________________________________________________________" +
                "_____________________________________________________________________";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.Black;
            this.skinLabel4.Location = new System.Drawing.Point(19, 86);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(0, 24);
            this.skinLabel4.TabIndex = 5;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel1.Location = new System.Drawing.Point(39, 122);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(69, 20);
            this.skinLabel1.TabIndex = 25;
            this.skinLabel1.Text = "库存状况";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel7.Location = new System.Drawing.Point(153, 122);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(69, 20);
            this.skinLabel7.TabIndex = 26;
            this.skinLabel7.Text = "药品进货";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel8.Location = new System.Drawing.Point(357, 107);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(126, 30);
            this.skinLabel8.TabIndex = 27;
            this.skinLabel8.Text = "药 品 进 货";
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.Transparent;
            this.bt_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_save.BackgroundImage")));
            this.bt_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_save.BaseColor = System.Drawing.Color.PowderBlue;
            this.bt_save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bt_save.DownBack = null;
            this.bt_save.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.bt_save.Font = new System.Drawing.Font("微软雅黑", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_save.Location = new System.Drawing.Point(571, 575);
            this.bt_save.MouseBack = ((System.Drawing.Image)(resources.GetObject("bt_save.MouseBack")));
            this.bt_save.Name = "bt_save";
            this.bt_save.NormlBack = ((System.Drawing.Image)(resources.GetObject("bt_save.NormlBack")));
            this.bt_save.Size = new System.Drawing.Size(78, 37);
            this.bt_save.TabIndex = 28;
            this.bt_save.Text = "保存";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click_1);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.Transparent;
            this.bt_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_cancel.BackgroundImage")));
            this.bt_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cancel.BaseColor = System.Drawing.Color.PowderBlue;
            this.bt_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bt_cancel.DownBack = null;
            this.bt_cancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.bt_cancel.Font = new System.Drawing.Font("微软雅黑", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_cancel.Location = new System.Drawing.Point(688, 575);
            this.bt_cancel.MouseBack = ((System.Drawing.Image)(resources.GetObject("bt_cancel.MouseBack")));
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.NormlBack = ((System.Drawing.Image)(resources.GetObject("bt_cancel.NormlBack")));
            this.bt_cancel.Size = new System.Drawing.Size(78, 37);
            this.bt_cancel.TabIndex = 29;
            this.bt_cancel.Text = "退出";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click_1);
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.Transparent;
            this.btn_import.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_import.BackgroundImage")));
            this.btn_import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_import.BaseColor = System.Drawing.Color.PowderBlue;
            this.btn_import.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_import.DownBack = null;
            this.btn_import.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_import.Font = new System.Drawing.Font("微软雅黑", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_import.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_import.Location = new System.Drawing.Point(450, 575);
            this.btn_import.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_import.MouseBack")));
            this.btn_import.Name = "btn_import";
            this.btn_import.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_import.NormlBack")));
            this.btn_import.Size = new System.Drawing.Size(78, 37);
            this.btn_import.TabIndex = 30;
            this.btn_import.Text = "导入";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // sfdlgBackup
            // 
            this.sfdlgBackup.FileName = "openFileDialog1";
            // 
            // 药物
            // 
            this.药物.DataPropertyName = "药物";
            this.药物.HeaderText = "药物";
            this.药物.Name = "药物";
            this.药物.Width = 56;
            // 
            // 简码
            // 
            this.简码.DataPropertyName = "简码";
            this.简码.HeaderText = "简码";
            this.简码.Name = "简码";
            this.简码.Width = 55;
            // 
            // 味经
            // 
            this.味经.DataPropertyName = "味经";
            this.味经.HeaderText = "味经";
            this.味经.Name = "味经";
            this.味经.Width = 56;
            // 
            // 注意
            // 
            this.注意.DataPropertyName = "注意";
            this.注意.HeaderText = "注意";
            this.注意.Name = "注意";
            this.注意.Width = 56;
            // 
            // 功效
            // 
            this.功效.DataPropertyName = "功效";
            this.功效.HeaderText = "功效";
            this.功效.Name = "功效";
            this.功效.Width = 55;
            // 
            // 上限
            // 
            this.上限.DataPropertyName = "上限";
            this.上限.HeaderText = "上限";
            this.上限.Name = "上限";
            this.上限.Width = 56;
            // 
            // 下限
            // 
            this.下限.DataPropertyName = "下限";
            this.下限.HeaderText = "下限";
            this.下限.Name = "下限";
            this.下限.Width = 56;
            // 
            // 单位
            // 
            this.单位.DataPropertyName = "单位";
            this.单位.HeaderText = "单位";
            this.单位.Name = "单位";
            this.单位.Width = 55;
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "数量";
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.Width = 56;
            // 
            // 进价
            // 
            this.进价.DataPropertyName = "进价";
            this.进价.HeaderText = "进价";
            this.进价.Name = "进价";
            this.进价.Width = 56;
            // 
            // 单价
            // 
            this.单价.DataPropertyName = "单价";
            this.单价.HeaderText = "单价";
            this.单价.Name = "单价";
            this.单价.Width = 55;
            // 
            // 产地
            // 
            this.产地.DataPropertyName = "产地";
            this.产地.HeaderText = "产地";
            this.产地.Name = "产地";
            this.产地.Width = 56;
            // 
            // add_drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(818, 619);
            this.CloseDownBack = global::WinForm.Properties.Resources.CloseDownBack;
            this.CloseMouseBack = global::WinForm.Properties.Resources.CloseMouseBack;
            this.CloseNormlBack = global::WinForm.Properties.Resources.CloseNormlBack1;
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.skinLabel8);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(0, 0);
            this.MiniDownBack = global::WinForm.Properties.Resources.MiniDownBack;
            this.MiniMouseBack = global::WinForm.Properties.Resources.MiniMouseBack;
            this.MiniNormlBack = global::WinForm.Properties.Resources.MiniNormlBack;
            this.Name = "add_drugs";
            this.ShadowWidth = 6;
            this.ShowBorder = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加药品";
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.skinTextBox2.ResumeLayout(false);
            this.skinTextBox2.PerformLayout();
            this.skinTextBox1.ResumeLayout(false);
            this.skinTextBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinTextBox skinTextBox2;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CCWin.SkinControl.SkinButton bt_save;
        private CCWin.SkinControl.SkinButton bt_cancel;
        private CCWin.SkinControl.SkinButton btn_import;
        private System.Windows.Forms.OpenFileDialog sfdlgBackup;
        private System.Windows.Forms.DataGridViewTextBoxColumn 药物;
        private System.Windows.Forms.DataGridViewTextBoxColumn 简码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 味经;
        private System.Windows.Forms.DataGridViewTextBoxColumn 注意;
        private System.Windows.Forms.DataGridViewTextBoxColumn 功效;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上限;
        private System.Windows.Forms.DataGridViewTextBoxColumn 下限;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产地;
    }
}