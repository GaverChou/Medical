namespace WinForm
{
    partial class 药品管理
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
            this.btn_delete = new CCWin.SkinControl.SkinButton();
            this.tx_count = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinWaterTextBox1 = new CCWin.SkinControl.SkinWaterTextBox();
            this.tx_search = new CCWin.SkinControl.SkinWaterTextBox();
            this.btn_search = new CCWin.SkinControl.SkinButton();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.drugs_dvg = new System.Windows.Forms.DataGridView();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugs_dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.skinPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinPanel1.Controls.Add(this.btn_delete);
            this.skinPanel1.Controls.Add(this.tx_count);
            this.skinPanel1.Controls.Add(this.skinWaterTextBox1);
            this.skinPanel1.Controls.Add(this.tx_search);
            this.skinPanel1.Controls.Add(this.btn_search);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.drugs_dvg);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skinPanel1.Location = new System.Drawing.Point(26, 150);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(740, 430);
            this.skinPanel1.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BaseColor = System.Drawing.Color.PowderBlue;
            this.btn_delete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_delete.DownBack = null;
            this.btn_delete.Location = new System.Drawing.Point(112, 379);
            this.btn_delete.MouseBack = null;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.NormlBack = null;
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // tx_count
            // 
            this.tx_count.Location = new System.Drawing.Point(543, 44);
            this.tx_count.Name = "tx_count";
            this.tx_count.ReadOnly = true;
            this.tx_count.Size = new System.Drawing.Size(100, 25);
            this.tx_count.TabIndex = 10;
            this.tx_count.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tx_count.WaterText = "";
            // 
            // skinWaterTextBox1
            // 
            this.skinWaterTextBox1.Location = new System.Drawing.Point(312, 44);
            this.skinWaterTextBox1.Name = "skinWaterTextBox1";
            this.skinWaterTextBox1.ReadOnly = true;
            this.skinWaterTextBox1.Size = new System.Drawing.Size(100, 25);
            this.skinWaterTextBox1.TabIndex = 9;
            this.skinWaterTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox1.WaterText = "";
            // 
            // tx_search
            // 
            this.tx_search.Location = new System.Drawing.Point(87, 86);
            this.tx_search.Name = "tx_search";
            this.tx_search.Size = new System.Drawing.Size(100, 25);
            this.tx_search.TabIndex = 8;
            this.tx_search.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tx_search.WaterText = "";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BaseColor = System.Drawing.Color.PowderBlue;
            this.btn_search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_search.DownBack = null;
            this.btn_search.Location = new System.Drawing.Point(112, 113);
            this.btn_search.MouseBack = null;
            this.btn_search.Name = "btn_search";
            this.btn_search.NormlBack = null;
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "确定";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.Black;
            this.skinLabel4.Location = new System.Drawing.Point(5, 86);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(82, 24);
            this.skinLabel4.TabIndex = 5;
            this.skinLabel4.Text = "药品查询";
            this.skinLabel4.UseMnemonic = false;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.skinLabel3.Location = new System.Drawing.Point(450, 45);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(100, 24);
            this.skinLabel3.TabIndex = 3;
            this.skinLabel3.Text = "库存总量：";
            this.skinLabel3.UseMnemonic = false;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.skinLabel2.Location = new System.Drawing.Point(202, 45);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(118, 24);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "库存药种类：";
            this.skinLabel2.UseMnemonic = false;
            // 
            // drugs_dvg
            // 
            this.drugs_dvg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drugs_dvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drugs_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drugs_dvg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.drugs_dvg.Location = new System.Drawing.Point(205, 82);
            this.drugs_dvg.Name = "drugs_dvg";
            this.drugs_dvg.RowHeadersVisible = false;
            this.drugs_dvg.RowTemplate.Height = 23;
            this.drugs_dvg.Size = new System.Drawing.Size(507, 320);
            this.drugs_dvg.TabIndex = 0;
            this.drugs_dvg.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.drugs_dvg_CellMouseClick);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.skinLabel1.Location = new System.Drawing.Point(317, 106);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(242, 39);
            this.skinLabel1.TabIndex = 7;
            this.skinLabel1.Text = "药 材 库 存 状 况";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(41, 113);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(88, 25);
            this.skinLabel5.TabIndex = 10;
            this.skinLabel5.Text = "库存状况";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(152, 114);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(88, 25);
            this.skinLabel6.TabIndex = 11;
            this.skinLabel6.Text = "药品进货";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button3.Location = new System.Drawing.Point(141, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 108);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button1.Location = new System.Drawing.Point(26, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 108);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // 药品管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ClientSize = new System.Drawing.Size(792, 605);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "药品管理";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "药品管理";
            this.Load += new System.EventHandler(this.药品管理_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugs_dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private System.Windows.Forms.DataGridView drugs_dvg;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.Button button1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.Button button3;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinButton btn_search;
        private CCWin.SkinControl.SkinWaterTextBox tx_search;
        private CCWin.SkinControl.SkinWaterTextBox tx_count;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox1;
        private CCWin.SkinControl.SkinButton btn_delete;

    }
}