namespace WinForm
{
    partial class drugs_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drugs_management));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.btn_delete = new CCWin.SkinControl.SkinButton();
            this.tx_count = new CCWin.SkinControl.SkinWaterTextBox();
            this.tb_count = new CCWin.SkinControl.SkinWaterTextBox();
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
            this.skinPanel1.BackColor = System.Drawing.Color.Gray;
            this.skinPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinPanel1.Controls.Add(this.btn_delete);
            this.skinPanel1.Controls.Add(this.tx_count);
            this.skinPanel1.Controls.Add(this.tb_count);
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
            this.skinPanel1.Size = new System.Drawing.Size(755, 444);
            this.skinPanel1.TabIndex = 1;
            this.skinPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.skinPanel1_Paint);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BaseColor = System.Drawing.Color.PowderBlue;
            this.btn_delete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_delete.DownBack = null;
            this.btn_delete.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(625, 413);
            this.btn_delete.MouseBack = null;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.NormlBack = null;
            this.btn_delete.Size = new System.Drawing.Size(87, 18);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            // tb_count
            // 
            this.tb_count.Enabled = false;
            this.tb_count.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_count.Location = new System.Drawing.Point(312, 44);
            this.tb_count.Name = "tb_count";
            this.tb_count.ReadOnly = true;
            this.tb_count.Size = new System.Drawing.Size(100, 27);
            this.tb_count.TabIndex = 9;
            this.tb_count.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_count.WaterText = "";
            // 
            // tx_search
            // 
            this.tx_search.Location = new System.Drawing.Point(69, 89);
            this.tx_search.Name = "tx_search";
            this.tx_search.Size = new System.Drawing.Size(84, 25);
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
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(159, 86);
            this.btn_search.MouseBack = null;
            this.btn_search.Name = "btn_search";
            this.btn_search.NormlBack = null;
            this.btn_search.Size = new System.Drawing.Size(30, 30);
            this.btn_search.TabIndex = 7;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel4.ForeColor = System.Drawing.Color.Black;
            this.skinLabel4.Location = new System.Drawing.Point(1, 89);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(69, 20);
            this.skinLabel4.TabIndex = 5;
            this.skinLabel4.Text = "药品查询";
            this.skinLabel4.UseMnemonic = false;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel3.Location = new System.Drawing.Point(450, 45);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(84, 20);
            this.skinLabel3.TabIndex = 3;
            this.skinLabel3.Text = "库存总量：";
            this.skinLabel3.UseMnemonic = false;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel2.Location = new System.Drawing.Point(202, 45);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(99, 20);
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
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel1.Location = new System.Drawing.Point(346, 97);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(186, 30);
            this.skinLabel1.TabIndex = 7;
            this.skinLabel1.Text = "药 材 库 存 状 况";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel5.Location = new System.Drawing.Point(40, 123);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(69, 20);
            this.skinLabel5.TabIndex = 10;
            this.skinLabel5.Text = "库存状况";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel6.Location = new System.Drawing.Point(154, 122);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(69, 20);
            this.skinLabel6.TabIndex = 11;
            this.skinLabel6.Text = "药品进货";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(141, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 108);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(26, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 108);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // drugs_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ClientSize = new System.Drawing.Size(818, 619);
            this.CloseNormlBack = global::WinForm.Properties.Resources.CloseNormlBack1;
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skinPanel1);
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(0, 0);
            this.MiniNormlBack = global::WinForm.Properties.Resources.MiniNormlBack;
            this.Name = "drugs_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "药品管理";
            this.Load += new System.EventHandler(this.drugs_management_Load);
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
        private CCWin.SkinControl.SkinWaterTextBox tb_count;
        private CCWin.SkinControl.SkinButton btn_delete;

    }
}