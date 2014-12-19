namespace WinForm
{
    partial class prescription_management
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prescription_management));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.dGV_recipe = new System.Windows.Forms.DataGridView();
            this.dGV_drug = new System.Windows.Forms.DataGridView();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.txb_search = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinPanel16 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel17 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel18 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel19 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel20 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel21 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel10 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel11 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel12 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel13 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel14 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel15 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel9 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel8 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel7 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel6 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel5 = new CCWin.SkinControl.SkinPanel();
            this.bt_alter = new CCWin.SkinControl.SkinButton();
            this.skinPanel4 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.bt_delete = new CCWin.SkinControl.SkinButton();
            this.bt_confirm = new CCWin.SkinControl.SkinButton();
            this.text_method = new CCWin.SkinControl.SkinWaterTextBox();
            this.text_function = new CCWin.SkinControl.SkinWaterTextBox();
            this.text_from = new CCWin.SkinControl.SkinWaterTextBox();
            this.text_code = new CCWin.SkinControl.SkinWaterTextBox();
            this.text_name = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.text_cure = new System.Windows.Forms.TextBox();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.bt_search = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_recipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_drug)).BeginInit();
            this.skinPanel3.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(18, 37);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(0, 17);
            this.skinLabel1.TabIndex = 3;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.skinLabel2.Location = new System.Drawing.Point(8, 54);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(65, 20);
            this.skinLabel2.TabIndex = 4;
            this.skinLabel2.Text = "方名搜索";
            // 
            // dGV_recipe
            // 
            this.dGV_recipe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGV_recipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_recipe.Location = new System.Drawing.Point(27, 98);
            this.dGV_recipe.Name = "dGV_recipe";
            this.dGV_recipe.RowHeadersVisible = false;
            this.dGV_recipe.RowTemplate.Height = 23;
            this.dGV_recipe.Size = new System.Drawing.Size(181, 158);
            this.dGV_recipe.TabIndex = 5;
            // 
            // dGV_drug
            // 
            this.dGV_drug.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGV_drug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_drug.Location = new System.Drawing.Point(27, 290);
            this.dGV_drug.Name = "dGV_drug";
            this.dGV_drug.RowHeadersVisible = false;
            this.dGV_drug.RowTemplate.Height = 23;
            this.dGV_drug.Size = new System.Drawing.Size(181, 215);
            this.dGV_drug.TabIndex = 7;
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.White;
            this.skinPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinPanel3.Controls.Add(this.txb_search);
            this.skinPanel3.Controls.Add(this.skinPanel16);
            this.skinPanel3.Controls.Add(this.skinPanel17);
            this.skinPanel3.Controls.Add(this.skinPanel18);
            this.skinPanel3.Controls.Add(this.skinPanel19);
            this.skinPanel3.Controls.Add(this.skinPanel20);
            this.skinPanel3.Controls.Add(this.skinPanel21);
            this.skinPanel3.Controls.Add(this.skinPanel10);
            this.skinPanel3.Controls.Add(this.skinPanel11);
            this.skinPanel3.Controls.Add(this.skinPanel12);
            this.skinPanel3.Controls.Add(this.skinPanel13);
            this.skinPanel3.Controls.Add(this.skinPanel14);
            this.skinPanel3.Controls.Add(this.skinPanel15);
            this.skinPanel3.Controls.Add(this.skinPanel9);
            this.skinPanel3.Controls.Add(this.skinPanel8);
            this.skinPanel3.Controls.Add(this.skinPanel7);
            this.skinPanel3.Controls.Add(this.skinPanel6);
            this.skinPanel3.Controls.Add(this.skinPanel5);
            this.skinPanel3.Controls.Add(this.bt_alter);
            this.skinPanel3.Controls.Add(this.skinPanel4);
            this.skinPanel3.Controls.Add(this.skinPanel1);
            this.skinPanel3.Controls.Add(this.skinLabel9);
            this.skinPanel3.Controls.Add(this.bt_delete);
            this.skinPanel3.Controls.Add(this.bt_confirm);
            this.skinPanel3.Controls.Add(this.text_method);
            this.skinPanel3.Controls.Add(this.text_function);
            this.skinPanel3.Controls.Add(this.text_from);
            this.skinPanel3.Controls.Add(this.text_code);
            this.skinPanel3.Controls.Add(this.text_name);
            this.skinPanel3.Controls.Add(this.skinLabel7);
            this.skinPanel3.Controls.Add(this.skinPanel2);
            this.skinPanel3.Controls.Add(this.skinLabel6);
            this.skinPanel3.Controls.Add(this.skinLabel5);
            this.skinPanel3.Controls.Add(this.skinLabel4);
            this.skinPanel3.Controls.Add(this.skinLabel3);
            this.skinPanel3.Controls.Add(this.bt_search);
            this.skinPanel3.Controls.Add(this.dGV_drug);
            this.skinPanel3.Controls.Add(this.dGV_recipe);
            this.skinPanel3.Controls.Add(this.skinLabel2);
            this.skinPanel3.Controls.Add(this.skinLabel1);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(22, 39);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Size = new System.Drawing.Size(747, 519);
            this.skinPanel3.TabIndex = 9;
            // 
            // txb_search
            // 
            this.txb_search.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.txb_search.Location = new System.Drawing.Point(75, 54);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(103, 27);
            this.txb_search.TabIndex = 10;
            this.txb_search.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txb_search.WaterText = "";
            // 
            // skinPanel16
            // 
            this.skinPanel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinPanel16.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel16.DownBack = null;
            this.skinPanel16.Location = new System.Drawing.Point(714, 21);
            this.skinPanel16.MouseBack = null;
            this.skinPanel16.Name = "skinPanel16";
            this.skinPanel16.NormlBack = null;
            this.skinPanel16.Size = new System.Drawing.Size(21, 35);
            this.skinPanel16.TabIndex = 48;
            // 
            // skinPanel17
            // 
            this.skinPanel17.BackColor = System.Drawing.Color.Teal;
            this.skinPanel17.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel17.DownBack = null;
            this.skinPanel17.Location = new System.Drawing.Point(687, 21);
            this.skinPanel17.MouseBack = null;
            this.skinPanel17.Name = "skinPanel17";
            this.skinPanel17.NormlBack = null;
            this.skinPanel17.Size = new System.Drawing.Size(21, 35);
            this.skinPanel17.TabIndex = 47;
            // 
            // skinPanel18
            // 
            this.skinPanel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinPanel18.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel18.DownBack = null;
            this.skinPanel18.Location = new System.Drawing.Point(660, 21);
            this.skinPanel18.MouseBack = null;
            this.skinPanel18.Name = "skinPanel18";
            this.skinPanel18.NormlBack = null;
            this.skinPanel18.Size = new System.Drawing.Size(21, 35);
            this.skinPanel18.TabIndex = 46;
            // 
            // skinPanel19
            // 
            this.skinPanel19.BackColor = System.Drawing.Color.Teal;
            this.skinPanel19.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel19.DownBack = null;
            this.skinPanel19.Location = new System.Drawing.Point(606, 21);
            this.skinPanel19.MouseBack = null;
            this.skinPanel19.Name = "skinPanel19";
            this.skinPanel19.NormlBack = null;
            this.skinPanel19.Size = new System.Drawing.Size(21, 35);
            this.skinPanel19.TabIndex = 44;
            // 
            // skinPanel20
            // 
            this.skinPanel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinPanel20.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel20.DownBack = null;
            this.skinPanel20.Location = new System.Drawing.Point(633, 21);
            this.skinPanel20.MouseBack = null;
            this.skinPanel20.Name = "skinPanel20";
            this.skinPanel20.NormlBack = null;
            this.skinPanel20.Size = new System.Drawing.Size(21, 35);
            this.skinPanel20.TabIndex = 45;
            // 
            // skinPanel21
            // 
            this.skinPanel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinPanel21.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel21.DownBack = null;
            this.skinPanel21.Location = new System.Drawing.Point(579, 21);
            this.skinPanel21.MouseBack = null;
            this.skinPanel21.Name = "skinPanel21";
            this.skinPanel21.NormlBack = null;
            this.skinPanel21.Size = new System.Drawing.Size(21, 35);
            this.skinPanel21.TabIndex = 43;
            // 
            // skinPanel10
            // 
            this.skinPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinPanel10.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel10.DownBack = null;
            this.skinPanel10.Location = new System.Drawing.Point(552, 21);
            this.skinPanel10.MouseBack = null;
            this.skinPanel10.Name = "skinPanel10";
            this.skinPanel10.NormlBack = null;
            this.skinPanel10.Size = new System.Drawing.Size(21, 35);
            this.skinPanel10.TabIndex = 42;
            // 
            // skinPanel11
            // 
            this.skinPanel11.BackColor = System.Drawing.Color.Teal;
            this.skinPanel11.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel11.DownBack = null;
            this.skinPanel11.Location = new System.Drawing.Point(525, 21);
            this.skinPanel11.MouseBack = null;
            this.skinPanel11.Name = "skinPanel11";
            this.skinPanel11.NormlBack = null;
            this.skinPanel11.Size = new System.Drawing.Size(21, 35);
            this.skinPanel11.TabIndex = 41;
            // 
            // skinPanel12
            // 
            this.skinPanel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinPanel12.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel12.DownBack = null;
            this.skinPanel12.Location = new System.Drawing.Point(498, 21);
            this.skinPanel12.MouseBack = null;
            this.skinPanel12.Name = "skinPanel12";
            this.skinPanel12.NormlBack = null;
            this.skinPanel12.Size = new System.Drawing.Size(21, 35);
            this.skinPanel12.TabIndex = 40;
            // 
            // skinPanel13
            // 
            this.skinPanel13.BackColor = System.Drawing.Color.Teal;
            this.skinPanel13.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel13.DownBack = null;
            this.skinPanel13.Location = new System.Drawing.Point(444, 21);
            this.skinPanel13.MouseBack = null;
            this.skinPanel13.Name = "skinPanel13";
            this.skinPanel13.NormlBack = null;
            this.skinPanel13.Size = new System.Drawing.Size(21, 35);
            this.skinPanel13.TabIndex = 38;
            // 
            // skinPanel14
            // 
            this.skinPanel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinPanel14.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel14.DownBack = null;
            this.skinPanel14.Location = new System.Drawing.Point(471, 21);
            this.skinPanel14.MouseBack = null;
            this.skinPanel14.Name = "skinPanel14";
            this.skinPanel14.NormlBack = null;
            this.skinPanel14.Size = new System.Drawing.Size(21, 35);
            this.skinPanel14.TabIndex = 39;
            // 
            // skinPanel15
            // 
            this.skinPanel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinPanel15.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel15.DownBack = null;
            this.skinPanel15.Location = new System.Drawing.Point(415, 21);
            this.skinPanel15.MouseBack = null;
            this.skinPanel15.Name = "skinPanel15";
            this.skinPanel15.NormlBack = null;
            this.skinPanel15.Size = new System.Drawing.Size(21, 35);
            this.skinPanel15.TabIndex = 37;
            // 
            // skinPanel9
            // 
            this.skinPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinPanel9.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel9.DownBack = null;
            this.skinPanel9.Location = new System.Drawing.Point(388, 21);
            this.skinPanel9.MouseBack = null;
            this.skinPanel9.Name = "skinPanel9";
            this.skinPanel9.NormlBack = null;
            this.skinPanel9.Size = new System.Drawing.Size(21, 35);
            this.skinPanel9.TabIndex = 36;
            // 
            // skinPanel8
            // 
            this.skinPanel8.BackColor = System.Drawing.Color.Teal;
            this.skinPanel8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel8.DownBack = null;
            this.skinPanel8.Location = new System.Drawing.Point(361, 21);
            this.skinPanel8.MouseBack = null;
            this.skinPanel8.Name = "skinPanel8";
            this.skinPanel8.NormlBack = null;
            this.skinPanel8.Size = new System.Drawing.Size(21, 35);
            this.skinPanel8.TabIndex = 35;
            // 
            // skinPanel7
            // 
            this.skinPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinPanel7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel7.DownBack = null;
            this.skinPanel7.Location = new System.Drawing.Point(334, 21);
            this.skinPanel7.MouseBack = null;
            this.skinPanel7.Name = "skinPanel7";
            this.skinPanel7.NormlBack = null;
            this.skinPanel7.Size = new System.Drawing.Size(21, 35);
            this.skinPanel7.TabIndex = 34;
            // 
            // skinPanel6
            // 
            this.skinPanel6.BackColor = System.Drawing.Color.Teal;
            this.skinPanel6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel6.DownBack = null;
            this.skinPanel6.Location = new System.Drawing.Point(280, 21);
            this.skinPanel6.MouseBack = null;
            this.skinPanel6.Name = "skinPanel6";
            this.skinPanel6.NormlBack = null;
            this.skinPanel6.Size = new System.Drawing.Size(21, 35);
            this.skinPanel6.TabIndex = 33;
            // 
            // skinPanel5
            // 
            this.skinPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinPanel5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel5.DownBack = null;
            this.skinPanel5.Location = new System.Drawing.Point(307, 21);
            this.skinPanel5.MouseBack = null;
            this.skinPanel5.Name = "skinPanel5";
            this.skinPanel5.NormlBack = null;
            this.skinPanel5.Size = new System.Drawing.Size(21, 35);
            this.skinPanel5.TabIndex = 33;
            // 
            // bt_alter
            // 
            this.bt_alter.BackColor = System.Drawing.Color.White;
            this.bt_alter.BaseColor = System.Drawing.Color.PowderBlue;
            this.bt_alter.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bt_alter.DownBack = null;
            this.bt_alter.FadeGlow = false;
            this.bt_alter.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_alter.ForeColor = System.Drawing.Color.White;
            this.bt_alter.Image = ((System.Drawing.Image)(resources.GetObject("bt_alter.Image")));
            this.bt_alter.ImageWidth = 102;
            this.bt_alter.Location = new System.Drawing.Point(280, 470);
            this.bt_alter.MouseBack = null;
            this.bt_alter.Name = "bt_alter";
            this.bt_alter.NormlBack = null;
            this.bt_alter.Size = new System.Drawing.Size(102, 23);
            this.bt_alter.TabIndex = 27;
            this.bt_alter.Text = "修  改";
            this.bt_alter.UseVisualStyleBackColor = false;
            this.bt_alter.Click += new System.EventHandler(this.bt_alter_Click);
            // 
            // skinPanel4
            // 
            this.skinPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinPanel4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel4.DownBack = null;
            this.skinPanel4.Location = new System.Drawing.Point(252, 21);
            this.skinPanel4.MouseBack = null;
            this.skinPanel4.Name = "skinPanel4";
            this.skinPanel4.NormlBack = null;
            this.skinPanel4.Size = new System.Drawing.Size(21, 35);
            this.skinPanel4.TabIndex = 32;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(227, 37);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(16, 480);
            this.skinPanel1.TabIndex = 31;
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(214, 37);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(0, 17);
            this.skinLabel9.TabIndex = 30;
            this.skinLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.White;
            this.bt_delete.BaseColor = System.Drawing.Color.PowderBlue;
            this.bt_delete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bt_delete.DownBack = null;
            this.bt_delete.FadeGlow = false;
            this.bt_delete.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_delete.ForeColor = System.Drawing.Color.White;
            this.bt_delete.Image = ((System.Drawing.Image)(resources.GetObject("bt_delete.Image")));
            this.bt_delete.ImageWidth = 102;
            this.bt_delete.Location = new System.Drawing.Point(579, 470);
            this.bt_delete.MouseBack = null;
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.NormlBack = null;
            this.bt_delete.Size = new System.Drawing.Size(102, 23);
            this.bt_delete.TabIndex = 29;
            this.bt_delete.Text = "删除";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_confirm
            // 
            this.bt_confirm.BackColor = System.Drawing.Color.White;
            this.bt_confirm.BaseColor = System.Drawing.Color.PowderBlue;
            this.bt_confirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bt_confirm.DownBack = null;
            this.bt_confirm.FadeGlow = false;
            this.bt_confirm.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bt_confirm.ForeColor = System.Drawing.Color.White;
            this.bt_confirm.Image = ((System.Drawing.Image)(resources.GetObject("bt_confirm.Image")));
            this.bt_confirm.ImageWidth = 102;
            this.bt_confirm.Location = new System.Drawing.Point(426, 470);
            this.bt_confirm.MouseBack = null;
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.NormlBack = null;
            this.bt_confirm.Size = new System.Drawing.Size(102, 23);
            this.bt_confirm.TabIndex = 28;
            this.bt_confirm.Text = "增加";
            this.bt_confirm.UseVisualStyleBackColor = false;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // text_method
            // 
            this.text_method.Location = new System.Drawing.Point(332, 400);
            this.text_method.Name = "text_method";
            this.text_method.Size = new System.Drawing.Size(347, 21);
            this.text_method.TabIndex = 26;
            this.text_method.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_method.WaterText = "";
            // 
            // text_function
            // 
            this.text_function.Location = new System.Drawing.Point(332, 146);
            this.text_function.Name = "text_function";
            this.text_function.Size = new System.Drawing.Size(347, 21);
            this.text_function.TabIndex = 25;
            this.text_function.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_function.WaterText = "";
            // 
            // text_from
            // 
            this.text_from.Location = new System.Drawing.Point(332, 116);
            this.text_from.Name = "text_from";
            this.text_from.Size = new System.Drawing.Size(133, 21);
            this.text_from.TabIndex = 24;
            this.text_from.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_from.WaterText = "";
            // 
            // text_code
            // 
            this.text_code.Location = new System.Drawing.Point(566, 83);
            this.text_code.Name = "text_code";
            this.text_code.Size = new System.Drawing.Size(60, 21);
            this.text_code.TabIndex = 23;
            this.text_code.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_code.WaterText = "";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(332, 83);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(133, 21);
            this.text_name.TabIndex = 22;
            this.text_name.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_name.WaterText = "";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel7.Location = new System.Drawing.Point(276, 399);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(39, 20);
            this.skinLabel7.TabIndex = 21;
            this.skinLabel7.Text = "方解";
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinPanel2.Controls.Add(this.text_cure);
            this.skinPanel2.Controls.Add(this.skinLabel8);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(279, 189);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(413, 196);
            this.skinPanel2.TabIndex = 20;
            // 
            // text_cure
            // 
            this.text_cure.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_cure.Location = new System.Drawing.Point(23, 32);
            this.text_cure.Multiline = true;
            this.text_cure.Name = "text_cure";
            this.text_cure.Size = new System.Drawing.Size(365, 145);
            this.text_cure.TabIndex = 10;
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel8.Location = new System.Drawing.Point(182, 8);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(39, 20);
            this.skinLabel8.TabIndex = 9;
            this.skinLabel8.Text = "主治";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel6.Location = new System.Drawing.Point(276, 144);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(39, 20);
            this.skinLabel6.TabIndex = 19;
            this.skinLabel6.Text = "功效";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel5.Location = new System.Drawing.Point(275, 113);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(39, 20);
            this.skinLabel5.TabIndex = 18;
            this.skinLabel5.Text = "出自";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel4.Location = new System.Drawing.Point(507, 80);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(39, 20);
            this.skinLabel4.TabIndex = 17;
            this.skinLabel4.Text = "简码";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skinLabel3.Location = new System.Drawing.Point(274, 81);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(39, 20);
            this.skinLabel3.TabIndex = 16;
            this.skinLabel3.Text = "方名";
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.Transparent;
            this.bt_search.BaseColor = System.Drawing.Color.PowderBlue;
            this.bt_search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bt_search.DownBack = null;
            this.bt_search.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.bt_search.Image = ((System.Drawing.Image)(resources.GetObject("bt_search.Image")));
            this.bt_search.Location = new System.Drawing.Point(184, 50);
            this.bt_search.MouseBack = null;
            this.bt_search.Name = "bt_search";
            this.bt_search.NormlBack = null;
            this.bt_search.Size = new System.Drawing.Size(30, 30);
            this.bt_search.TabIndex = 8;
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // prescription_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ClientSize = new System.Drawing.Size(786, 574);
            this.CloseDownBack = global::WinForm.Properties.Resources.CloseDownBack;
            this.CloseMouseBack = global::WinForm.Properties.Resources.CloseMouseBack;
            this.CloseNormlBack = global::WinForm.Properties.Resources.CloseNormlBack1;
            this.Controls.Add(this.skinPanel3);
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(0, 0);
            this.MiniDownBack = global::WinForm.Properties.Resources.MiniDownBack;
            this.MiniMouseBack = global::WinForm.Properties.Resources.MiniMouseBack;
            this.MiniNormlBack = global::WinForm.Properties.Resources.MiniNormlBack;
            this.Name = "prescription_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "验方管理";
            this.Load += new System.EventHandler(this.验方管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_recipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_drug)).EndInit();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.DataGridView dGV_recipe;
        private System.Windows.Forms.DataGridView dGV_drug;
        internal CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinPanel skinPanel3;
        private CCWin.SkinControl.SkinWaterTextBox text_method;
        private CCWin.SkinControl.SkinWaterTextBox text_function;
        private CCWin.SkinControl.SkinWaterTextBox text_from;
        private CCWin.SkinControl.SkinWaterTextBox text_code;
        private CCWin.SkinControl.SkinWaterTextBox text_name;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private System.Windows.Forms.TextBox text_cure;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton bt_alter;
        private CCWin.SkinControl.SkinButton bt_delete;
        private CCWin.SkinControl.SkinButton bt_confirm;
        private CCWin.SkinControl.SkinPanel skinPanel16;
        private CCWin.SkinControl.SkinPanel skinPanel17;
        private CCWin.SkinControl.SkinPanel skinPanel18;
        private CCWin.SkinControl.SkinPanel skinPanel19;
        private CCWin.SkinControl.SkinPanel skinPanel20;
        private CCWin.SkinControl.SkinPanel skinPanel21;
        private CCWin.SkinControl.SkinPanel skinPanel10;
        private CCWin.SkinControl.SkinPanel skinPanel11;
        private CCWin.SkinControl.SkinPanel skinPanel12;
        private CCWin.SkinControl.SkinPanel skinPanel13;
        private CCWin.SkinControl.SkinPanel skinPanel14;
        private CCWin.SkinControl.SkinPanel skinPanel15;
        private CCWin.SkinControl.SkinPanel skinPanel9;
        private CCWin.SkinControl.SkinPanel skinPanel8;
        private CCWin.SkinControl.SkinPanel skinPanel7;
        private CCWin.SkinControl.SkinPanel skinPanel6;
        private CCWin.SkinControl.SkinPanel skinPanel5;
        private CCWin.SkinControl.SkinPanel skinPanel4;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinWaterTextBox txb_search;
        private CCWin.SkinControl.SkinButton bt_search;


    }
}

